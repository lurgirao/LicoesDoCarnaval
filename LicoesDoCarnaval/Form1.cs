using System.Windows.Forms;

namespace LicoesDoCarnaval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENVIAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo (a) " + textBox1.Text + "!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O resultado da soma é: {int.Parse(textBox2.Text) + int.Parse(textBox3.Text)}");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O resultado da operação é: {comboBox1.Text switch
            {
                "+" => int.Parse(textBox4.Text) + int.Parse(textBox5.Text),
                "-" => int.Parse(textBox4.Text) - int.Parse(textBox5.Text),
                "*" => int.Parse(textBox4.Text) * int.Parse(textBox5.Text),
                "/" => int.Parse(textBox4.Text) / int.Parse(textBox5.Text),
                _ => 0
            }}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add('+');
            comboBox1.Items.Add('-');
            comboBox1.Items.Add('*');
            comboBox1.Items.Add('/');

            comboBox1.SelectedIndex = 0;
        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idade;
            if (!int.TryParse(txt_idade.Text, out idade))
            {
                MessageBox.Show("DIGITE APENAS NÚMEROS");
            }
            else if (idade < 18)
            {
                MessageBox.Show("Você é menor de idade");
            }
            else
            { 
                MessageBox.Show("Você é maior de idade");
            }
        }
    }
}
