namespace ProjetoMiniERP
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            txbNome = new TextBox();
            txbPreco = new TextBox();
            txbIdF = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            fornecedor = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 119);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Preço :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 170);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 2;
            label3.Text = "ID Fornecedor :";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(75, 72);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(241, 23);
            txbNome.TabIndex = 3;
            // 
            // txbPreco
            // 
            txbPreco.Location = new Point(75, 121);
            txbPreco.Name = "txbPreco";
            txbPreco.Size = new Size(241, 23);
            txbPreco.TabIndex = 4;
            // 
            // txbIdF
            // 
            txbIdF.Location = new Point(127, 168);
            txbIdF.Name = "txbIdF";
            txbIdF.Size = new Size(189, 23);
            txbIdF.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(106, 264);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbPreco);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txbIdF);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 358);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 67);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 0;
            label4.Text = "Nome :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nome, fornecedor, preco });
            dataGridView1.Location = new Point(361, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(413, 259);
            dataGridView1.TabIndex = 8;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.Width = 150;
            // 
            // fornecedor
            // 
            fornecedor.HeaderText = "Fornecedor";
            fornecedor.Name = "fornecedor";
            fornecedor.Width = 150;
            // 
            // preco
            // 
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.Width = 70;
            // 
            // button2
            // 
            button2.Location = new Point(517, 371);
            button2.Name = "button2";
            button2.Size = new Size(120, 29);
            button2.TabIndex = 9;
            button2.Text = "Exibir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txbNome;
        private TextBox txbPreco;
        private TextBox txbIdF;
        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn fornecedor;
        private DataGridViewTextBoxColumn preco;
        private Button button2;
        private PictureBox pictureBox1;
    }
}