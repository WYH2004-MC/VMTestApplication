using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}