namespace UsuariosMVC
{
  partial class FrmUsuarios
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grbSex = new System.Windows.Forms.GroupBox();
            this.rdFeminino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultar = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpDetails.SuspendLayout();
            this.grbSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.Consultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(641, 98);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.ExcluirUsuario);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.Consultar);
            this.grpDetails.Controls.Add(this.grbSex);
            this.grpDetails.Controls.Add(this.txtDepartamento);
            this.grpDetails.Controls.Add(this.lblDepartment);
            this.grpDetails.Controls.Add(this.txtID);
            this.grpDetails.Controls.Add(this.lblID);
            this.grpDetails.Controls.Add(this.txtSobrenome);
            this.grpDetails.Controls.Add(this.lblLastName);
            this.grpDetails.Controls.Add(this.txtNome);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDetails.Location = new System.Drawing.Point(12, 6);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(614, 144);
            this.grpDetails.TabIndex = 39;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Registrar Usuário";
            // 
            // grbSex
            // 
            this.grbSex.Controls.Add(this.rdFeminino);
            this.grbSex.Controls.Add(this.rdMasculino);
            this.grbSex.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grbSex.Location = new System.Drawing.Point(10, 79);
            this.grbSex.Name = "grbSex";
            this.grbSex.Size = new System.Drawing.Size(218, 54);
            this.grbSex.TabIndex = 5;
            this.grbSex.TabStop = false;
            this.grbSex.Text = "Sexo";
            // 
            // rdFeminino
            // 
            this.rdFeminino.Location = new System.Drawing.Point(112, 19);
            this.rdFeminino.Name = "rdFeminino";
            this.rdFeminino.Size = new System.Drawing.Size(84, 24);
            this.rdFeminino.TabIndex = 5;
            this.rdFeminino.Text = "Feminino";
            // 
            // rdMasculino
            // 
            this.rdMasculino.Checked = true;
            this.rdMasculino.Location = new System.Drawing.Point(32, 19);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(74, 24);
            this.rdMasculino.TabIndex = 4;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(404, 21);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(204, 23);
            this.txtDepartamento.TabIndex = 2;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(317, 25);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(89, 17);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Departamento:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(52, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(218, 23);
            this.txtID.TabIndex = 1;
            this.txtID.Leave += new System.EventHandler(this.BuscaPorId);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(24, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 20);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(404, 50);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(204, 23);
            this.txtSobrenome.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(317, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 15);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(52, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 23);
            this.txtNome.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(8, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(43, 18);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "Nome:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(641, 40);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo ";
            this.btnNovo.Click += new System.EventHandler(this.Novo);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(641, 69);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(97, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.Click += new System.EventHandler(this.GravarDados);
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnSobrenome,
            this.ColumnSexo,
            this.ColumnDepartamento});
            this.grdUsuarios.Location = new System.Drawing.Point(9, 155);
            this.grdUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.RowHeadersWidth = 51;
            this.grdUsuarios.RowTemplate.Height = 24;
            this.grdUsuarios.Size = new System.Drawing.Size(729, 294);
            this.grdUsuarios.TabIndex = 40;
            this.grdUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectCell);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnSobrenome
            // 
            this.ColumnSobrenome.HeaderText = "Sobrenome";
            this.ColumnSobrenome.Name = "ColumnSobrenome";
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            // 
            // ColumnDepartamento
            // 
            this.ColumnDepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDepartamento.HeaderText = "Departamento";
            this.ColumnDepartamento.Name = "ColumnDepartamento";
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.btnPesquisar);
            this.Consultar.Controls.Add(this.txtPesquisa);
            this.Consultar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Consultar.Location = new System.Drawing.Point(320, 84);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(288, 54);
            this.Consultar.TabIndex = 30;
            this.Consultar.TabStop = false;
            this.Consultar.Text = "Consultar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(190, 20);
            this.txtPesquisa.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(202, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(64, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.Procurar);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 459);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGravar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários Ativos";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grbSex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    internal System.Windows.Forms.Button btnExcluir;
    internal System.Windows.Forms.GroupBox grpDetails;
    private System.Windows.Forms.GroupBox grbSex;
    internal System.Windows.Forms.RadioButton rdFeminino;
    internal System.Windows.Forms.RadioButton rdMasculino;
    internal System.Windows.Forms.TextBox txtDepartamento;
    internal System.Windows.Forms.Label lblDepartment;
    internal System.Windows.Forms.TextBox txtID;
    internal System.Windows.Forms.Label lblID;
    internal System.Windows.Forms.TextBox txtSobrenome;
    internal System.Windows.Forms.Label lblLastName;
    internal System.Windows.Forms.TextBox txtNome;
    internal System.Windows.Forms.Label lblFirstName;
    internal System.Windows.Forms.Button btnNovo;
    internal System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartamento;
        private System.Windows.Forms.GroupBox Consultar;
        internal System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}

