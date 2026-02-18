namespace LicoesDoCarnaval
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
            label1 = new Label();
            textBox1 = new TextBox();
            ENVIAR = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            txt_idade = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 19);
            label1.TabIndex = 0;
            label1.Text = "1. Escreva seu nome";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ENVIAR
            // 
            ENVIAR.BackColor = SystemColors.ActiveCaption;
            ENVIAR.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ENVIAR.Location = new Point(159, 31);
            ENVIAR.Name = "ENVIAR";
            ENVIAR.Size = new Size(75, 23);
            ENVIAR.TabIndex = 2;
            ENVIAR.Text = "ENVIAR";
            ENVIAR.UseVisualStyleBackColor = false;
            ENVIAR.Click += ENVIAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 77);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 3;
            label2.Text = "2. Soma";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(7, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(66, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 99);
            label3.Name = "label3";
            label3.Size = new Size(18, 19);
            label3.TabIndex = 5;
            label3.Text = "+";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(65, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(174, 99);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "RESULTADO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 144);
            label4.Name = "label4";
            label4.Size = new Size(204, 19);
            label4.TabIndex = 8;
            label4.Text = "3. Operadores aritmeticos";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(66, 23);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(131, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(67, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(41, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(225, 166);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "RESPOSTA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1, 206);
            label5.Name = "label5";
            label5.Size = new Size(308, 19);
            label5.TabIndex = 13;
            label5.Text = "4. Verificador de Idade (coloque abaixo)";
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(15, 234);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(100, 23);
            txt_idade.TabIndex = 14;
            txt_idade.TextChanged += txt_idade_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(123, 234);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "CHECAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 779);
            Controls.Add(button3);
            Controls.Add(txt_idade);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(ENVIAR);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "LICOESCARNAVAL";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button ENVIAR;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Button button2;
        private Label label5;
        private TextBox txt_idade;
        private Button button3;
    }
}
