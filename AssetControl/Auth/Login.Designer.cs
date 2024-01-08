namespace AssetControl
{
    partial class Login
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
            labelUsuario = new Label();
            labelPassword = new Label();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            bnLogin = new Button();
            bnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(125, 15);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(47, 15);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(105, 44);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(67, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Contraseña";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(178, 12);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(136, 23);
            textBoxUser.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(178, 41);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(136, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // bnLogin
            // 
            bnLogin.Location = new Point(98, 70);
            bnLogin.Name = "bnLogin";
            bnLogin.Size = new Size(105, 23);
            bnLogin.TabIndex = 4;
            bnLogin.Text = "Iniciar Sesión";
            bnLogin.UseVisualStyleBackColor = true;
            bnLogin.Click += bnLogin_Click;
            // 
            // bnCancelar
            // 
            bnCancelar.Location = new Point(209, 70);
            bnCancelar.Name = "bnCancelar";
            bnCancelar.Size = new Size(105, 23);
            bnCancelar.TabIndex = 5;
            bnCancelar.Text = "Cancelar";
            bnCancelar.UseVisualStyleBackColor = true;
            bnCancelar.Click += bnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.customer_32x32;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 106);
            Controls.Add(pictureBox1);
            Controls.Add(bnCancelar);
            Controls.Add(bnLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(labelPassword);
            Controls.Add(labelUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private Label labelPassword;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Button bnLogin;
        private Button bnCancelar;
        private PictureBox pictureBox1;
    }
}
