using Microsoft.EntityFrameworkCore;

namespace ProjetoMiniERP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        //Cadastro de notas
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        //Cadastro de Clientes
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();

        }
        //Cadastro de Produtos
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        //Cadastro de Fornecedor
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }

        //Exibir Notas
        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.ShowDialog();
        }
    }
}