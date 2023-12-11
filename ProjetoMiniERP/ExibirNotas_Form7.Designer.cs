namespace ProjetoMiniERP
{
    partial class Form7
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
            dataGridView1 = new DataGridView();
            FkClientes = new DataGridViewTextBoxColumn();
            Nome_Clientes = new DataGridViewTextBoxColumn();
            Nome_Produto = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FkClientes, Nome_Clientes, Nome_Produto, preco });
            dataGridView1.Location = new Point(183, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(441, 307);
            dataGridView1.TabIndex = 16;
            // 
            // FkClientes
            // 
            FkClientes.HeaderText = "ID Clientes";
            FkClientes.Name = "FkClientes";
            // 
            // Nome_Clientes
            // 
            Nome_Clientes.HeaderText = "Cliente";
            Nome_Clientes.Name = "Nome_Clientes";
            // 
            // Nome_Produto
            // 
            Nome_Produto.HeaderText = "Produto";
            Nome_Produto.Name = "Nome_Produto";
            // 
            // preco
            // 
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            // 
            // button1
            // 
            button1.Location = new Point(183, 384);
            button1.Name = "button1";
            button1.Size = new Size(100, 28);
            button1.TabIndex = 17;
            button1.Text = "Exibir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(523, 384);
            button2.Name = "button2";
            button2.Size = new Size(101, 28);
            button2.TabIndex = 18;
            button2.Text = "Gerar Pdf";
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
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FkClientes;
        private DataGridViewTextBoxColumn Nome_Clientes;
        private DataGridViewTextBoxColumn Nome_Produto;
        private DataGridViewTextBoxColumn preco;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}