namespace Cinema_booking_system
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtLogInUserName = new System.Windows.Forms.TextBox();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.checkUser = new System.Windows.Forms.CheckBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(186, 152);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(119, 25);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(186, 224);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(106, 25);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // txtLogInUserName
            // 
            this.txtLogInUserName.Location = new System.Drawing.Point(342, 152);
            this.txtLogInUserName.Name = "txtLogInUserName";
            this.txtLogInUserName.Size = new System.Drawing.Size(199, 20);
            this.txtLogInUserName.TabIndex = 3;
            this.txtLogInUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogInUserName_KeyPress);
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Location = new System.Drawing.Point(342, 230);
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.Size = new System.Drawing.Size(201, 20);
            this.txtLogInPassword.TabIndex = 4;
            this.txtLogInPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(612, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(176, 43);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAdmin.Location = new System.Drawing.Point(343, 304);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(91, 29);
            this.checkAdmin.TabIndex = 6;
            this.checkAdmin.Text = "Admin";
            this.checkAdmin.UseVisualStyleBackColor = false;
            // 
            // checkUser
            // 
            this.checkUser.AutoSize = true;
            this.checkUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUser.Location = new System.Drawing.Point(342, 350);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(76, 29);
            this.checkUser.TabIndex = 7;
            this.checkUser.Text = "User";
            this.checkUser.UseVisualStyleBackColor = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(606, 381);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(182, 46);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Location = new System.Drawing.Point(558, 230);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(47, 20);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Cinema_booking_system.Properties.Resources.pnglot_com_movie_strip_png_746632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.checkUser);
            this.Controls.Add(this.checkAdmin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtLogInPassword);
            this.Controls.Add(this.txtLogInUserName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "Form1";
            this.Text = "Welcom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtLogInUserName;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox checkAdmin;
        private System.Windows.Forms.CheckBox checkUser;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnShow;
    }
}

