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
            this.SuspendLayout();
            // 
            // imageResult
            // 
            this.imageResult.Location = new System.Drawing.Point(8, 15);
            this.imageResult.Name = "imageResult";
            this.imageResult.Size = new System.Drawing.Size(725, 511);
            this.imageResult.TabIndex = 0;
            this.imageResult.TabStop = false;
            this.imageResult.Text = "结果显示";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 915);
            this.Controls.Add(this.imageResult);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox imageResult;

        #endregion
    }
}