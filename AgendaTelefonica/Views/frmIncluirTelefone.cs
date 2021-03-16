using AgendaTelefonica.Controllers;
using AgendaTelefonica.Entities;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace AgendaTelefonica.Views
{
    public partial class frmIncluirTelefone : MetroForm
    {
        private TelefoneController _telefoneController = new TelefoneController();
        private int _idContato;

        public frmIncluirTelefone(int idContato)
        {
            InitializeComponent();
            _idContato = idContato;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTelefone.Text))
            {
                MessageBox.Show("Preencha os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var telefone = new TelefoneEntity()
                {
                    IdContato = _idContato,
                    Numero = tbTelefone.Text                    
                };
                _telefoneController.Insert(telefone);

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
            tbTelefone.Text = string.Empty;
        }
    }
}
