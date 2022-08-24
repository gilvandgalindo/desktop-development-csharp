namespace GerenciamentoFuncionario.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.headerControl1 = new GerenciamentoFuncionario.WinForms.Controls.HeaderControl();
            this.pnlNavegacao = new System.Windows.Forms.Panel();
            this.lsbFuncionarios = new System.Windows.Forms.ListBox();
            this.pnlAtualizar = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pnlAreaPrincipal = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chkEBebedorCafe = new System.Windows.Forms.CheckBox();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCabecalho.SuspendLayout();
            this.pnlNavegacao.SuspendLayout();
            this.pnlAtualizar.SuspendLayout();
            this.pnlAreaPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Controls.Add(this.headerControl1);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(800, 129);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(800, 129);
            this.headerControl1.TabIndex = 0;
            // 
            // pnlNavegacao
            // 
            this.pnlNavegacao.Controls.Add(this.lsbFuncionarios);
            this.pnlNavegacao.Controls.Add(this.pnlAtualizar);
            this.pnlNavegacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavegacao.Location = new System.Drawing.Point(0, 129);
            this.pnlNavegacao.Name = "pnlNavegacao";
            this.pnlNavegacao.Size = new System.Drawing.Size(174, 321);
            this.pnlNavegacao.TabIndex = 2;
            // 
            // lsbFuncionarios
            // 
            this.lsbFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbFuncionarios.FormattingEnabled = true;
            this.lsbFuncionarios.ItemHeight = 15;
            this.lsbFuncionarios.Location = new System.Drawing.Point(0, 37);
            this.lsbFuncionarios.Name = "lsbFuncionarios";
            this.lsbFuncionarios.Size = new System.Drawing.Size(174, 284);
            this.lsbFuncionarios.TabIndex = 1;
            // 
            // pnlAtualizar
            // 
            this.pnlAtualizar.Controls.Add(this.btnAtualizar);
            this.pnlAtualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAtualizar.Location = new System.Drawing.Point(0, 0);
            this.pnlAtualizar.Name = "pnlAtualizar";
            this.pnlAtualizar.Size = new System.Drawing.Size(174, 37);
            this.pnlAtualizar.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Location = new System.Drawing.Point(47, 6);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // pnlAreaPrincipal
            // 
            this.pnlAreaPrincipal.Controls.Add(this.btnSalvar);
            this.pnlAreaPrincipal.Controls.Add(this.chkEBebedorCafe);
            this.pnlAreaPrincipal.Controls.Add(this.cmbCargos);
            this.pnlAreaPrincipal.Controls.Add(this.dtpDataNascimento);
            this.pnlAreaPrincipal.Controls.Add(this.txtNomeCompleto);
            this.pnlAreaPrincipal.Controls.Add(this.lblCargo);
            this.pnlAreaPrincipal.Controls.Add(this.lblDataNascimento);
            this.pnlAreaPrincipal.Controls.Add(this.lblNomeCompleto);
            this.pnlAreaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAreaPrincipal.Location = new System.Drawing.Point(174, 129);
            this.pnlAreaPrincipal.Name = "pnlAreaPrincipal";
            this.pnlAreaPrincipal.Size = new System.Drawing.Size(626, 321);
            this.pnlAreaPrincipal.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(24, 255);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkEBebedorCafe
            // 
            this.chkEBebedorCafe.AutoSize = true;
            this.chkEBebedorCafe.Location = new System.Drawing.Point(24, 216);
            this.chkEBebedorCafe.Name = "chkEBebedorCafe";
            this.chkEBebedorCafe.Size = new System.Drawing.Size(125, 19);
            this.chkEBebedorCafe.TabIndex = 5;
            this.chkEBebedorCafe.Text = "É bebedor de café?";
            this.chkEBebedorCafe.UseVisualStyleBackColor = true;
            // 
            // cmbCargos
            // 
            this.cmbCargos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(27, 168);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(569, 23);
            this.cmbCargos.TabIndex = 4;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(26, 103);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(284, 23);
            this.dtpDataNascimento.TabIndex = 3;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(27, 40);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(569, 23);
            this.txtNomeCompleto.TabIndex = 2;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(24, 143);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 15);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargos";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(24, 78);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(112, 15);
            this.lblDataNascimento.TabIndex = 1;
            this.lblDataNascimento.Text = "Data de nascimento";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(24, 14);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(94, 15);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome completo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAreaPrincipal);
            this.Controls.Add(this.pnlNavegacao);
            this.Controls.Add(this.pnlCabecalho);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlNavegacao.ResumeLayout(false);
            this.pnlAtualizar.ResumeLayout(false);
            this.pnlAreaPrincipal.ResumeLayout(false);
            this.pnlAreaPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCabecalho;
        private Panel pnlNavegacao;
        private Panel pnlAtualizar;
        private Button btnAtualizar;
        private Panel pnlAreaPrincipal;
        private Button btnSalvar;
        private CheckBox chkEBebedorCafe;
        private ComboBox cmbCargos;
        private DateTimePicker dtpDataNascimento;
        private TextBox txtNomeCompleto;
        private Label lblCargo;
        private Label lblDataNascimento;
        private Label lblNomeCompleto;
        private Controls.HeaderControl headerControl1;
        private BindingSource funcionarioBindingSource;
        private ListBox lsbFuncionarios;
    }
}