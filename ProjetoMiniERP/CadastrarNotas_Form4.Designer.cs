namespace ProjetoMiniERP
{
    partial class Form4
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
            label3 = new Label();
            label4 = new Label();
            txbIdC = new TextBox();
            txbIdP = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(103, 287);
            button1.Name = "button1";
            button1.Size = new Size(132, 34);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 198);
            label3.Name = "label3";
            label3.Size = new Size(125, 30);
            label3.TabIndex = 2;
            label3.Text = "ID Produto :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(115, 30);
            label4.TabIndex = 2;
            label4.Text = "ID Cliente :";
            // 
            // txbIdC
            // 
            txbIdC.Location = new Point(124, 113);
            txbIdC.Name = "txbIdC";
            txbIdC.Size = new Size(180, 23);
            txbIdC.TabIndex = 3;
            // 
            // txbIdP
            // 
            txbIdP.Location = new Point(124, 205);
            txbIdP.Name = "txbIdP";
            txbIdP.Size = new Size(180, 23);
            txbIdP.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txbIdP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbIdC);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(229, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 395);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Notas";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox txbIdC;
        private TextBox txbIdP;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}