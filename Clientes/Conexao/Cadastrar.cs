using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes.Conexao
{
    public partial class Cadastrar : Form
    {
        MySqlConnection conn;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strsql;
        string Connection = "server=localhost; database=ControleCliente; uid = root; pwd=Allan3004; port=3306";
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (conn = new MySqlConnection())
                {
                    conn = new MySqlConnection(Connection);

                    strsql = "INSERT INTO Clientes (NOME, TELEFONE, CPF, EMAIL)    VALUES (@NOME, @TELEFONE, @CPF, @EMAIL)";
                    comando = new MySqlCommand(strsql, conn);
                    comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                    comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                    comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                    comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    conn.Open();

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                conn = null;
                comando = null;

            }
            MessageBox.Show("cliente cadastrado");
            frmConexaoMysql frm = new frmConexaoMysql();
            frm.Show();
            this.Hide();


        }
    }
}
