
namespace app
{
    partial class APIFunction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.loginBar = new System.Windows.Forms.ProgressBar();
            this.printProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Updating Reqs...";
            // 
            // loginBar
            // 
            this.loginBar.Location = new System.Drawing.Point(97, 263);
            this.loginBar.Name = "loginBar";
            this.loginBar.Size = new System.Drawing.Size(194, 41);
            this.loginBar.TabIndex = 1;
            // 
            // printProgress
            // 
            this.printProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printProgress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printProgress.Location = new System.Drawing.Point(0, 307);
            this.printProgress.Name = "printProgress";
            this.printProgress.Size = new System.Drawing.Size(388, 27);
            this.printProgress.TabIndex = 2;
            this.printProgress.Text = ".......";
            this.printProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // APIFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printProgress);
            this.Controls.Add(this.loginBar);
            this.Controls.Add(this.label1);
            this.Name = "APIFunction";
            this.Size = new System.Drawing.Size(388, 562);
            this.Load += new System.EventHandler(this.APIFunction_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar loginBar;
        private System.Windows.Forms.Label printProgress;
    }
}
