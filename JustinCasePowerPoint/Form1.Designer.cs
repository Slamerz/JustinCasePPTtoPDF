﻿namespace JustinCasePowerPoint
{
    partial class Form1
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
            this.button_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_file_path = new System.Windows.Forms.Label();
            this.progressBar_Working = new System.Windows.Forms.ProgressBar();
            this.button_convert = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(406, 206);
            this.button_browse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(362, 134);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path:";
            // 
            // label_file_path
            // 
            this.label_file_path.AutoSize = true;
            this.label_file_path.Location = new System.Drawing.Point(339, 123);
            this.label_file_path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_file_path.Name = "label_file_path";
            this.label_file_path.Size = new System.Drawing.Size(39, 20);
            this.label_file_path.TabIndex = 2;
            this.label_file_path.Text = "Text";
            // 
            // progressBar_Working
            // 
            this.progressBar_Working.Location = new System.Drawing.Point(328, 437);
            this.progressBar_Working.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar_Working.Name = "progressBar_Working";
            this.progressBar_Working.Size = new System.Drawing.Size(513, 35);
            this.progressBar_Working.TabIndex = 3;
            this.progressBar_Working.Visible = false;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(477, 506);
            this.button_convert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(202, 63);
            this.button_convert.TabIndex = 4;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.progressBar_Working);
            this.Controls.Add(this.label_file_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_browse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_file_path;
        private System.Windows.Forms.ProgressBar progressBar_Working;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

