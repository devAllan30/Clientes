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
    public partial class frmConexaoMysql : Form
    {

        MySqlConnection conn;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strsql;
        string Connection = "server=localhost; database=ControleCliente; uid = root; pwd=Allan3004; port=3306";
        public frmConexaoMysql()
        {
            InitializeComponent();
            lvTabela.View = View.Details;
            lvTabela.LabelEdit = true;
            lvTabela.AllowColumnReorder = true;
            lvTabela.FullRowSelect = true;
            lvTabela.GridLines = true;
            lvTabela.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lvTabela.Columns.Add("Nome", 90, HorizontalAlignment.Left);
            lvTabela.Columns.Add("Telefone", 90, HorizontalAlignment.Left);
            lvTabela.Columns.Add("CPF", 90, HorizontalAlignment.Left);
            lvTabela.Columns.Add("Email", 130, HorizontalAlignment.Left);
            listar();
        }


        private void frmConexaoMysql_Load(object sender, EventArgs e)
        {
            try
            {
                using (conn = new MySqlConnection())
                {
                    conn = new MySqlConnection(Connection);

                    comando.Parameters.AddWithValue("@NUMERO", txtTelefone.Text);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar frm = new Cadastrar();
            frm.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmConexaoMysql_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Carregar();

          
                conn = new MySqlConnection(Connection);

                strsql = "DELETE FROM Clientes WHERE idClientes = @id";
           
                comando = new MySqlCommand(strsql, conn);
            comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = txt_ID.Text;

            

            try
                {
                conn.Open();

                comando.ExecuteNonQuery();
                MessageBox.Show("cliente excluido");
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtPesquisar.Text + "%'";
                conn = new MySqlConnection(Connection);
                strsql = "Select  * FROM Clientes WHERE Nome LIKE" + q + "OR Email LIKE" + q;

                conn.Open();
                comando = new MySqlCommand(strsql, conn);


                dr = comando.ExecuteReader();
                lvTabela.Items.Clear();


                while (dr.Read())
                {
                    string[] row =
                    {
                        dr.GetString(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4)
                    };
                    var linha_listView = new ListViewItem(row);
                    lvTabela.Items.Add(linha_listView);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

               
                    conn = new MySqlConnection(Connection);

                    strsql = "UPDATE Clientes  set Nome = @NOME, Telefone = @TELEFONE, CPF = @CPF, EMAIL = @EMAIL WHERE idClientes = @N ";
                    comando = new MySqlCommand(strsql, conn);
                    comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                    comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                    comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                    comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            comando.Parameters.AddWithValue("@N", txt_ID.Text);
            try
            {
                conn.Open();

                   comando.ExecuteNonQuery();
                MessageBox.Show("Informações do cliente atualizada");
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
    private void listar()
    {
            try
            {
               
                conn = new MySqlConnection(Connection);
                strsql = "Select  * FROM Clientes";

                conn.Open();
                comando = new MySqlCommand(strsql, conn);


                dr = comando.ExecuteReader();
                lvTabela.Items.Clear();


                while (dr.Read())
                {
                    string[] row =
                    {
                        dr.GetString(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4)
                    };
                    var linha_listView = new ListViewItem(row);
                    lvTabela.Items.Add(linha_listView);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Carregar();
            txtNome.Text = lvTabela.SelectedItems[0].SubItems[1].Text;
            txtTelefone.Text = lvTabela.SelectedItems[0].SubItems[2].Text;
            txtCPF.Text = lvTabela.SelectedItems[0].SubItems[3].Text;
            txtEmail.Text = lvTabela.SelectedItems[0].SubItems[4].Text;



        }
        private void Carregar()
        {
            txt_ID.Text = lvTabela.SelectedItems[0].SubItems[0].Text;
        }
    }
  
}
