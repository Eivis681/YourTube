namespace YourTube
{
    partial class EditKey
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
            this.BackBu = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackBu
            // 
            this.BackBu.Location = new System.Drawing.Point(13, 39);
            this.BackBu.Name = "BackBu";
            this.BackBu.Size = new System.Drawing.Size(99, 23);
            this.BackBu.TabIndex = 4;
            this.BackBu.Text = "<- Back";
            this.BackBu.UseVisualStyleBackColor = true;
            this.BackBu.Click += new System.EventHandler(this.BackBu_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(130, 39);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(13, 13);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(348, 20);
            this.textBoxKey.TabIndex = 6;
            // 
            // EditKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 70);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BackBu);
            this.Name = "EditKey";
            this.Text = "EditKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBu;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}