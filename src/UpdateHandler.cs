using IMS.forms.update;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Principal;
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
        Label lblAction;
        Label lblVAction;
        public UpdateHandler(ProgressBar progressBar, Form_Update form_update, Label lblAction, Label lblVAction)
        {
            this.progressBar = progressBar;
            this.form_update = form_update;
            this.lblAction = lblAction;
            this.lblVAction = lblVAction;
        }
        public void CheckForUpdates()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string currentVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
                    MessageBox.Show($"DEBUG VERSION IS: {currentVersion}");
                    string latestVersion = webClient.DownloadString(VersionFileUrl);

                    if (IsVersionNewer(latestVersion, currentVersion))
                    {
                        DialogResult dialogResult = MessageBox.Show("A newer version is available. Do you want to update now?", "Update Available", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (IsRunAsAdmin())
                            {
                                DownloadAndApplyUpdate();
                            }
                            else
                            {
                                MessageBox.Show("Warning: If you wish to update the software, please run the application as admin!", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                form_update.Close();
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Application is up-to-date!", "Application is up-to-date");
                    }
                }
                catch (WebException ex)
                {
                    // Handle any errors during version check
                    Console.WriteLine("Error checking for updates: " + ex.Message);
                }
            }
        }
        static bool IsRunAsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
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
                    lblAction.Text = "Downloading update...";
                    string tempUpdatePath = Path.Combine(Path.GetTempPath(), "YourApplication.zip");
                    await webClient.DownloadFileTaskAsync(new Uri(UpdatedApplicationUrl), tempUpdatePath);

                    string currentExePath = Assembly.GetEntryAssembly().Location;
                    string updateDir = Path.GetDirectoryName(currentExePath);

                    lblAction.Text = "Extracting zip...";
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
                        lblVAction.Text = $"Overwriting: {targetPath}";
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
                    MessageBox.Show("Update Finished! The application will now exit.", "Update Finished");
                    Environment.Exit(0);
                }
                catch (WebException ex)
                {
                    // Handle any errors during update download
                    MessageBox.Show("Error downloading update: " + ex.Message, "Download Error");
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    // Handle any other errors during the update process
                    MessageBox.Show("Error applying update: " + ex.Message, "Update Error");
                    Environment.Exit(0);
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
