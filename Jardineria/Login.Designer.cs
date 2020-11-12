namespace Jardineria
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
            this.pctUser = new System.Windows.Forms.PictureBox();
            this.pctCorreo = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pctPassword = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pctUser
            // 
            this.pctUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pctUser.Image = global::Jardineria.Properties.Resources.user;
            this.pctUser.Location = new System.Drawing.Point(69, 12);
            this.pctUser.Name = "pctUser";
            this.pctUser.Size = new System.Drawing.Size(119, 103);
            this.pctUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUser.TabIndex = 2;
            this.pctUser.TabStop = false;
            // 
            // pctCorreo
            // 
            this.pctCorreo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pctCorreo.Image = global::Jardineria.Properties.Resources.correo;
            this.pctCorreo.Location = new System.Drawing.Point(17, 187);
            this.pctCorreo.Name = "pctCorreo";
            this.pctCorreo.Size = new System.Drawing.Size(46, 36);
            this.pctCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCorreo.TabIndex = 4;
            this.pctCorreo.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(14, 139);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new System.Windows.Forms.Padding(5);
            this.lblError.Size = new System.Drawing.Size(233, 23);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error! Contraseña o usuario incorrecto";
            this.lblError.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Location = new System.Drawing.Point(69, 187);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(191, 20);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pctPassword
            // 
            this.pctPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pctPassword.Image = global::Jardineria.Properties.Resources.password;
            this.pctPassword.Location = new System.Drawing.Point(17, 239);
            this.pctPassword.Name = "pctPassword";
            this.pctPassword.Size = new System.Drawing.Size(46, 42);
            this.pctPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPassword.TabIndex = 7;
            this.pctPassword.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(69, 239);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(191, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(17, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(280, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pctPassword);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pctCorreo);
            this.Controls.Add(this.pctUser);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctUser;
        private System.Windows.Forms.PictureBox pctCorreo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.PictureBox pctPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
    }
}