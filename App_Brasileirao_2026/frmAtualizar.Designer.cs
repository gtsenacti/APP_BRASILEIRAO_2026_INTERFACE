namespace App_Brasileirao_2026
{
    partial class frmAtualizar
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
            dgvAtualizar = new DataGridView();
            pnlConsultar = new Panel();
            btnApagar = new Button();
            btnAtualizar = new Button();
            lblSeries = new Label();
            cbSeries = new ComboBox();
            lblTituloAlto = new Label();
            btnInserir = new Button();
            pbAtualizar = new PictureBox();
            pnlRodape = new Panel();
            rbPosicao = new RadioButton();
            rbBuscarNomeTime = new RadioButton();
            txtBuscar = new TextBox();
            lblNomeClube = new Label();
            txtNomeClube = new TextBox();
            txtPontosClube = new TextBox();
            lblPontosClube = new Label();
            txtJogosClube = new TextBox();
            lblJogosClube = new Label();
            txtSaldoGols = new TextBox();
            lblSaldoGols = new Label();
            txtVitoriasClube = new TextBox();
            lblVitoriasClube = new Label();
            txtDerrotasClube = new TextBox();
            lblDerrotasClube = new Label();
            txtEmpatesClube = new TextBox();
            lblEmpatesClube = new Label();
            txtPosicaoTabela = new TextBox();
            lblPosicaoTabela = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).BeginInit();
            pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAtualizar).BeginInit();
            pnlRodape.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAtualizar
            // 
            dgvAtualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtualizar.Location = new Point(236, 278);
            dgvAtualizar.Name = "dgvAtualizar";
            dgvAtualizar.Size = new Size(611, 257);
            dgvAtualizar.TabIndex = 5;
            // 
            // pnlConsultar
            // 
            pnlConsultar.BackColor = Color.DarkBlue;
            pnlConsultar.Controls.Add(btnApagar);
            pnlConsultar.Controls.Add(btnAtualizar);
            pnlConsultar.Controls.Add(lblSeries);
            pnlConsultar.Controls.Add(cbSeries);
            pnlConsultar.Controls.Add(lblTituloAlto);
            pnlConsultar.Controls.Add(btnInserir);
            pnlConsultar.Location = new Point(-1, -2);
            pnlConsultar.Name = "pnlConsultar";
            pnlConsultar.Size = new Size(209, 603);
            pnlConsultar.TabIndex = 4;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Red;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnApagar.ForeColor = Color.DarkBlue;
            btnApagar.Location = new Point(27, 393);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(152, 60);
            btnApagar.TabIndex = 6;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DeepSkyBlue;
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatStyle = FlatStyle.Popup;
            btnAtualizar.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.DarkBlue;
            btnAtualizar.Location = new Point(27, 317);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(152, 60);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // lblSeries
            // 
            lblSeries.AutoSize = true;
            lblSeries.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeries.ForeColor = Color.White;
            lblSeries.Location = new Point(27, 151);
            lblSeries.Name = "lblSeries";
            lblSeries.Size = new Size(65, 22);
            lblSeries.TabIndex = 4;
            lblSeries.Text = "Série:";
            // 
            // cbSeries
            // 
            cbSeries.BackColor = Color.LightGray;
            cbSeries.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSeries.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSeries.FormattingEnabled = true;
            cbSeries.Items.AddRange(new object[] { "", "A", "B", "C", "D", "E" });
            cbSeries.Location = new Point(27, 181);
            cbSeries.Name = "cbSeries";
            cbSeries.Size = new Size(152, 30);
            cbSeries.TabIndex = 3;
            // 
            // lblTituloAlto
            // 
            lblTituloAlto.AutoSize = true;
            lblTituloAlto.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAlto.ForeColor = Color.White;
            lblTituloAlto.Location = new Point(13, 32);
            lblTituloAlto.Name = "lblTituloAlto";
            lblTituloAlto.Size = new Size(185, 88);
            lblTituloAlto.TabIndex = 2;
            lblTituloAlto.Text = "Atualizar \r\ntimes";
            lblTituloAlto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.LawnGreen;
            btnInserir.Cursor = Cursors.Hand;
            btnInserir.FlatStyle = FlatStyle.Popup;
            btnInserir.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnInserir.ForeColor = Color.DarkBlue;
            btnInserir.Location = new Point(27, 240);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(152, 60);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // pbAtualizar
            // 
            pbAtualizar.Image = Properties.Resources.escudoCBF;
            pbAtualizar.Location = new Point(207, -2);
            pbAtualizar.Name = "pbAtualizar";
            pbAtualizar.Size = new Size(1026, 513);
            pbAtualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAtualizar.TabIndex = 6;
            pbAtualizar.TabStop = false;
            // 
            // pnlRodape
            // 
            pnlRodape.Controls.Add(rbPosicao);
            pnlRodape.Controls.Add(rbBuscarNomeTime);
            pnlRodape.Controls.Add(txtBuscar);
            pnlRodape.Location = new Point(207, 508);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(665, 93);
            pnlRodape.TabIndex = 7;
            // 
            // rbPosicao
            // 
            rbPosicao.AutoSize = true;
            rbPosicao.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPosicao.ForeColor = Color.DarkBlue;
            rbPosicao.Location = new Point(219, 42);
            rbPosicao.Name = "rbPosicao";
            rbPosicao.Size = new Size(103, 26);
            rbPosicao.TabIndex = 2;
            rbPosicao.TabStop = true;
            rbPosicao.Text = "Posição";
            rbPosicao.UseVisualStyleBackColor = true;
            // 
            // rbBuscarNomeTime
            // 
            rbBuscarNomeTime.AutoSize = true;
            rbBuscarNomeTime.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbBuscarNomeTime.ForeColor = Color.DarkBlue;
            rbBuscarNomeTime.Location = new Point(29, 43);
            rbBuscarNomeTime.Name = "rbBuscarNomeTime";
            rbBuscarNomeTime.Size = new Size(154, 26);
            rbBuscarNomeTime.TabIndex = 1;
            rbBuscarNomeTime.TabStop = true;
            rbBuscarNomeTime.Text = "Nome do time";
            rbBuscarNomeTime.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.LightGray;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(360, 42);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(280, 29);
            txtBuscar.TabIndex = 0;
            // 
            // lblNomeClube
            // 
            lblNomeClube.AutoSize = true;
            lblNomeClube.BackColor = Color.White;
            lblNomeClube.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblNomeClube.ForeColor = Color.DarkBlue;
            lblNomeClube.Location = new Point(236, 37);
            lblNomeClube.Name = "lblNomeClube";
            lblNomeClube.Size = new Size(158, 22);
            lblNomeClube.TabIndex = 8;
            lblNomeClube.Text = "Nome do Clube:";
            // 
            // txtNomeClube
            // 
            txtNomeClube.Font = new Font("Arial", 14.25F);
            txtNomeClube.Location = new Point(236, 59);
            txtNomeClube.Name = "txtNomeClube";
            txtNomeClube.Size = new Size(293, 29);
            txtNomeClube.TabIndex = 9;
            // 
            // txtPontosClube
            // 
            txtPontosClube.Font = new Font("Arial", 14.25F);
            txtPontosClube.Location = new Point(236, 119);
            txtPontosClube.Name = "txtPontosClube";
            txtPontosClube.Size = new Size(293, 29);
            txtPontosClube.TabIndex = 11;
            // 
            // lblPontosClube
            // 
            lblPontosClube.AutoSize = true;
            lblPontosClube.BackColor = Color.White;
            lblPontosClube.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblPontosClube.ForeColor = Color.DarkBlue;
            lblPontosClube.Location = new Point(236, 97);
            lblPontosClube.Name = "lblPontosClube";
            lblPontosClube.Size = new Size(171, 22);
            lblPontosClube.TabIndex = 10;
            lblPontosClube.Text = "Pontos do Clube:";
            // 
            // txtJogosClube
            // 
            txtJogosClube.Font = new Font("Arial", 14.25F);
            txtJogosClube.Location = new Point(236, 179);
            txtJogosClube.Name = "txtJogosClube";
            txtJogosClube.Size = new Size(293, 29);
            txtJogosClube.TabIndex = 13;
            // 
            // lblJogosClube
            // 
            lblJogosClube.AutoSize = true;
            lblJogosClube.BackColor = Color.White;
            lblJogosClube.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblJogosClube.ForeColor = Color.DarkBlue;
            lblJogosClube.Location = new Point(236, 157);
            lblJogosClube.Name = "lblJogosClube";
            lblJogosClube.Size = new Size(163, 22);
            lblJogosClube.TabIndex = 12;
            lblJogosClube.Text = "Jogos do Clube:";
            // 
            // txtSaldoGols
            // 
            txtSaldoGols.Font = new Font("Arial", 14.25F);
            txtSaldoGols.Location = new Point(236, 238);
            txtSaldoGols.Name = "txtSaldoGols";
            txtSaldoGols.Size = new Size(293, 29);
            txtSaldoGols.TabIndex = 15;
            // 
            // lblSaldoGols
            // 
            lblSaldoGols.AutoSize = true;
            lblSaldoGols.BackColor = Color.White;
            lblSaldoGols.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblSaldoGols.ForeColor = Color.DarkBlue;
            lblSaldoGols.Location = new Point(236, 216);
            lblSaldoGols.Name = "lblSaldoGols";
            lblSaldoGols.Size = new Size(146, 22);
            lblSaldoGols.TabIndex = 14;
            lblSaldoGols.Text = "Saldo de Gols:";
            // 
            // txtVitoriasClube
            // 
            txtVitoriasClube.Font = new Font("Arial", 14.25F);
            txtVitoriasClube.Location = new Point(554, 59);
            txtVitoriasClube.Name = "txtVitoriasClube";
            txtVitoriasClube.Size = new Size(293, 29);
            txtVitoriasClube.TabIndex = 17;
            // 
            // lblVitoriasClube
            // 
            lblVitoriasClube.AutoSize = true;
            lblVitoriasClube.BackColor = Color.White;
            lblVitoriasClube.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblVitoriasClube.ForeColor = Color.DarkBlue;
            lblVitoriasClube.Location = new Point(554, 37);
            lblVitoriasClube.Name = "lblVitoriasClube";
            lblVitoriasClube.Size = new Size(176, 22);
            lblVitoriasClube.TabIndex = 16;
            lblVitoriasClube.Text = "Vitórias do Clube:";
            // 
            // txtDerrotasClube
            // 
            txtDerrotasClube.Font = new Font("Arial", 14.25F);
            txtDerrotasClube.Location = new Point(554, 119);
            txtDerrotasClube.Name = "txtDerrotasClube";
            txtDerrotasClube.Size = new Size(293, 29);
            txtDerrotasClube.TabIndex = 19;
            // 
            // lblDerrotasClube
            // 
            lblDerrotasClube.AutoSize = true;
            lblDerrotasClube.BackColor = Color.White;
            lblDerrotasClube.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblDerrotasClube.ForeColor = Color.DarkBlue;
            lblDerrotasClube.Location = new Point(554, 97);
            lblDerrotasClube.Name = "lblDerrotasClube";
            lblDerrotasClube.Size = new Size(186, 22);
            lblDerrotasClube.TabIndex = 18;
            lblDerrotasClube.Text = "Derrotas do Clube:";
            // 
            // txtEmpatesClube
            // 
            txtEmpatesClube.Font = new Font("Arial", 14.25F);
            txtEmpatesClube.Location = new Point(554, 179);
            txtEmpatesClube.Name = "txtEmpatesClube";
            txtEmpatesClube.Size = new Size(293, 29);
            txtEmpatesClube.TabIndex = 21;
            // 
            // lblEmpatesClube
            // 
            lblEmpatesClube.AutoSize = true;
            lblEmpatesClube.BackColor = Color.White;
            lblEmpatesClube.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblEmpatesClube.ForeColor = Color.DarkBlue;
            lblEmpatesClube.Location = new Point(554, 157);
            lblEmpatesClube.Name = "lblEmpatesClube";
            lblEmpatesClube.Size = new Size(186, 22);
            lblEmpatesClube.TabIndex = 20;
            lblEmpatesClube.Text = "Empates do Clube:";
            // 
            // txtPosicaoTabela
            // 
            txtPosicaoTabela.Font = new Font("Arial", 14.25F);
            txtPosicaoTabela.Location = new Point(554, 238);
            txtPosicaoTabela.Name = "txtPosicaoTabela";
            txtPosicaoTabela.Size = new Size(293, 29);
            txtPosicaoTabela.TabIndex = 23;
            // 
            // lblPosicaoTabela
            // 
            lblPosicaoTabela.AutoSize = true;
            lblPosicaoTabela.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblPosicaoTabela.ForeColor = Color.DarkBlue;
            lblPosicaoTabela.Location = new Point(554, 216);
            lblPosicaoTabela.Name = "lblPosicaoTabela";
            lblPosicaoTabela.Size = new Size(181, 22);
            lblPosicaoTabela.TabIndex = 22;
            lblPosicaoTabela.Text = "Posição na tabela:";
            // 
            // frmAtualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 601);
            Controls.Add(txtPosicaoTabela);
            Controls.Add(lblPosicaoTabela);
            Controls.Add(txtEmpatesClube);
            Controls.Add(lblEmpatesClube);
            Controls.Add(txtDerrotasClube);
            Controls.Add(lblDerrotasClube);
            Controls.Add(txtVitoriasClube);
            Controls.Add(lblVitoriasClube);
            Controls.Add(txtSaldoGols);
            Controls.Add(lblSaldoGols);
            Controls.Add(txtJogosClube);
            Controls.Add(lblJogosClube);
            Controls.Add(txtPontosClube);
            Controls.Add(lblPontosClube);
            Controls.Add(txtNomeClube);
            Controls.Add(lblNomeClube);
            Controls.Add(dgvAtualizar);
            Controls.Add(pnlRodape);
            Controls.Add(pnlConsultar);
            Controls.Add(pbAtualizar);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAtualizar";
            Text = "Sistema de Controle de Times -  Tela atualizar";
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).EndInit();
            pnlConsultar.ResumeLayout(false);
            pnlConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAtualizar).EndInit();
            pnlRodape.ResumeLayout(false);
            pnlRodape.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAtualizar;
        private Panel pnlConsultar;
        private Label lblSeries;
        private ComboBox cbSeries;
        private Label lblTituloAlto;
        private Button btnInserir;
        private PictureBox pbAtualizar;
        private Panel pnlRodape;
        private RadioButton rbBuscarNomeTime;
        private TextBox txtBuscar;
        private RadioButton rbPosicao;
        private Label lblNomeClube;
        private TextBox txtNomeClube;
        private TextBox txtPontosClube;
        private Label lblPontosClube;
        private TextBox txtJogosClube;
        private Label lblJogosClube;
        private TextBox txtSaldoGols;
        private Label lblSaldoGols;
        private TextBox txtVitoriasClube;
        private Label lblVitoriasClube;
        private TextBox txtDerrotasClube;
        private Label lblDerrotasClube;
        private TextBox txtEmpatesClube;
        private Label lblEmpatesClube;
        private TextBox txtPosicaoTabela;
        private Label lblPosicaoTabela;
        private Button btnApagar;
        private Button btnAtualizar;
    }
}