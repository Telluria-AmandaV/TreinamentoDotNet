using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppTesteWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string strCon = @"persistsecurityinfo=True;server=localhost;user id=root;database=apptestewin; pwd=061127";
            MySqlConnection cn;
            try
            {
                cn = new MySqlConnection(strCon);
                cn.Open();

                MySqlCommand comd = new MySqlCommand();
                comd.Connection = cn;
                comd.CommandType = CommandType.Text;
                comd.CommandText = "delete from cadastroSimples where codigo = '" + txtCod.Text + "';";
                comd.ExecuteNonQuery();
                MessageBox.Show("Registro apagado com sucesso!");
                LimparTela();
                TxtCPF.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Não é possível deletar no momento");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (TxtCPF.Text == "" || TxtCPF.Text == null)
            {
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                return;
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
            TxtCPF.Text = null;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string strCon = @"persistsecurityinfo=True;server=localhost;user id=root;database=apptestewin; pwd=061127";
            MySqlConnection cn;
            try
            {
                cn = new MySqlConnection(strCon);
                cn.Open();
                
                MySqlCommand comd = new MySqlCommand();
                comd.Connection = cn;
                comd.CommandType = CommandType.Text;
                if (txtCod.Text == "" || txtCod.Text == null)
                {
                    comd.CommandText = "insert into cadastroSimples(cpf, nome, endereco, genero, telefone) values('" + TxtCPF.Text + "', '" +
                        TxtNome.Text + "', '" + txtEndereco.Text + "', " + lerComboBox() + ", '" + txtTelefone.Text + "'); ";
                }
                else
                {
                    comd.CommandText = "update cadastroSimples set cpf = '" + TxtCPF.Text + "', nome= '" + TxtNome.Text +
                        "', endereco= '" + txtEndereco.Text + "', genero= " + lerComboBox() + ", telefone= '" + txtTelefone.Text +
                        "' where codigo=" + int.Parse(txtCod.Text) + ";";
                }
                comd.ExecuteNonQuery();
                MessageBox.Show("Registro salvo com sucesso!");
                //adicionar código gerado
                // comd.CommandText = "select codigo from cadastroSimples where cpf = '" + TxtCPF.Text + "';" ;
                comd.CommandText = "select codigo from cadastroSimples where cpf = '" + TxtCPF.Text + "';";
                MySqlDataReader rd;
                rd = comd.ExecuteReader();
                rd.Read();
                txtCod.Text = rd.GetString(0);

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (TxtCPF.Text == "" || TxtCPF.Text == null)
            {
                btnSalvar.Enabled = false;
            }
            else
            {
                btnSalvar.Enabled = true;
            }
            string strCon = @"persistsecurityinfo=True;server=localhost;user id=root;database=apptestewin; pwd=061127";
            MySqlConnection cn = new MySqlConnection(strCon);
            cn.Open();
            MySqlCommand comd = new MySqlCommand();
            comd.Connection = cn;
            comd.CommandType = CommandType.Text;
            comd.CommandText = "select * from cadastroSimples where cpf = '" + TxtCPF.Text + "';";
            MySqlDataReader rd;
            rd = comd.ExecuteReader();
            if (rd.Read())
            {
                txtCod.Text = rd.GetInt32("codigo").ToString();
                TxtNome.Text = rd.GetString("nome");
                txtTelefone.Text = rd.GetString("telefone");
                txtEndereco.Text = rd.GetString("endereco");
                EscreverComboBox(rd.GetInt32("genero"));
            }
            else
            {
                LimparTela();
            }
            cn.Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private int lerComboBox()
        {
            if (radioButton1.Checked)
            {
                return 0;
            }
            else if (radioButton2.Checked)
            {
                return 1;
            }
            else if (radioButton3.Checked)
            {
                return 2;
            }else 
            {
                //inclusive se a radioButton4 estiver marcada
                return 3;
            }
        }

        private void EscreverComboBox(int i)
        {
            switch (i)
            {
                case 0:
                    radioButton1.Checked = true;
                    break;
                case 1:
                    radioButton2.Checked = true;
                    break;
                case 2:
                    radioButton3.Checked = true;
                    break;
                case 3:
                default:
                    radioButton4.Checked = true;
                    break;
            }
        }

        private void LimparTela()
        {
            txtCod.Text = null;
            TxtNome.Text = null;
            txtEndereco.Text = null;
            txtTelefone.Text = null;
            radioButton4.Checked = true;
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text == "" || txtCod.Text == null)
            {
                btnExcluir.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
            }
        }
    }
}
