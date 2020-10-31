namespace YourTube
{
    partial class ChangePassword
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
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(12, 23);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(235, 20);
            this.oldPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old password:";
            // 
            // BackBu
            // 
            this.BackBu.Location = new System.Drawing.Point(12, 136);
            this.BackBu.Name = "BackBu";
            this.BackBu.Size = new System.Drawing.Size(99, 23);
            this.BackBu.TabIndex = 5;
            this.BackBu.Text = "<- Back";
            this.BackBu.UseVisualStyleBackColor = true;
            this.BackBu.Click += new System.EventHandler(this.BackBu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "New password:";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(12, 65);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(235, 20);
            this.newPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Repeat new password:";
            // 
            // repeatPassword
            // 
            this.repeatPassword.Location = new System.Drawing.Point(12, 110);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.Size = new System.Drawing.Size(235, 20);
            this.repeatPassword.TabIndex = 8;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(148, 136);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 172);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repeatPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.BackBu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repeatPassword;
        private System.Windows.Forms.Button Save;
    }
}