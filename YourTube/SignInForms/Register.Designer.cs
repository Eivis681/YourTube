namespace YourTube
{
    partial class Register
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
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.repeatPasswordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwrodText = new System.Windows.Forms.TextBox();
            this.BackBu = new System.Windows.Forms.Button();
            this.Us = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.apiKeyText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(148, 182);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 23);
            this.Save.TabIndex = 18;
            this.Save.Text = "Register";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Repeat password:";
            // 
            // repeatPasswordText
            // 
            this.repeatPasswordText.Location = new System.Drawing.Point(12, 114);
            this.repeatPasswordText.Name = "repeatPasswordText";
            this.repeatPasswordText.Size = new System.Drawing.Size(235, 20);
            this.repeatPasswordText.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            // 
            // passwrodText
            // 
            this.passwrodText.Location = new System.Drawing.Point(12, 69);
            this.passwrodText.Name = "passwrodText";
            this.passwrodText.Size = new System.Drawing.Size(235, 20);
            this.passwrodText.TabIndex = 14;
            // 
            // BackBu
            // 
            this.BackBu.Location = new System.Drawing.Point(12, 182);
            this.BackBu.Name = "BackBu";
            this.BackBu.Size = new System.Drawing.Size(99, 23);
            this.BackBu.TabIndex = 13;
            this.BackBu.Text = "<- Back";
            this.BackBu.UseVisualStyleBackColor = true;
            this.BackBu.Click += new System.EventHandler(this.BackBu_Click);
            // 
            // Us
            // 
            this.Us.AutoSize = true;
            this.Us.Location = new System.Drawing.Point(9, 11);
            this.Us.Name = "Us";
            this.Us.Size = new System.Drawing.Size(58, 13);
            this.Us.TabIndex = 12;
            this.Us.Text = "Username:";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(12, 27);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(235, 20);
            this.usernameText.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Api key:";
            // 
            // apiKeyText
            // 
            this.apiKeyText.Location = new System.Drawing.Point(12, 156);
            this.apiKeyText.Name = "apiKeyText";
            this.apiKeyText.Size = new System.Drawing.Size(235, 20);
            this.apiKeyText.TabIndex = 19;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apiKeyText);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repeatPasswordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwrodText);
            this.Controls.Add(this.BackBu);
            this.Controls.Add(this.Us);
            this.Controls.Add(this.usernameText);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repeatPasswordText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwrodText;
        private System.Windows.Forms.Button BackBu;
        private System.Windows.Forms.Label Us;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apiKeyText;
    }
}