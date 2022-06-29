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
    public partial class TelaLogin : Form
    {
        string Connection = "server=localhost; database=ControleCliente; uid = root; pwd=Allan3004; port=3306";

        MySqlConnection conn;
        MySqlCommand comando;
        string strsql;
        MySqlDataReader dr;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void frmConexaoMysql_Load(object sender, EventArgs e)
        {
            try
            {
                using (conn = new MySqlConnection())
                {
                    conn = new MySqlConnection(Connection);



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
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            

                    conn = new MySqlConnection(Connection);

                    strsql = "SELECT Usuario, Senha FROM Usuarios WHERE Usuario = '" + txtUsuario.Text + "' and Senha = '" + txtSenha.Text + "'";
                    comando = new MySqlCommand(strsql, conn);
                    comando.CommandType = CommandType.Text;
                        

                try
                {
                conn.Open();
                   
                    dr = comando.ExecuteReader();
                    if (dr.Read())
                    {
                        usuario = dr[0].ToString();
                        senha = dr[1].ToString();
                        conn.Close();
                        if(usuario==txtUsuario.Text && senha == txtSenha.Text)
                        {
                            frmConexaoMysql frm = new frmConexaoMysql();
                            frm.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha invalida");
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
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
