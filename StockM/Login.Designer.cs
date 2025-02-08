namespace LaBaratosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Ptransp = new Panel();
            Show = new CheckBox();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnAcceder = new Button();
            txtUser = new TextBox();
            txtMinimizar = new PictureBox();
            txtCerrar = new PictureBox();
            Ptransp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCerrar).BeginInit();
            SuspendLayout();
            // 
            // Ptransp
            // 
            Ptransp.BackColor = Color.White;
            Ptransp.Controls.Add(Show);
            Ptransp.Controls.Add(pictureBox3);
            Ptransp.Controls.Add(txtPassword);
            Ptransp.Controls.Add(pictureBox2);
            Ptransp.Controls.Add(pictureBox1);
            Ptransp.Controls.Add(label2);
            Ptransp.Controls.Add(label1);
            Ptransp.Controls.Add(btnAcceder);
            Ptransp.Controls.Add(txtUser);
            Ptransp.Location = new Point(259, 41);
            Ptransp.Margin = new Padding(4, 5, 4, 5);
            Ptransp.Name = "Ptransp";
            Ptransp.Size = new Size(609, 625);
            Ptransp.TabIndex = 0;
            Ptransp.Paint += Ptransp_Paint;
            // 
            // Show
            // 
            Show.AutoSize = true;
            Show.BackColor = Color.Transparent;
            Show.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Show.Location = new Point(339, 504);
            Show.Margin = new Padding(4, 5, 4, 5);
            Show.Name = "Show";
            Show.Size = new Size(247, 33);
            Show.TabIndex = 14;
            Show.Text = "Mostrar Contraseña";
            Show.UseVisualStyleBackColor = false;
            Show.CheckedChanged += Show_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(191, 6);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(226, 234);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century", 14.05F);
            txtPassword.Location = new Point(104, 443);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(425, 41);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(64, 443);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 292);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 405);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 33);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 255);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 33);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.Transparent;
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 132, 34);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 113, 0);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(161, 538);
            btnAcceder.Margin = new Padding(4, 5, 4, 5);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(278, 70);
            btnAcceder.TabIndex = 1;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(104, 292);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(425, 36);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtMinimizar
            // 
            txtMinimizar.BackColor = Color.Transparent;
            txtMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            txtMinimizar.Cursor = Cursors.Hand;
            txtMinimizar.Image = (Image)resources.GetObject("txtMinimizar.Image");
            txtMinimizar.Location = new Point(1056, 4);
            txtMinimizar.Margin = new Padding(4, 5, 4, 5);
            txtMinimizar.Name = "txtMinimizar";
            txtMinimizar.Size = new Size(28, 31);
            txtMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            txtMinimizar.TabIndex = 7;
            txtMinimizar.TabStop = false;
            txtMinimizar.Click += txtMinimizar_Click;
            // 
            // txtCerrar
            // 
            txtCerrar.BackColor = Color.Transparent;
            txtCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            txtCerrar.Cursor = Cursors.Hand;
            txtCerrar.Image = (Image)resources.GetObject("txtCerrar.Image");
            txtCerrar.Location = new Point(1096, 4);
            txtCerrar.Margin = new Padding(4, 5, 4, 5);
            txtCerrar.Name = "txtCerrar";
            txtCerrar.Size = new Size(26, 30);
            txtCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            txtCerrar.TabIndex = 8;
            txtCerrar.TabStop = false;
            txtCerrar.Click += txtCerrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1142, 750);
            Controls.Add(txtCerrar);
            Controls.Add(txtMinimizar);
            Controls.Add(Ptransp);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            Ptransp.ResumeLayout(false);
            Ptransp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Ptransp;
        private Button btnAcceder;
        private TextBox txtUser;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox txtMinimizar;
        private PictureBox txtCerrar;
        private PictureBox pictureBox3;
        private CheckBox Show;
    }
}
