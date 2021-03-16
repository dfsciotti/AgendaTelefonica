
using AgendaTelefonica.Components;
using MetroFramework.Controls;

namespace AgendaTelefonica.Views
{
    partial class frmAgenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.tbNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tblContatos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTelefones = new System.Windows.Forms.DataGridView();
            this.IDTELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTelefone = new AgendaTelefonica.Components.NumericTextBox();
            this.btnDelTelefone = new System.Windows.Forms.Button();
            this.btnAddTelefone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTelefones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bindingNavigator1.GripMargin = new System.Windows.Forms.Padding(0);
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLimpar,
            this.btnExcluir,
            this.btnSalvar,
            this.btnEditar,
            this.btnBuscar});
            this.bindingNavigator1.Location = new System.Drawing.Point(20, 60);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(663, 59);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLimpar.Image = global::AgendaTelefonica.Properties.Resources.icons8_apagar_16;
            this.btnLimpar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 56);
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.ToolTipText = "F2 - Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExcluir.Image = global::AgendaTelefonica.Properties.Resources.icons8_delete_16;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(51, 56);
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.ToolTipText = "F4 - Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSalvar.Image = global::AgendaTelefonica.Properties.Resources.icons8_add_16;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(48, 56);
            this.btnSalvar.Text = "&Incluir";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.ToolTipText = "F5 - Salvar / Incluir";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEditar.Image = global::AgendaTelefonica.Properties.Resources.icons8_usuário_16;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 56);
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.ToolTipText = "F5 - Salvar / Incluir";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBuscar.Image = global::AgendaTelefonica.Properties.Resources.icons8_pesquisar_16;
            this.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 56);
            this.btnBuscar.Text = "&Pesquisar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.ToolTipText = "F8 - Pesquisar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbNome
            // 
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.tbNome.CustomButton.Image = null;
            this.tbNome.CustomButton.Location = new System.Drawing.Point(485, 1);
            this.tbNome.CustomButton.Name = "";
            this.tbNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNome.CustomButton.TabIndex = 1;
            this.tbNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNome.CustomButton.UseSelectable = true;
            this.tbNome.CustomButton.Visible = false;
            this.tbNome.Lines = new string[0];
            this.tbNome.Location = new System.Drawing.Point(93, 24);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNome.SelectedText = "";
            this.tbNome.SelectionLength = 0;
            this.tbNome.SelectionStart = 0;
            this.tbNome.ShortcutsEnabled = true;
            this.tbNome.Size = new System.Drawing.Size(507, 23);
            this.tbNome.TabIndex = 16;
            this.tbNome.UseSelectable = true;
            this.tbNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Nome";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Telefone";
            // 
            // tblContatos
            // 
            this.tblContatos.AllowUserToAddRows = false;
            this.tblContatos.AllowUserToDeleteRows = false;
            this.tblContatos.AllowUserToResizeColumns = false;
            this.tblContatos.AllowUserToResizeRows = false;
            this.tblContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.IDADE});
            this.tblContatos.Location = new System.Drawing.Point(20, 239);
            this.tblContatos.MultiSelect = false;
            this.tblContatos.Name = "tblContatos";
            this.tblContatos.ReadOnly = true;
            this.tblContatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblContatos.Size = new System.Drawing.Size(452, 267);
            this.tblContatos.TabIndex = 20;
            this.tblContatos.SelectionChanged += new System.EventHandler(this.tblContatos_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 41;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // IDADE
            // 
            this.IDADE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDADE.DataPropertyName = "IDADE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IDADE.DefaultCellStyle = dataGridViewCellStyle1;
            this.IDADE.HeaderText = "Idade";
            this.IDADE.Name = "IDADE";
            this.IDADE.ReadOnly = true;
            this.IDADE.Width = 59;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA.HeaderText = "Categoria";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle2;
            this.VALOR.HeaderText = "Valor Total";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CATEGORIA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VALOR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor Total";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tblTelefones
            // 
            this.tblTelefones.AllowUserToAddRows = false;
            this.tblTelefones.AllowUserToDeleteRows = false;
            this.tblTelefones.AllowUserToResizeColumns = false;
            this.tblTelefones.AllowUserToResizeRows = false;
            this.tblTelefones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTELEFONE,
            this.IDCONTATO,
            this.NUMERO});
            this.tblTelefones.Location = new System.Drawing.Point(479, 239);
            this.tblTelefones.MultiSelect = false;
            this.tblTelefones.Name = "tblTelefones";
            this.tblTelefones.ReadOnly = true;
            this.tblTelefones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblTelefones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTelefones.Size = new System.Drawing.Size(179, 267);
            this.tblTelefones.TabIndex = 22;
            // 
            // IDTELEFONE
            // 
            this.IDTELEFONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDTELEFONE.DataPropertyName = "ID";
            this.IDTELEFONE.HeaderText = "Id";
            this.IDTELEFONE.Name = "IDTELEFONE";
            this.IDTELEFONE.ReadOnly = true;
            this.IDTELEFONE.Visible = false;
            // 
            // IDCONTATO
            // 
            this.IDCONTATO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDCONTATO.DataPropertyName = "IDCONTATO";
            this.IDCONTATO.HeaderText = "IdContato";
            this.IDCONTATO.Name = "IDCONTATO";
            this.IDCONTATO.ReadOnly = true;
            this.IDCONTATO.Visible = false;
            // 
            // NUMERO
            // 
            this.NUMERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NUMERO.DataPropertyName = "NUMERO";
            this.NUMERO.HeaderText = "Telefone";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.ReadOnly = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 217);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Contatos";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(501, 217);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Telefones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(23, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 85);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros da pesquisa";
            // 
            // tbTelefone
            // 
            // 
            // 
            // 
            this.tbTelefone.Lines = new string[0];
            this.tbTelefone.Location = new System.Drawing.Point(93, 53);
            this.tbTelefone.MaxLength = 16;
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.PasswordChar = '\0';
            this.tbTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTelefone.SelectedText = "";
            this.tbTelefone.SelectionLength = 0;
            this.tbTelefone.SelectionStart = 0;
            this.tbTelefone.ShortcutsEnabled = true;
            this.tbTelefone.Size = new System.Drawing.Size(148, 23);
            this.tbTelefone.TabIndex = 21;
            // 
            // btnDelTelefone
            // 
            this.btnDelTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelTelefone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelTelefone.FlatAppearance.BorderSize = 0;
            this.btnDelTelefone.Image = global::AgendaTelefonica.Properties.Resources.icons8_delete_16;
            this.btnDelTelefone.Location = new System.Drawing.Point(661, 268);
            this.btnDelTelefone.Name = "btnDelTelefone";
            this.btnDelTelefone.Size = new System.Drawing.Size(23, 23);
            this.btnDelTelefone.TabIndex = 27;
            this.btnDelTelefone.UseVisualStyleBackColor = true;
            this.btnDelTelefone.Click += new System.EventHandler(this.btnDelTelefone_Click);
            // 
            // btnAddTelefone
            // 
            this.btnAddTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTelefone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTelefone.FlatAppearance.BorderSize = 0;
            this.btnAddTelefone.Image = global::AgendaTelefonica.Properties.Resources.icons8_add_16;
            this.btnAddTelefone.Location = new System.Drawing.Point(661, 239);
            this.btnAddTelefone.Name = "btnAddTelefone";
            this.btnAddTelefone.Size = new System.Drawing.Size(23, 23);
            this.btnAddTelefone.TabIndex = 26;
            this.btnAddTelefone.UseVisualStyleBackColor = true;
            this.btnAddTelefone.Click += new System.EventHandler(this.btnAddTelefone_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(703, 529);
            this.Controls.Add(this.btnDelTelefone);
            this.Controls.Add(this.btnAddTelefone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tblTelefones);
            this.Controls.Add(this.tblContatos);
            this.Controls.Add(this.bindingNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(703, 529);
            this.Name = "frmAgenda";
            this.Text = "AGENDA TELEFÔNICA";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTelefones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private MetroTextBox tbNome;
        private MetroLabel metroLabel1;
        private MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView tblContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private NumericTextBox tbTelefone;
        private System.Windows.Forms.DataGridView tblTelefones;
        private MetroLabel metroLabel3;
        private MetroLabel metroLabel4;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDADE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTelefone;
        private System.Windows.Forms.Button btnDelTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
    }
}

