using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog.Targets;
using VM.Core;
using VM.PlatformSDKCS;
using VMControls.Winform.Release;

namespace VMTestApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void solutionSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "VM Solution Files (*.sol)|*.sol";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                solutionFilePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void solutionLoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                VmSolution.Load(solutionFilePathTextBox.Text);
                MessageBox.Show("OK");
            }
            catch (VmException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VmProcedure vmProcedure = (VmProcedure)VmSolution.Instance["Cam1检测"];
            vmRenderControl1.ModuleSource = vmProcedure;
            
            vmProcedure.SyncRun();
            if(vmRenderControl1.ImageSource != null)
            {
                vmRenderControl1.SaveOriginalImage("D:\\Test.bmp");
            }
        }
    }
}