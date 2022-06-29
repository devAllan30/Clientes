
namespace Clientes.Conexao
{
    partial class frmConexaoMysql
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvTabela = new System.Windows.Forms.ListView();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 212);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.AutoCompleteCustomSource.AddRange(new string[] {
            "(00) 0000-0000"});
            this.txtTelefone.Location = new System.Drawing.Point(255, 264);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 23);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::Clientes.Properties.Resources.icons8_adicionar_24;
            this.btnCadastrar.Location = new System.Drawing.Point(403, 30);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(33, 30);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(456, 264);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 32);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.AutoCompleteCustomSource.AddRange(new string[] {
            "(00) 0000-0000"});
            this.txtCPF.Location = new System.Drawing.Point(26, 259);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(146, 23);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteCustomSource.AddRange(new string[] {
            "(00) 0000-0000"});
            this.txtEmail.Location = new System.Drawing.Point(255, 212);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 23);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged_1);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(64, 30);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(251, 23);
            this.txtPesquisar.TabIndex = 10;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pesquisar nome:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(331, 30);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(55, 23);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Buscar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(456, 226);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 30);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(600, 15);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(34, 23);
            this.txt_ID.TabIndex = 14;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lvTabela
            // 
            this.lvTabela.HideSelection = false;
            this.lvTabela.Location = new System.Drawing.Point(50, 59);
            this.lvTabela.Name = "lvTabela";
            this.lvTabela.Size = new System.Drawing.Size(373, 129);
            this.lvTabela.TabIndex = 16;
            this.lvTabela.UseCompatibleStateImageBehavior = false;
            this.lvTabela.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(456, 92);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(90, 32);
            this.btnCarregar.TabIndex = 17;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmConexaoMysql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 332);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.lvTabela);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmConexaoMysql";
            this.Text = "frmConexaoMysql";
            this.Load += new System.EventHandler(this.frmConexaoMysql_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvTabela;
        private System.Windows.Forms.Button btnCarregar;
    }
}