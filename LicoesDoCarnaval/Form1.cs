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

            estado_civil.Items.Add("Solteiro(a)");
            estado_civil.Items.Add("Casado(a)");
            estado_civil.Items.Add("Divorciado(a)");
            estado_civil.Items.Add("Viúvo(a)");

            estado_civil.SelectedIndex = 0;

            string[] adicionais = { "Cebola", "Bacon", "Cheddar", "Picles" };
            checkedListBox1.Items.AddRange(adicionais);

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

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(senha.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if (login.Text == "admin" && senha.Text == "1234")
            {
                MessageBox.Show("Login bem sucedido");
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos");
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cad_email.Text) && !string.IsNullOrEmpty(cad_nome.Text) && !string.IsNullOrEmpty(cad_idade.Text) && !string.IsNullOrEmpty(cad_end.Text) && !string.IsNullOrEmpty(cad_tel.Text))
            {
                MessageBox.Show($"Cadastro realizado com sucesso!\nNome: {cad_nome.Text}\nEmail: {cad_email.Text}\nIdade: {cad_idade.Text}\nEstado Civil: {estado_civil.SelectedItem}\nEndereço: {cad_end.Text}\nTelefone: {cad_tel.Text}");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para realizar o cadastro.");
            }
        }

        private void cad_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void cad_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void cad_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void cad_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void cad_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void lanche_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmar_ped_Click(object sender, EventArgs e)
        {         
            string pedido = "Lanche escolhido: " + lanche.Text + "\n\n";
                       pedido += "Adicionais:\n";

            foreach (var item in checkedListBox1.CheckedItems)
            {
                pedido += "- " + item.ToString() + "\n";
            }

            MessageBox.Show(pedido);
        }
    }
}
