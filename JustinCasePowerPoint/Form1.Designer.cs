namespace JustinCasePowerPoint
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
            this.button_browse.Location = new System.Drawing.Point(271, 134);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(241, 87);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path:";
            // 
            // label_file_path
            // 
            this.label_file_path.AutoSize = true;
            this.label_file_path.Location = new System.Drawing.Point(228, 80);
            this.label_file_path.Name = "label_file_path";
            this.label_file_path.Size = new System.Drawing.Size(0, 13);
            this.label_file_path.TabIndex = 2;
            // 
            // progressBar_Working
            // 
            this.progressBar_Working.Location = new System.Drawing.Point(219, 284);
            this.progressBar_Working.Name = "progressBar_Working";
            this.progressBar_Working.Size = new System.Drawing.Size(342, 23);
            this.progressBar_Working.TabIndex = 3;
            this.progressBar_Working.Visible = false;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(318, 329);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(135, 41);
            this.button_convert.TabIndex = 4;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.progressBar_Working);
            this.Controls.Add(this.label_file_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_browse);
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

