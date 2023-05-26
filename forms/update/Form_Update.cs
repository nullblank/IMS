using IMS.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.forms.update
{
    public partial class Form_Update : Form
    {
        UpdateHandler update;
        public Form_Update()
        {
            InitializeComponent();
            ControlBox = false;
            update = new UpdateHandler(progressBar, this, lblAction, lblVAction);
            init();
            
        }
        private void init()
        {
            update.CheckForUpdates();
        }
    }
}
