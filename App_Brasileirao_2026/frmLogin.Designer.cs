namespace App_Brasileirao_2026
{
    partial class frmLogin
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
            pnlLogin = new Panel();
            btnSair = new Button();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            lblTituloLogin = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.DarkBlue;
            pnlLogin.Controls.Add(btnSair);
            pnlLogin.Controls.Add(btnEntrar);
            pnlLogin.ForeColor = Color.DarkBlue;
            pnlLogin.Location = new Point(0, 336);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(801, 116);
            pnlLogin.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(577, 35);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(89, 42);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.ForestGreen;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.ImageAlign = ContentAlignment.MiddleRight;
            btnEntrar.Location = new Point(687, 35);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(89, 42);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlign = ContentAlignment.MiddleRight;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2026_06_17_200354;
            pictureBox1.Location = new Point(47, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLogin.ForeColor = Color.DarkBlue;
            lblTituloLogin.ImageAlign = ContentAlignment.MiddleRight;
            lblTituloLogin.Location = new Point(556, 106);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(220, 132);
            lblTituloLogin.TabIndex = 2;
            lblTituloLogin.Text = "Sistema de\r\ncontrole de\r\ntimes";
            lblTituloLogin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTituloLogin);
            Controls.Add(pictureBox1);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogin;
        private PictureBox pictureBox1;
        private Button btnSair;
        private Button btnEntrar;
        private Label lblTituloLogin;
    }
}
