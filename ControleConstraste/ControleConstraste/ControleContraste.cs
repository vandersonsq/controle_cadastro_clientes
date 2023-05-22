using ControleConstraste.Classes;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControleConstraste
{
    public partial class ControleContraste : Form
    {
        private BindingList<Paciente> pacientes = new BindingList<Paciente>();

        public ControleContraste()
        {
            InitializeComponent();
            EstilizarFormulario();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Verificar se o arquivo existe
            if (File.Exists("dados.json"))
            {
                string jsonData = File.ReadAllText("dados.json");
                List<Paciente> pacientesList = JsonConvert.DeserializeObject<List<Paciente>>(jsonData);

                pacientes = new BindingList<Paciente>(pacientesList);
            }
            else
            {
                // Caso o arquivo não exista, criar uma nova instância de BindingList<Paciente>
                pacientes = new BindingList<Paciente>();
            }

            // Configura o DataGridView
            dataGridView1.DataSource = pacientes;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns["data"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Exibir os dados da linha selecionada nos campos
                textBoxPaciente.Text = row.Cells["Paciente"].Value.ToString();
                textBoxCodigo.Text = row.Cells["Codigo"].Value.ToString();
                comboTcRs.SelectedItem = row.Cells["Tipo"].Value.ToString();
            }
        }

        private void LimparCampos()
        {
            textBoxPaciente.Text = string.Empty;
            textBoxCodigo.Text = string.Empty;
            comboTcRs.SelectedIndex = -1;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string nome = textBoxPaciente.Text;
            string codigo = textBoxCodigo.Text;
            DateTime data = DateTime.Now;
            string tipo = comboTcRs.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar um paciente.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Paciente paciente = new Paciente(nome, codigo, data, tipo);
            pacientes.Add(paciente);

            string jsonData = JsonConvert.SerializeObject(pacientes);
            File.WriteAllText("dados.json", jsonData);

            LimparCampos();

            MessageBox.Show("Dados inseridos com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                pacientes.RemoveAt(row.Index);
                dataGridView1.Refresh();

                LimparCampos();

                // Salvar a lista atualizada no arquivo JSON
                string jsonData = JsonConvert.SerializeObject(pacientes.ToList());
                File.WriteAllText("dados.json", jsonData);

                MessageBox.Show("Dados excluídos com sucesso!" + MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBoxPaciente.Text) || string.IsNullOrWhiteSpace(textBoxCodigo.Text) || string.IsNullOrWhiteSpace(comboTcRs.Text))
                {
                    MessageBox.Show("Não há dados para serem excluídos", "Falha no cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void EstilizarFormulario()
        {
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            BackColor = Color.LightGray;

            Font = new Font("Arial", 12, FontStyle.Regular);
            ForeColor = Color.DarkBlue;

            // Estilizar os botões
            EstilizarBotao(btAdicionar);
            EstilizarBotao(btExcluir);

            // Estilizar as labels
            EstilizarLabel(nomePaciente);
            EstilizarLabel(codigoPaciente);
            EstilizarLabel(tipoExame);
            EstilizarLabel(operacaoCrud);

            // Estilizar as TextBoxes
            EstilizarTextBox(textBoxCodigo);
            EstilizarTextBox(textBoxPaciente);

            // Estilizar o ComboBox
            EstilizarComboBox(comboTcRs);
        }

        private void EstilizarBotao(Button botao)
        {
            botao.BackColor = Color.FromArgb(0, 192, 192);
            botao.FlatAppearance.BorderSize = 0;
            botao.Font = new Font("Arial", 12, FontStyle.Bold);
            botao.ForeColor = Color.White;
            botao.FlatStyle = FlatStyle.Flat;
        }

        private void EstilizarLabel(Label label)
        {
            label.Font = new Font("Arial", 12, FontStyle.Regular);
            label.ForeColor = Color.DarkBlue;
        }

        private void EstilizarTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Arial", 12, FontStyle.Regular);
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void EstilizarComboBox(ComboBox comboBox)
        {
            comboBox.Font = new Font("Arial", 12, FontStyle.Regular);
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.Black;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}