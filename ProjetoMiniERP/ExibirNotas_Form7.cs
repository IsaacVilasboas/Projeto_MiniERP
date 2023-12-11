using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;
using Document = iText.Layout.Document;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Counter.Context;

namespace ProjetoMiniERP
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new MiniERPContext())
                {
                    // Recuperar todas as notas do banco de dados
                    List<Nota> listaNotas = contexto.Notas.ToList();

                    // Limpar o DataGridView
                    dataGridView1.Rows.Clear();

                    // Preencher o DataGridView com as notas
                    foreach (var nota in listaNotas)
                    {
                        // Adicionar uma nova linha ao DataGridView com os dados da nota
                        dataGridView1.Rows.Add(
                            nota.FkClientes,
                            nota.Nome_Cliente,
                            nota.Nome_Produto,
                            nota.preco
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GerarPDF();
        }
        private void GerarPDF()
        {
            try
            {
                // Local onde o arquivo pdf vai ser gerado.
                var arquivo = @"D:\.net\ProjetoMiniERP\Notas.pdf";

                using (var contexto = new MiniERPContext())
                {

                    List<Nota> listaNotas = contexto.Notas.ToList();

                    using (var wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
                    {
                        var pdfDocumento = new PdfDocument(wPdf);
                        var document = new Document(pdfDocumento);


                        // Criar uma tabela
                        Table tabela = new Table(new float[] { 15, 40, 40, 10 }).UseAllAvailableWidth();

                        // Adicionar títulos das colunas à tabela
                        tabela.AddHeaderCell(new Cell().Add(new Paragraph("ID Cliente")));
                        tabela.AddHeaderCell(new Cell().Add(new Paragraph("Cliente")));
                        tabela.AddHeaderCell(new Cell().Add(new Paragraph("Produto")));
                        tabela.AddHeaderCell(new Cell().Add(new Paragraph("Preço")));

                        // Adicionando dados do objeto Nota à tabela
                        foreach (var nota in listaNotas)
                        {
                            tabela.AddCell(new Cell().Add(new Paragraph(nota.FkClientes?.ToString() ?? "")));
                            tabela.AddCell(new Cell().Add(new Paragraph(nota.Nome_Cliente ?? "")));
                            tabela.AddCell(new Cell().Add(new Paragraph(nota.Nome_Produto ?? "")));
                            tabela.AddCell(new Cell().Add(new Paragraph(nota.preco?.ToString() ?? "")));
                        }

                        // Adicionando tabela ao documento
                        document.Add(tabela);

                        document.Close();

                        MessageBox.Show(" Arquivo Pdf gerado com sucesso!" +
                            "\n " + arquivo, "Sucesso");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o PDF: ", "Erro");
            }
        }
    }
}