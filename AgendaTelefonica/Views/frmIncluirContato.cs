using AgendaTelefonica.Controllers;
using AgendaTelefonica.Entities;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace AgendaTelefonica.Views
{
    public partial class frmIncluirContato : MetroForm
    {
        private int _idContato;
        private ContatoController _contatoController = new ContatoController();

        public frmIncluirContato()
        {
            InitializeComponent();
            Text = "NOVO CONTATO";
        }
        public frmIncluirContato(int idContato)
        {
            InitializeComponent();
            _idContato = idContato;
            Text = "EDITAR CONTATO";

            var contato = _contatoController.Select(_idContato);
            tbNome.Text = contato.Nome;
            tbIdade.Text = contato.Idade.ToString();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNome.Text) || string.IsNullOrEmpty(tbIdade.Text))
            {
                MessageBox.Show("Preencha os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (_idContato > 0)
                {
                    var contato = _contatoController.Select(_idContato);
                    if (contato != null)
                    {
                        contato.Nome = tbNome.Text;
                        contato.Idade = int.Parse(tbIdade.Text);
                    }
                    _contatoController.Update(contato);
                }
                else
                {
                    var contato = new ContatoEntity()
                    {
                        Nome = tbNome.Text,
                        Idade = int.Parse(tbIdade.Text)
                    };
                    _contatoController.Insert(contato);
                }
                MessageBox.Show("Operação realizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            tbNome.Text = string.Empty;
            tbIdade.Text = string.Empty;
        }
    }
}
