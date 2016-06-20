namespace FrameExtactor
{
    partial class MainFrom
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
            this.label3 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetFrames = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.tboutdir = new System.Windows.Forms.TextBox();
            this.tbVideo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Loading Frames... ";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(140, 110);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(293, 163);
            this.picBox.TabIndex = 16;
            this.picBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select video";
            // 
            // btnGetFrames
            // 
            this.btnGetFrames.Location = new System.Drawing.Point(450, 110);
            this.btnGetFrames.Name = "btnGetFrames";
            this.btnGetFrames.Size = new System.Drawing.Size(75, 23);
            this.btnGetFrames.TabIndex = 13;
            this.btnGetFrames.Text = "Get Frames";
            this.btnGetFrames.UseVisualStyleBackColor = true;
            this.btnGetFrames.Click += new System.EventHandler(this.btnGetFrames_Click);
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(450, 65);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 23);
            this.btnDir.TabIndex = 12;
            this.btnDir.Text = "browse";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(450, 25);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 23);
            this.btnVideo.TabIndex = 11;
            this.btnVideo.Text = "browse";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // tboutdir
            // 
            this.tboutdir.Location = new System.Drawing.Point(140, 68);
            this.tboutdir.Name = "tboutdir";
            this.tboutdir.Size = new System.Drawing.Size(293, 20);
            this.tboutdir.TabIndex = 10;
            // 
            // tbVideo
            // 
            this.tbVideo.Location = new System.Drawing.Point(140, 27);
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(293, 20);
            this.tbVideo.TabIndex = 9;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetFrames);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.tboutdir);
            this.Controls.Add(this.tbVideo);
            this.Name = "MainFrom";
            this.Text = "Main From";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetFrames;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.TextBox tboutdir;
        private System.Windows.Forms.TextBox tbVideo;
    }
}

