using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMiniERP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        //Cadastro de Produto
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new MiniERPContext())
                {


                    Produto p = new Produto();

                    p.Nome = txbNome.Text;
                    p.Preco = int.Parse(txbPreco.Text);
                    p.FkFornecedores = int.Parse(txbIdF.Text);


                    contexto.Produtos.Add(p);
                    contexto.SaveChanges();

                    MessageBox.Show("Produto adicionado!", "Sucesso");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar o produto", "Erro");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (var contexto = new MiniERPContext())
            {
                dataGridView1.Rows.Clear();


                var pf = contexto.Produtos
                     .Include(p => p.FkFornecedoresNavigation)
                        .Select(p => new
                        {
                            ProdutoId = p.Id,
                            NomeProduto = p.Nome,
                            preco = p.Preco,
                            NomeFornecedor = p.FkFornecedoresNavigation.Nome
                        })
                         .ToList();

                foreach (var n in pf)
                {
                     //Adicionando as informações do produto ao dataGridView
                    dataGridView1.Rows.Add(
                    
                       n.NomeProduto,
                       n.NomeFornecedor,
                       n.preco);
                }



            }
        }
    }

}
