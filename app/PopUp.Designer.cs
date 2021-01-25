
namespace app
{
    partial class PopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.ignore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yes
            // 
            this.yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yes.FlatAppearance.BorderSize = 0;
            this.yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes.Font = new System.Drawing.Font("Questrial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.Color.White;
            this.yes.Image = ((System.Drawing.Image)(resources.GetObject("yes.Image")));
            this.yes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.yes.Location = new System.Drawing.Point(8, 78);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(99, 43);
            this.yes.TabIndex = 0;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.DialogResult = System.Windows.Forms.DialogResult.No;
            this.no.FlatAppearance.BorderSize = 0;
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no.Font = new System.Drawing.Font("Questrial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.Color.White;
            this.no.Image = ((System.Drawing.Image)(resources.GetObject("no.Image")));
            this.no.Location = new System.Drawing.Point(114, 78);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(99, 43);
            this.no.TabIndex = 1;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            // 
            // ignore
            // 
            this.ignore.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.ignore.FlatAppearance.BorderSize = 0;
            this.ignore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ignore.Font = new System.Drawing.Font("Questrial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignore.ForeColor = System.Drawing.Color.White;
            this.ignore.Image = ((System.Drawing.Image)(resources.GetObject("ignore.Image")));
            this.ignore.Location = new System.Drawing.Point(219, 78);
            this.ignore.Name = "ignore";
            this.ignore.Size = new System.Drawing.Size(99, 43);
            this.ignore.TabIndex = 2;
            this.ignore.Text = "Ignore";
            this.ignore.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Questrial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Finish Task?";
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ignore);
            this.Controls.Add(this.no);
            this.Font = new System.Drawing.Font("Questrial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopUp_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Button ignore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}