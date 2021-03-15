using AgendaTelefonica.Controllers;
using MetroFramework.Forms;
using System.Linq;

namespace AgendaTelefonica.Views
{
    public partial class frmAgenda : MetroForm
    {
        private ContatoController _contatoController = new ContatoController();

        public frmAgenda()
        {
            InitializeComponent();
            tblContatos.DataSource = _contatoController.GetAll();
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            tbNome.Text = string.Empty;
            tbTelefone.Text = string.Empty;
            tblContatos.DataSource = _contatoController.GetAll();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            var contatos = _contatoController.GetAll();
            if (!string.IsNullOrEmpty(tbNome.Text))
            {
                contatos = contatos.Where(p => p.Nome.Contains(tbNome.Text));
            }
            tblContatos.DataSource = contatos.OrderBy(p => p.Nome).ToList();
        }
    }
}
