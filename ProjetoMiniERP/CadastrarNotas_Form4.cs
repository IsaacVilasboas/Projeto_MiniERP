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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (var contexto = new MiniERPContext())
                {
                    int ClienteID = int.Parse(txbIdC.Text);
                    int ProdutoID = int.Parse(txbIdP.Text);

                    var c = contexto.Clientes.FirstOrDefault(c => c.Id == ClienteID);
                    var p = contexto.Produtos.FirstOrDefault(p => p.Id == ProdutoID);

                    Nota n = new Nota
                    {
                        FkClientes = ClienteID,
                        Nome_Cliente = c.Nome,
                        FkProdutos = ProdutoID,
                        Nome_Produto = p.Nome,
                        preco = p.Preco,

                    };

                    contexto.Notas.Add(n);
                    contexto.SaveChanges();
                    MessageBox.Show("Nota Cadastrada!", "Sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a nota", "Erro");
            }
        }
    }
}
