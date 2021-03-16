using AgendaTelefonica.Controllers;
using AgendaTelefonica.Entities;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace AgendaTelefonica.Views
{
    public partial class frmAgenda : MetroForm
    {
        private ContatoController _contatoController = new ContatoController();
        private TelefoneController _telefoneController = new TelefoneController();

        public frmAgenda()
        {
            InitializeComponent();
            PreencheTabelas();
        }

        private void PreencheTabelas()
        {
            try
            {
                tbNome.Text = string.Empty;
                tbTelefone.Text = string.Empty;
                tblTelefones.Rows.Clear();
                var contatos = _contatoController.GetAll();
                tblContatos.DataSource = new BindingList<ContatoEntity>(contatos.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            tbNome.Text = string.Empty;
            tbTelefone.Text = string.Empty;
            tblTelefones.Rows.Clear();
            tblContatos.Rows.Clear();
            PreencheTabelas();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var contatos = _contatoController.GetAll();
                if (!string.IsNullOrEmpty(tbNome.Text))
                {
                    contatos = contatos.Where(p => p.Nome.Contains(tbNome.Text));
                    tblContatos.DataSource = new BindingList<ContatoEntity>(contatos.OrderBy(p => p.Nome).ToList());
                }

                if (!string.IsNullOrEmpty(tbTelefone.Text))
                {
                    var contatosPorTelefone = _contatoController.SelectByNumero(tbTelefone.Text);
                    if (contatosPorTelefone != null)
                    {
                        var idsContatos = contatosPorTelefone.ToList().Select(p => p.Id);
                        contatos = contatos.Where(p => idsContatos.Contains(p.Id));
                        tblContatos.DataSource = new BindingList<ContatoEntity>(contatos.OrderBy(p => p.Nome).ToList());
                    }
                }
                if (contatos.Count() <= 0)
                {
                    MessageBox.Show("A busca não retornou resultados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblContatos_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (tblContatos.Rows.Count <= 0)
                {
                    return;
                }

                if (tblContatos.CurrentRow.Cells["ID"].Value == null)
                {
                    MessageBox.Show("Selecione um contato antes de continuar.");
                    return;
                }
                var idContato = int.Parse(tblContatos.CurrentRow.Cells["ID"].Value.ToString());
                var telefones = _telefoneController.GetAllByContato(idContato);
                tblTelefones.DataSource = new BindingList<TelefoneEntity>(telefones.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            frmIncluirContato frmIncluirContato = new frmIncluirContato();
            frmIncluirContato.StartPosition = FormStartPosition.CenterParent;
            frmIncluirContato.ShowDialog();
            PreencheTabelas();
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            if (tblContatos.Rows.Count <= 0)
            {
                return;
            }

            try
            {
                if (tblContatos.CurrentRow.Cells["ID"].Value == null)
                {
                    MessageBox.Show("Selecione um contato para editar.");
                    return;
                }

                var idContato = int.Parse(tblContatos.CurrentRow.Cells["ID"].Value.ToString());
                frmIncluirContato frmIncluirContato = new frmIncluirContato(idContato);
                frmIncluirContato.StartPosition = FormStartPosition.CenterParent;
                frmIncluirContato.ShowDialog();
                PreencheTabelas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if (tblContatos.Rows.Count <= 0)
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Deseja excluir o contato?", "Sim/Não", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                { 
                    if (tblContatos.CurrentRow.Cells["ID"].Value == null)
                    {
                        MessageBox.Show("Selecione um contato para editar.");
                        return;
                    }
                    var idContato = int.Parse(tblContatos.CurrentRow.Cells["ID"].Value.ToString());
                    var contato = _contatoController.Select(idContato);
                    if (contato != null)
                    {
                        _contatoController.Delete(contato);
                        PreencheTabelas();
                        MessageBox.Show("Contato excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelTelefone_Click(object sender, EventArgs e)
        {
            if (tblTelefones.Rows.Count <= 0)
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Deseja excluir o telefone?", "Sim/Não", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {                    
                    if (tblTelefones.CurrentRow.Cells["IDTELEFONE"].Value == null)
                    {
                        MessageBox.Show("Selecione um telefone para excluir.");
                        return;
                    }
                    var idTelefone = int.Parse(tblTelefones.CurrentRow.Cells["IDTELEFONE"].Value.ToString());
                    var telefone = _telefoneController.Select(idTelefone);
                    if (telefone != null)
                    {
                        _telefoneController.Delete(telefone);
                        PreencheTabelas();
                        MessageBox.Show("Telefone excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddTelefone_Click(object sender, EventArgs e)
        {
            if (tblContatos.Rows.Count <= 0)
            {
                return;
            }
            try
            {
                if (tblContatos.CurrentRow.Cells["ID"].Value == null)
                {
                    MessageBox.Show("Selecione um contato para inserir o telefone.");
                    return;
                }
                var idContato = int.Parse(tblContatos.CurrentRow.Cells["ID"].Value.ToString());
                frmIncluirTelefone frmIncluirTelefone = new frmIncluirTelefone(idContato);
                frmIncluirTelefone.StartPosition = FormStartPosition.CenterParent;
                frmIncluirTelefone.ShowDialog();
                PreencheTabelas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
