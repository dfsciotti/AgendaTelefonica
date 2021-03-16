
namespace AgendaTelefonica.Views
{
    partial class frmIncluirContato
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbNome = new MetroFramework.Controls.MetroTextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbIdade = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.tbNome.CustomButton.Image = null;
            this.tbNome.CustomButton.Location = new System.Drawing.Point(353, 1);
            this.tbNome.CustomButton.Name = "";
            this.tbNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNome.CustomButton.TabIndex = 1;
            this.tbNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNome.CustomButton.UseSelectable = true;
            this.tbNome.CustomButton.Visible = false;
            this.tbNome.Lines = new string[0];
            this.tbNome.Location = new System.Drawing.Point(98, 138);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNome.SelectedText = "";
            this.tbNome.SelectionLength = 0;
            this.tbNome.SelectionStart = 0;
            this.tbNome.ShortcutsEnabled = true;
            this.tbNome.Size = new System.Drawing.Size(375, 23);
            this.tbNome.TabIndex = 18;
            this.tbNome.UseSelectable = true;
            this.tbNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.btnSalvar});
            this.bindingNavigator1.Location = new System.Drawing.Point(20, 60);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(474, 59);
            this.bindingNavigator1.TabIndex = 20;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Idade";
            // 
            // tbIdade
            // 
            this.tbIdade.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdade.Location = new System.Drawing.Point(98, 167);
            this.tbIdade.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(57, 23);
            this.tbIdade.TabIndex = 23;
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
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSalvar.Image = global::AgendaTelefonica.Properties.Resources.icons8_ok_162;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(48, 56);
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.ToolTipText = "F5 - Salvar / Incluir";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmIncluirContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(514, 225);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncluirContato";
            this.Resizable = false;
            this.Text = "NOVO CONTATO";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbNome;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown tbIdade;
    }
}