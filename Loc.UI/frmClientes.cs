using Loc.BLL;
using Loc.DTO;
using System;
using System.Windows.Forms;

namespace Loc.UI
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Nome = txtNome.Text;
            cli.Cpf = txtCpf.Text;
            cli.Email = txtEmail.Text;
            cli.Telefone = txtTelefone.Text;
            cli.DtNascimento = DateTime.Parse(txtDataNasc.Text);
            cli.Sexo = cmbSexo.Text;
            cli.Cep = txtCep.Text;
            cli.Endereco = txtEndereco.Text;
            cli.Bairro = txtBairro.Text;
            cli.Cidade = txtCidade.Text;
            cli.Estado = cmbEstado.Text;

            new ClientesBLL().InserirCliente(cli);
        }
    }
}
