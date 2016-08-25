namespace autoProject.formClases
{
    partial class FormRegistration
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
            this.lbNameRegistr = new System.Windows.Forms.Label();
            this.tbNameRegistr = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassvord = new System.Windows.Forms.TextBox();
            this.btSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNameRegistr
            // 
            this.lbNameRegistr.AutoSize = true;
            this.lbNameRegistr.Location = new System.Drawing.Point(12, 21);
            this.lbNameRegistr.Name = "lbNameRegistr";
            this.lbNameRegistr.Size = new System.Drawing.Size(38, 13);
            this.lbNameRegistr.TabIndex = 0;
            this.lbNameRegistr.Text = "Name:";
            // 
            // tbNameRegistr
            // 
            this.tbNameRegistr.Location = new System.Drawing.Point(52, 53);
            this.tbNameRegistr.Name = "tbNameRegistr";
            this.tbNameRegistr.Size = new System.Drawing.Size(162, 20);
            this.tbNameRegistr.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 95);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password:";
            // 
            // tbPassvord
            // 
            this.tbPassvord.Location = new System.Drawing.Point(52, 136);
            this.tbPassvord.MaxLength = 8;
            this.tbPassvord.Name = "tbPassvord";
            this.tbPassvord.Size = new System.Drawing.Size(162, 20);
            this.tbPassvord.TabIndex = 3;
            // 
            // btSignIn
            // 
            this.btSignIn.Location = new System.Drawing.Point(97, 183);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(75, 23);
            this.btSignIn.TabIndex = 4;
            this.btSignIn.Text = "Sign in";
            this.btSignIn.UseVisualStyleBackColor = true;
            // 
            // FormRegistration
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 230);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.tbPassvord);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbNameRegistr);
            this.Controls.Add(this.lbNameRegistr);
            this.Name = "FormRegistration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameRegistr;
        private System.Windows.Forms.TextBox tbNameRegistr;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassvord;
        private System.Windows.Forms.Button btSignIn;
    }
}