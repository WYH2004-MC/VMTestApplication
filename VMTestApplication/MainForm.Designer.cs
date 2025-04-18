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
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.processBox = new System.Windows.Forms.GroupBox();
            this.vmProcedureConfigControl1 = new VMControls.Winform.Release.VmProcedureConfigControl();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.solutionLoadButton = new System.Windows.Forms.Button();
            this.solutionSelectButton = new System.Windows.Forms.Button();
            this.solutionFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logViewBox = new System.Windows.Forms.GroupBox();
            this.logView = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logStr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageResult.SuspendLayout();
            this.processBox.SuspendLayout();
            this.controlBox.SuspendLayout();
            this.logViewBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageResult
            // 
            this.imageResult.Controls.Add(this.vmRenderControl1);
            this.imageResult.Location = new System.Drawing.Point(611, 11);
            this.imageResult.Margin = new System.Windows.Forms.Padding(2);
            this.imageResult.Name = "imageResult";
            this.imageResult.Padding = new System.Windows.Forms.Padding(2);
            this.imageResult.Size = new System.Drawing.Size(524, 341);
            this.imageResult.TabIndex = 0;
            this.imageResult.TabStop = false;
            this.imageResult.Text = "结果显示";
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(2, 16);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(520, 323);
            this.vmRenderControl1.TabIndex = 0;
            // 
            // processBox
            // 
            this.processBox.Controls.Add(this.vmProcedureConfigControl1);
            this.processBox.Location = new System.Drawing.Point(9, 11);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(597, 887);
            this.processBox.TabIndex = 1;
            this.processBox.TabStop = false;
            this.processBox.Text = "流程";
            // 
            // vmProcedureConfigControl1
            // 
            this.vmProcedureConfigControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vmProcedureConfigControl1.Location = new System.Drawing.Point(3, 17);
            this.vmProcedureConfigControl1.Margin = new System.Windows.Forms.Padding(2);
            this.vmProcedureConfigControl1.Name = "vmProcedureConfigControl1";
            this.vmProcedureConfigControl1.Size = new System.Drawing.Size(591, 867);
            this.vmProcedureConfigControl1.TabIndex = 0;
// TODO: “”的代码生成失败，原因是出现异常“无效的基元类型: System.IntPtr。请考虑使用 CodeObjectCreateExpression。”。
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.label2);
            this.controlBox.Controls.Add(this.button1);
            this.controlBox.Controls.Add(this.solutionLoadButton);
            this.controlBox.Controls.Add(this.solutionSelectButton);
            this.controlBox.Controls.Add(this.solutionFilePathTextBox);
            this.controlBox.Controls.Add(this.label1);
            this.controlBox.Location = new System.Drawing.Point(611, 357);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(522, 236);
            this.controlBox.TabIndex = 2;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "控制台";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "方案执行";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // solutionLoadButton
            // 
            this.solutionLoadButton.Location = new System.Drawing.Point(467, 22);
            this.solutionLoadButton.Name = "solutionLoadButton";
            this.solutionLoadButton.Size = new System.Drawing.Size(39, 22);
            this.solutionLoadButton.TabIndex = 3;
            this.solutionLoadButton.Text = "Load";
            this.solutionLoadButton.UseVisualStyleBackColor = true;
            this.solutionLoadButton.Click += new System.EventHandler(this.solutionLoadButton_Click);
            // 
            // solutionSelectButton
            // 
            this.solutionSelectButton.Location = new System.Drawing.Point(402, 22);
            this.solutionSelectButton.Name = "solutionSelectButton";
            this.solutionSelectButton.Size = new System.Drawing.Size(59, 22);
            this.solutionSelectButton.TabIndex = 2;
            this.solutionSelectButton.Text = "预览...";
            this.solutionSelectButton.UseVisualStyleBackColor = true;
            this.solutionSelectButton.Click += new System.EventHandler(this.solutionSelectButton_Click);
            // 
            // solutionFilePathTextBox
            // 
            this.solutionFilePathTextBox.Location = new System.Drawing.Point(62, 22);
            this.solutionFilePathTextBox.Name = "solutionFilePathTextBox";
            this.solutionFilePathTextBox.Size = new System.Drawing.Size(334, 21);
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
            // logViewBox
            // 
            this.logViewBox.Controls.Add(this.logView);
            this.logViewBox.Location = new System.Drawing.Point(611, 602);
            this.logViewBox.Name = "logViewBox";
            this.logViewBox.Size = new System.Drawing.Size(522, 299);
            this.logViewBox.TabIndex = 3;
            this.logViewBox.TabStop = false;
            this.logViewBox.Text = "运行日志";
            // 
            // logView
            // 
            this.logView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Type,
            this.logStr});
            this.logView.Cursor = System.Windows.Forms.Cursors.Default;
            this.logView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView.HideSelection = false;
            this.logView.Location = new System.Drawing.Point(3, 17);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(516, 279);
            this.logView.TabIndex = 0;
            this.logView.UseCompatibleStateImageBehavior = false;
            this.logView.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "时间";
            this.Time.Width = 120;
            // 
            // Type
            // 
            this.Type.Text = "类型";
            this.Type.Width = 59;
            // 
            // logStr
            // 
            this.logStr.Text = "内容";
            this.logStr.Width = 400;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 913);
            this.Controls.Add(this.logViewBox);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.processBox);
            this.Controls.Add(this.imageResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.imageResult.ResumeLayout(false);
            this.processBox.ResumeLayout(false);
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            this.logViewBox.ResumeLayout(false);
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

        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private GroupBox logViewBox;
        private ListView logView;
        private ColumnHeader Time;
        private ColumnHeader Type;
        private ColumnHeader logStr;
        private Label label2;
        private Button button1;
    }
}