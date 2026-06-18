namespace App_Brasileirao_2026
{
    partial class frmConsultar
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
            btnConsulta = new Button();
            pnlConsultar = new Panel();
            lblSeries = new Label();
            cbSeries = new ComboBox();
            lblTituloAlto = new Label();
            pbConsultar = new PictureBox();
            dgvConsultar = new DataGridView();
            pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConsultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
            SuspendLayout();
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.LawnGreen;
            btnConsulta.Cursor = Cursors.Hand;
            btnConsulta.FlatStyle = FlatStyle.Popup;
            btnConsulta.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnConsulta.ForeColor = Color.DarkBlue;
            btnConsulta.Location = new Point(28, 394);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(152, 60);
            btnConsulta.TabIndex = 1;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = false;
            // 
            // pnlConsultar
            // 
            pnlConsultar.BackColor = Color.DarkBlue;
            pnlConsultar.Controls.Add(lblSeries);
            pnlConsultar.Controls.Add(cbSeries);
            pnlConsultar.Controls.Add(lblTituloAlto);
            pnlConsultar.Controls.Add(btnConsulta);
            pnlConsultar.Location = new Point(-1, -1);
            pnlConsultar.Name = "pnlConsultar";
            pnlConsultar.Size = new Size(209, 743);
            pnlConsultar.TabIndex = 1;
            // 
            // lblSeries
            // 
            lblSeries.AutoSize = true;
            lblSeries.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeries.ForeColor = Color.White;
            lblSeries.Location = new Point(28, 280);
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
            cbSeries.Location = new Point(28, 321);
            cbSeries.Name = "cbSeries";
            cbSeries.Size = new Size(152, 30);
            cbSeries.TabIndex = 3;
            // 
            // lblTituloAlto
            // 
            lblTituloAlto.AutoSize = true;
            lblTituloAlto.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAlto.ForeColor = Color.White;
            lblTituloAlto.Location = new Point(3, 71);
            lblTituloAlto.Name = "lblTituloAlto";
            lblTituloAlto.Size = new Size(203, 88);
            lblTituloAlto.TabIndex = 2;
            lblTituloAlto.Text = "Consultar \r\ntimes";
            lblTituloAlto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbConsultar
            // 
            pbConsultar.Image = Properties.Resources.jogador;
            pbConsultar.Location = new Point(570, -1);
            pbConsultar.Name = "pbConsultar";
            pbConsultar.Size = new Size(419, 743);
            pbConsultar.SizeMode = PictureBoxSizeMode.Zoom;
            pbConsultar.TabIndex = 2;
            pbConsultar.TabStop = false;
            // 
            // dgvConsultar
            // 
            dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultar.Location = new Point(231, 210);
            dgvConsultar.Name = "dgvConsultar";
            dgvConsultar.Size = new Size(620, 326);
            dgvConsultar.TabIndex = 3;
            // 
            // frmConsultar
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 739);
            Controls.Add(dgvConsultar);
            Controls.Add(pbConsultar);
            Controls.Add(pnlConsultar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmConsultar";
            Text = "Sistema de Controle de Times -  Tela consultar";
            pnlConsultar.ResumeLayout(false);
            pnlConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbConsultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsulta;
        private Panel pnlConsultar;
        private Label lblTituloAlto;
        private PictureBox pbConsultar;
        private Label lblSeries;
        private ComboBox cbSeries;
        private DataGridView dgvConsultar;
    }
}