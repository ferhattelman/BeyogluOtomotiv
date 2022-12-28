namespace BeyogluOtomotiv
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_lgn = new System.Windows.Forms.Button();
            this.frgt_pass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_username.Location = new System.Drawing.Point(174, 282);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(208, 28);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "UserName";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_pass.Location = new System.Drawing.Point(174, 335);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(208, 28);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Text = "Password";
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_lgn
            // 
            this.btn_lgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_lgn.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_lgn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_lgn.Location = new System.Drawing.Point(174, 381);
            this.btn_lgn.Name = "btn_lgn";
            this.btn_lgn.Size = new System.Drawing.Size(208, 36);
            this.btn_lgn.TabIndex = 2;
            this.btn_lgn.Text = "LOGIN";
            this.btn_lgn.UseVisualStyleBackColor = false;
            this.btn_lgn.Click += new System.EventHandler(this.btn_lgn_Click);
            // 
            // frgt_pass
            // 
            this.frgt_pass.AutoSize = true;
            this.frgt_pass.BackColor = System.Drawing.SystemColors.Control;
            this.frgt_pass.LinkColor = System.Drawing.Color.Red;
            this.frgt_pass.Location = new System.Drawing.Point(212, 433);
            this.frgt_pass.Name = "frgt_pass";
            this.frgt_pass.Size = new System.Drawing.Size(129, 20);
            this.frgt_pass.TabIndex = 3;
            this.frgt_pass.TabStop = true;
            this.frgt_pass.Text = "Forgot Password ?";
            this.frgt_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.frgt_pass_LinkClicked_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.frgt_pass);
            this.Controls.Add(this.btn_lgn);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        public TextBox txt_username;
        private TextBox txt_pass;
        private Button btn_lgn;
        private LinkLabel frgt_pass;
    }
}