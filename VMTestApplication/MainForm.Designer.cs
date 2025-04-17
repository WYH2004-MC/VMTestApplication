using System.Windows.Forms;

namespace VMTestApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageResult = new System.Windows.Forms.GroupBox();
            this.processBox = new System.Windows.Forms.GroupBox();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.solutionLoadButton = new System.Windows.Forms.Button();
            this.solutionSelectButton = new System.Windows.Forms.Button();
            this.solutionFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vmProcedureConfigControl1 = new VMControls.Winform.Release.VmProcedureConfigControl();
            this.processBox.SuspendLayout();
            this.controlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageResult
            // 
            this.imageResult.Location = new System.Drawing.Point(611, 11);
            this.imageResult.Margin = new System.Windows.Forms.Padding(2);
            this.imageResult.Name = "imageResult";
            this.imageResult.Padding = new System.Windows.Forms.Padding(2);
            this.imageResult.Size = new System.Drawing.Size(445, 341);
            this.imageResult.TabIndex = 0;
            this.imageResult.TabStop = false;
            this.imageResult.Text = "结果显示";
            // 
            // processBox
            // 
            this.processBox.Controls.Add(this.vmProcedureConfigControl1);
            this.processBox.Location = new System.Drawing.Point(9, 11);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(597, 585);
            this.processBox.TabIndex = 1;
            this.processBox.TabStop = false;
            this.processBox.Text = "流程";
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.solutionLoadButton);
            this.controlBox.Controls.Add(this.solutionSelectButton);
            this.controlBox.Controls.Add(this.solutionFilePathTextBox);
            this.controlBox.Controls.Add(this.label1);
            this.controlBox.Location = new System.Drawing.Point(611, 357);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(445, 239);
            this.controlBox.TabIndex = 2;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "控制台";
            // 
            // solutionLoadButton
            // 
            this.solutionLoadButton.Location = new System.Drawing.Point(397, 24);
            this.solutionLoadButton.Name = "solutionLoadButton";
            this.solutionLoadButton.Size = new System.Drawing.Size(39, 21);
            this.solutionLoadButton.TabIndex = 3;
            this.solutionLoadButton.Text = "Load";
            this.solutionLoadButton.UseVisualStyleBackColor = true;
            this.solutionLoadButton.Click += new System.EventHandler(this.solutionLoadButton_Click);
            // 
            // solutionSelectButton
            // 
            this.solutionSelectButton.Location = new System.Drawing.Point(355, 23);
            this.solutionSelectButton.Name = "solutionSelectButton";
            this.solutionSelectButton.Size = new System.Drawing.Size(36, 22);
            this.solutionSelectButton.TabIndex = 2;
            this.solutionSelectButton.Text = "...";
            this.solutionSelectButton.UseVisualStyleBackColor = true;
            this.solutionSelectButton.Click += new System.EventHandler(this.solutionSelectButton_Click);
            // 
            // solutionFilePathTextBox
            // 
            this.solutionFilePathTextBox.Location = new System.Drawing.Point(62, 23);
            this.solutionFilePathTextBox.Name = "solutionFilePathTextBox";
            this.solutionFilePathTextBox.Size = new System.Drawing.Size(297, 21);
            this.solutionFilePathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "方案路径";
            // 
            // vmProcedureConfigControl1
            // 
            this.vmProcedureConfigControl1.Dock = DockStyle.Fill;
            this.vmProcedureConfigControl1.Location = new System.Drawing.Point(6, 20);
            this.vmProcedureConfigControl1.Name = "vmProcedureConfigControl1";
            this.vmProcedureConfigControl1.Size = new System.Drawing.Size(597, 585);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 610);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.processBox);
            this.Controls.Add(this.imageResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.processBox.ResumeLayout(false);
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private VMControls.Winform.Release.VmProcedureConfigControl vmProcedureConfigControl1;

        private System.Windows.Forms.Button solutionSelectButton;

        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.TextBox solutionFilePathTextBox;
        
        private System.Windows.Forms.Button solutionLoadButton;

        private System.Windows.Forms.GroupBox controlBox;

        private System.Windows.Forms.GroupBox processBox;

        private System.Windows.Forms.GroupBox imageResult;

        #endregion
    }
}