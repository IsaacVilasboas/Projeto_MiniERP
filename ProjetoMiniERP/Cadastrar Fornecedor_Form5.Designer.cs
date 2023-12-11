namespace ProjetoMiniERP
{
    partial class Form5
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            txbCnpj = new TextBox();
            txbNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(119, 234);
            button1.Name = "button1";
            button1.Size = new Size(123, 28);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbCnpj);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 299);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Fornecedor";
            // 
            // txbCnpj
            // 
            txbCnpj.Location = new Point(104, 146);
            txbCnpj.Name = "txbCnpj";
            txbCnpj.Size = new Size(211, 23);
            txbCnpj.TabIndex = 4;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(104, 64);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(211, 23);
            txbNome.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 57);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 2;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 139);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 3;
            label2.Text = "CNPJ :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, cnpj });
            dataGridView1.Location = new Point(394, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(373, 250);
            dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            id.HeaderText = "N°";
            id.Name = "id";
            id.Width = 30;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.Width = 150;
            // 
            // cnpj
            // 
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            cnpj.Width = 150;
            // 
            // button2
            // 
            button2.Location = new Point(513, 337);
            button2.Name = "button2";
            button2.Size = new Size(123, 28);
            button2.TabIndex = 3;
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
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private TextBox txbCnpj;
        private TextBox txbNome;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cnpj;
        private PictureBox pictureBox1;
    }
}