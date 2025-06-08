using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            String[] ch = new String[3];
            ch[0] = Nome_cliente.Text;
            ch[1] = Service.Text;
            ch[2] = dtp_DataeHora.Text;

            ListViewItem l = new ListViewItem(ch);   
            listView.Items.Add(l);
            Limpar();
        }

        private void Limpar()
        {
            Nome_cliente.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                listView.Items.RemoveAt(listView.SelectedIndices[0]);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Configurando o DateTimePicker para exibir data e hora
            dtp_DataeHora.Format = DateTimePickerFormat.Custom;
            dtp_DataeHora.CustomFormat = "dd/MM/yyyy HH:mm";

        }
    }
}
