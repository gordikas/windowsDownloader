
namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {           
            this.download = new System.Windows.Forms.Button();
            this.install = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.regedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(12, 12);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(107, 23);
            this.download.TabIndex = 0;
            this.download.Text = "Скачать";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(12, 41);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(107, 23);
            this.install.TabIndex = 1;
            this.install.Text = "Установить";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(12, 70);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(107, 26);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить остатки";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // regedit
            // 
            this.regedit.Location = new System.Drawing.Point(12, 117);
            this.regedit.Name = "regedit";
            this.regedit.Size = new System.Drawing.Size(107, 23);
            this.regedit.TabIndex = 3;
            this.regedit.Text = "regedit";
            this.regedit.UseVisualStyleBackColor = true;
            this.regedit.Click += new System.EventHandler(this.regedit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 152);
            this.Controls.Add(this.regedit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.install);
            this.Controls.Add(this.download);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button regedit;
    }
}

