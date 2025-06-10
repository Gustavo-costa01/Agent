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

namespace Agent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cliente_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Nome_cliente.Text == "")
            {
                MessageBox.Show("Insira o nome do cliente");
                Nome_cliente.Focus();
                return;
            }

            String[] ch = new String[4];
            ch[0] = Nome_cliente.Text;
            ch[1] = Service.Text;
            ch[2] = dtp_DataeHora.Text;
            ch[3] = obs_box.Text;

            ListViewItem l = new ListViewItem(ch);   
            listView.Items.Add(l);
            


            try
            {
                string strConexao = "server=localhost;database=agent;user id=root;password=Guga0804.";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso!");
                string query = "INSERT INTO chamado (nome,service, observacao, datahora) VALUES (@nome, @service, @observacao, @Date)";
                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@nome", Nome_cliente.Text);
                comando.Parameters.AddWithValue("@service", Service.Text);
                comando.Parameters.AddWithValue("@observacao", obs_box.Text);
                comando.Parameters.AddWithValue("@date", dtp_DataeHora.Value.ToString("yyyy-MM-dd HH:mm"));
                MessageBox.Show("Dados inseridos com sucesso no banco de dados!");
                comando.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);

            }
            


        }

        private void Limpar()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                listView.Items.RemoveAt(listView.SelectedIndices[0]);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            dtp_DataeHora.Format = DateTimePickerFormat.Custom;
            dtp_DataeHora.CustomFormat = "dd/MM/yyyy HH:mm";

        }

        private void Service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
