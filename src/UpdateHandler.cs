using IMS.forms.update;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IMS.src
{
    internal class UpdateHandler
    {
        private const string VersionFileUrl = "https://raw.githubusercontent.com/nullblank/IMS/master/version.txt";
        private const string UpdatedApplicationUrl = "https://github.com/nullblank/IMS/releases/latest/download/IMS.zip";
        ProgressBar progressBar;
        Form_Update form_update;
        public UpdateHandler(ProgressBar progressBar, Form_Update form_update)
        {
            this.progressBar = progressBar;
            this.form_update = form_update;
        }
        private void CheckForUpdates()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string currentVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
                    string latestVersion = webClient.DownloadString(VersionFileUrl);

                    if (IsVersionNewer(latestVersion, currentVersion))
                    {
                        DialogResult dialogResult = MessageBox.Show("A newer version is available. Do you want to update now?", "Update Available", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            DownloadAndApplyUpdate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Application is up to date!", "Application up-to-date");
                    }
                }
                catch (WebException ex)
                {
                    // Handle any errors during version check
                    Console.WriteLine("Error checking for updates: " + ex.Message);
                }
            }
        }
        private bool IsVersionNewer(string latestVersion, string currentVersion)
        {
            Version latest = new Version(latestVersion);
            Version current = new Version(currentVersion);
            return latest.CompareTo(current) > 0;
        }
        private async Task DownloadAndApplyUpdate()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string tempUpdatePath = Path.Combine(Path.GetTempPath(), "YourApplication.zip");
                    await webClient.DownloadFileTaskAsync(new Uri(UpdatedApplicationUrl), tempUpdatePath);

                    string currentExePath = Assembly.GetEntryAssembly().Location;
                    string updateDir = Path.GetDirectoryName(currentExePath);


                    string extractPath = Path.Combine(updateDir, "UpdateFiles");
                    await Task.Run(() => ZipFile.ExtractToDirectory(tempUpdatePath, extractPath));

                    string[] updateFiles = Directory.GetFiles(extractPath, "*", SearchOption.AllDirectories);
                    var replaceTasks = new List<Task>();

                    int totalFiles = updateFiles.Length;
                    int completedFiles = 0;

                    foreach (string file in updateFiles)
                    {
                        string relativePath = file.Substring(extractPath.Length + 1);
                        string targetPath = Path.Combine(updateDir, relativePath);

                        var replaceTask = Task.Run(() =>
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
                            File.Copy(file, targetPath, true);
                        });

                        replaceTasks.Add(replaceTask);

                        completedFiles++;
                        int progressPercentage = (int)((float)completedFiles / totalFiles * 100);
                        UpdateProgressBar(progressPercentage);
                    }

                    await Task.WhenAll(replaceTasks);

                    Directory.Delete(extractPath, true);
                    File.Delete(tempUpdatePath);

                    Process.Start(currentExePath);
                    Environment.Exit(0);
                }
                catch (WebException ex)
                {
                    // Handle any errors during update download
                    Console.WriteLine("Error downloading update: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Handle any other errors during the update process
                    Console.WriteLine("Error applying update: " + ex.Message);
                }
            }
        }
        private void UpdateProgressBar(int progressPercentage)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action<int>(UpdateProgressBar), progressPercentage);
            }
            else
            {
                progressBar.Value = progressPercentage;
            }
        }
    }
}
