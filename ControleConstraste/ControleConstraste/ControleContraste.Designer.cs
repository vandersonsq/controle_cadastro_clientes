namespace ControleConstraste
{
    partial class ControleContraste
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
            nomePaciente = new Label();
            codigoPaciente = new Label();
            tipoExame = new Label();
            textBoxCodigo = new TextBox();
            textBoxPaciente = new TextBox();
            comboTcRs = new ComboBox();
            operacaoCrud = new Label();
            btAdicionar = new Button();
            btExcluir = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nomePaciente
            // 
            nomePaciente.AutoSize = true;
            nomePaciente.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nomePaciente.Location = new Point(12, 23);
            nomePaciente.Name = "nomePaciente";
            nomePaciente.Size = new Size(108, 17);
            nomePaciente.TabIndex = 2;
            nomePaciente.Text = "Nome Paciente";
            // 
            // codigoPaciente
            // 
            codigoPaciente.AutoSize = true;
            codigoPaciente.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            codigoPaciente.Location = new Point(446, 25);
            codigoPaciente.Name = "codigoPaciente";
            codigoPaciente.Size = new Size(54, 17);
            codigoPaciente.TabIndex = 3;
            codigoPaciente.Text = "Código";
            // 
            // tipoExame
            // 
            tipoExame.AutoSize = true;
            tipoExame.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tipoExame.Location = new Point(616, 25);
            tipoExame.Name = "tipoExame";
            tipoExame.Size = new Size(35, 17);
            tipoExame.TabIndex = 4;
            tipoExame.Text = "Tipo";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(498, 22);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(112, 23);
            textBoxCodigo.TabIndex = 2;
            // 
            // textBoxPaciente
            // 
            textBoxPaciente.Location = new Point(126, 22);
            textBoxPaciente.Name = "textBoxPaciente";
            textBoxPaciente.Size = new Size(314, 23);
            textBoxPaciente.TabIndex = 1;
            // 
            // comboTcRs
            // 
            comboTcRs.FormattingEnabled = true;
            comboTcRs.Items.AddRange(new object[] { "Tomografia", "Ressonância" });
            comboTcRs.Location = new Point(652, 22);
            comboTcRs.Name = "comboTcRs";
            comboTcRs.Size = new Size(136, 23);
            comboTcRs.TabIndex = 3;
            // 
            // operacaoCrud
            // 
            operacaoCrud.AutoSize = true;
            operacaoCrud.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            operacaoCrud.Location = new Point(811, 104);
            operacaoCrud.Name = "operacaoCrud";
            operacaoCrud.Size = new Size(73, 17);
            operacaoCrud.TabIndex = 8;
            operacaoCrud.Text = "Operação";
            // 
            // btAdicionar
            // 
            btAdicionar.BackColor = Color.FromArgb(0, 192, 192);
            btAdicionar.FlatAppearance.BorderSize = 10;
            btAdicionar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btAdicionar.ForeColor = SystemColors.ControlText;
            btAdicionar.Location = new Point(797, 135);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(99, 45);
            btAdicionar.TabIndex = 4;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = false;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Red;
            btExcluir.FlatAppearance.BorderSize = 10;
            btExcluir.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btExcluir.ForeColor = SystemColors.ControlText;
            btExcluir.Location = new Point(797, 195);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(99, 45);
            btExcluir.TabIndex = 5;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 386);
            dataGridView1.TabIndex = 6;
            // 
            // ControleContraste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 449);
            Controls.Add(dataGridView1);
            Controls.Add(btExcluir);
            Controls.Add(btAdicionar);
            Controls.Add(operacaoCrud);
            Controls.Add(comboTcRs);
            Controls.Add(textBoxPaciente);
            Controls.Add(textBoxCodigo);
            Controls.Add(tipoExame);
            Controls.Add(codigoPaciente);
            Controls.Add(nomePaciente);
            Name = "ControleContraste";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Pacientes";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nomePaciente;
        private Label codigoPaciente;
        private Label tipoExame;
        private TextBox textBoxCodigo;
        private TextBox textBoxPaciente;
        private ComboBox comboTcRs;
        private Label operacaoCrud;
        private Button btAdicionar;
        private Button btExcluir;
        private DataGridView dataGridView1;
    }
}