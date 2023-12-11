using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMiniERP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (var contexto = new MiniERPContext())
                {
                    Cliente c = new Cliente();

                    c.Nome = txbNome.Text;

                    c.Cpf = decimal.Parse(txbCpf.Text);

                    contexto.Clientes.Add(c);
                    contexto.SaveChanges();

                    MessageBox.Show("Cliente adicionado!", "Sucesso");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar o cliente", "Erro");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var contexto = new MiniERPContext())
            {

                List<Cliente> list = contexto.Clientes.ToList();

                dataGridView1.Rows.Clear();
                foreach (var n in list)
                {

                    dataGridView1.Rows.Add(
                        n.Id,
                       n.Nome,
                       n.Cpf);
                }
            }
        }
    }
}
