
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIFunction));
            this.label1 = new System.Windows.Forms.Label();
            this.loginBar = new System.Windows.Forms.ProgressBar();
            this.printProgress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Updating Reqs...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginBar
            // 
            this.loginBar.Location = new System.Drawing.Point(116, 351);
            this.loginBar.Margin = new System.Windows.Forms.Padding(4);
            this.loginBar.Name = "loginBar";
            this.loginBar.Size = new System.Drawing.Size(275, 50);
            this.loginBar.TabIndex = 1;
            // 
            // printProgress
            // 
            this.printProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printProgress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printProgress.Location = new System.Drawing.Point(0, 412);
            this.printProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printProgress.Name = "printProgress";
            this.printProgress.Size = new System.Drawing.Size(517, 33);
            this.printProgress.TabIndex = 2;
            this.printProgress.Text = ".......";
            this.printProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // APIFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.printProgress);
            this.Controls.Add(this.loginBar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "APIFunction";
            this.Size = new System.Drawing.Size(517, 692);
            this.Load += new System.EventHandler(this.APIFunction_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar loginBar;
        private System.Windows.Forms.Label printProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
