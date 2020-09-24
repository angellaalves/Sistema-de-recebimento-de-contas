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

namespace ControleDeFinancas
{
    
    public partial class Form1 : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public Form1()
        {
            InitializeComponent();
        }
        #region 
        private void mostraResultados()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("Persist Security Info=False; server=127.0.0.1;database=controle_finaceiro;uid=root;password=533Wa0@");
            mConn.Open();

            //cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter("SELECT * FROM tb_recebimento", mConn);

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "tb_recebimento");

            //atribui o resultado à propriedade DataSource da dataGridView
            dvwResult.DataSource = mDataSet;
            dvwResult.DataMember = "tb_recebimento";
        }

        private void SomaResultados()


        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("Persist Security Info=False; server=127.0.0.1;database=controle_finaceiro;uid=root;password=533Wa0@");
            mConn.Open();

            //cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter("SELECT SUM(vl_recebimento) AS Total FROM tb_recebimento;", mConn);

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "tb_recebimento");

            //atribui o resultado à propriedade 
            dvwSaldo.DataSource = mDataSet;
            dvwSaldo.DataMember = "tb_recebimento";

        }

        #endregion 
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection("Persist Security Info=False; server=127.0.0.1;database=controle_finaceiro;uid=root;password=533Wa0@");
            // Abre a conexão
            mConn.Open();

            //Converte data
            DateTime Venc = Convert.ToDateTime(txtVenc.Text);
            txtVenc.Text = Venc.ToString("yyyy/MM/dd");

            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO tb_recebimento(vl_recebimento,dt_vencimento,ds_recebimento,ds_conta) " + "VALUES ('" + txtValor.Text + "', '" + txtVenc.Text + "','" + txtDesc.Text + "','" + txtTipo.Text + "')", mConn);

                //Executa a Query SQL
                command.ExecuteNonQuery();

                // Fecha a conexão
                mConn.Close();

                //Mensagem de Sucesso
                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Método criado para que quando o registo é gravado, automaticamente a dataGridView efectue um "Refresh"
                mostraResultados();
            }
            catch
            {
                MessageBox.Show("Digite data em formato dd/mm/yyyy");
            }
            //Query SQL
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostraResultados();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection("Persist Security Info=False; server=127.0.0.1;database=controle_finaceiro;uid=root;password=533Wa0@");
            // Abre a conexão
            mConn.Open();

            //Query SQL

            MySqlCommand command = new MySqlCommand("DELETE FROM tb_recebimento WHERE id_recebimento = '" + txtId.Text + "'", mConn);

            //Executa a Query SQL
            command.ExecuteNonQuery();

            // Fecha a conexão
            mConn.Close();

            //Mensagem de Sucesso
            MessageBox.Show("Deletado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Método criado para que quando o registo é gravado, automaticamente a dataGridView efectue um "Refresh"
            mostraResultados();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            SomaResultados();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            txtTipo.Text = "";
            txtValor.Text = "";
            txtVenc.Text = "";
            txtId.Text = "";
        }
    }
 }
