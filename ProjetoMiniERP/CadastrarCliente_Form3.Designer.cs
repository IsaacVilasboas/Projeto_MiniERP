namespace ProjetoMiniERP
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            txbCpf = new TextBox();
            txbNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbCpf);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Clientes";
            // 
            // txbCpf
            // 
            txbCpf.Location = new Point(92, 199);
            txbCpf.Name = "txbCpf";
            txbCpf.Size = new Size(259, 23);
            txbCpf.TabIndex = 3;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(92, 92);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(259, 23);
            txbNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 192);
            label2.Name = "label2";
            label2.Size = new Size(53, 30);
            label2.TabIndex = 1;
            label2.Text = "CPF:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 85);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 1;
            label1.Text = "Nome :";
            // 
            // button1
            // 
            button1.Location = new Point(140, 271);
            button1.Name = "button1";
            button1.Size = new Size(107, 27);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, cpf });
            dataGridView1.Location = new Point(421, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(342, 268);
            dataGridView1.TabIndex = 1;
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
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            cpf.Width = 150;
            // 
            // button2
            // 
            button2.Location = new Point(547, 346);
            button2.Name = "button2";
            button2.Size = new Size(107, 27);
            button2.TabIndex = 2;
            button2.Text = "Exibir Clientes";
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
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txbCpf;
        private TextBox txbNome;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private PictureBox pictureBox1;
    }
}