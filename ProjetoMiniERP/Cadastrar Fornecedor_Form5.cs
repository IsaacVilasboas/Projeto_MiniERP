using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new MiniERPContext())
                {
                    Fornecedore f = new Fornecedore();

                    f.Nome = txbNome.Text;
                    f.Cnpj = decimal.Parse(txbCnpj.Text);

                    contexto.Fornecedores.Add(f);
                    contexto.SaveChanges();

                    MessageBox.Show("Fornecedor adicionado!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var contexto = new MiniERPContext())
            {
                List<Fornecedore> forn = contexto.Fornecedores.ToList();

                dataGridView1.Rows.Clear();

                foreach (var f in forn)
                {

                    dataGridView1.Rows.Add(
                        f.Id,
                       f.Nome,
                       f.Cnpj
                       );
                }
            }
        }
    }
}
