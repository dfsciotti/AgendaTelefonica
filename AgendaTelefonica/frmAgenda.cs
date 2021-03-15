using AgendaTelefonica.Controllers;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class frmAgenda : Form
    {
        private ContatoController _contatoController = new ContatoController();

        public frmAgenda()
        {
            InitializeComponent();
            dataGridView1.DataSource = _contatoController.GetAll();
        }
    }
}
