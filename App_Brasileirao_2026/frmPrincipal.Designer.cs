namespace App_Brasileirao_2026
{
    partial class frmPrincipal
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
            pnlPrincipal = new Panel();
            btnAtualizar = new Button();
            btnConsultar = new Button();
            pnlTelaPrincipal = new PictureBox();
            lblTituloPrincipalTopo = new Label();
            lblTituloInferior = new Label();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlTelaPrincipal).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.DarkBlue;
            pnlPrincipal.Controls.Add(btnAtualizar);
            pnlPrincipal.Controls.Add(btnConsultar);
            pnlPrincipal.Location = new Point(0, -3);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(209, 585);
            pnlPrincipal.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Yellow;
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatStyle = FlatStyle.Popup;
            btnAtualizar.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.DarkBlue;
            btnAtualizar.Location = new Point(45, 300);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(110, 52);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Yellow;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.DarkBlue;
            btnConsultar.Location = new Point(45, 217);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(110, 52);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // pnlTelaPrincipal
            // 
            pnlTelaPrincipal.Image = Properties.Resources.bandeiraBrasil;
            pnlTelaPrincipal.Location = new Point(209, 79);
            pnlTelaPrincipal.Name = "pnlTelaPrincipal";
            pnlTelaPrincipal.Size = new Size(741, 455);
            pnlTelaPrincipal.TabIndex = 1;
            pnlTelaPrincipal.TabStop = false;
            // 
            // lblTituloPrincipalTopo
            // 
            lblTituloPrincipalTopo.AutoSize = true;
            lblTituloPrincipalTopo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipalTopo.ForeColor = Color.DarkBlue;
            lblTituloPrincipalTopo.Location = new Point(388, 2);
            lblTituloPrincipalTopo.Name = "lblTituloPrincipalTopo";
            lblTituloPrincipalTopo.Size = new Size(369, 74);
            lblTituloPrincipalTopo.TabIndex = 2;
            lblTituloPrincipalTopo.Text = "Sistema de controle de\r\ntimes";
            lblTituloPrincipalTopo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloInferior
            // 
            lblTituloInferior.AutoSize = true;
            lblTituloInferior.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloInferior.ForeColor = Color.DarkBlue;
            lblTituloInferior.Location = new Point(452, 536);
            lblTituloInferior.Name = "lblTituloInferior";
            lblTituloInferior.Size = new Size(227, 37);
            lblTituloInferior.TabIndex = 3;
            lblTituloInferior.Text = "Tela Principal";
            lblTituloInferior.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 582);
            Controls.Add(lblTituloInferior);
            Controls.Add(lblTituloPrincipalTopo);
            Controls.Add(pnlTelaPrincipal);
            Controls.Add(pnlPrincipal);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Controle de Times -  Tela principal";
            FormClosed += frmPrincipal_FormClosed;
            pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlTelaPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPrincipal;
        private PictureBox pnlTelaPrincipal;
        private Button btnAtualizar;
        private Button btnConsultar;
        private Label lblTituloPrincipalTopo;
        private Label lblTituloInferior;
    }
}