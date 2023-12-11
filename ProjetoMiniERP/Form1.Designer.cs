namespace ProjetoMiniERP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(276, 199);
            button2.Name = "button2";
            button2.Size = new Size(193, 36);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar Produto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(276, 148);
            button3.Name = "button3";
            button3.Size = new Size(193, 36);
            button3.TabIndex = 2;
            button3.Text = "Cadastrar Clientes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(82, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 62);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 4;
            label6.Text = "NOME C/F :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(81, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 23);
            textBox5.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 165);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 5;
            label7.Text = "CPF/CNPJ :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 29);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 6;
            label8.Text = "ID Cliente :";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(276, 97);
            button1.Name = "button1";
            button1.Size = new Size(193, 36);
            button1.TabIndex = 12;
            button1.Text = "Cadastrar Fornecedor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(276, 250);
            button4.Name = "button4";
            button4.Size = new Size(193, 36);
            button4.TabIndex = 3;
            button4.Text = "Cadastrar Nota";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(276, 302);
            button5.Name = "button5";
            button5.Size = new Size(193, 36);
            button5.TabIndex = 13;
            button5.Text = "Exibir Notas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
    }
}