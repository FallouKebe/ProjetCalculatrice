using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCalculatrice
{
    public partial class frmCalculatrice : Form
    {
        public frmCalculatrice()
        {
            InitializeComponent();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            textBox_result.Clear();

        }

        private void guna2CircleButton15_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '1';
        }

        private void guna2CircleButton16_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '2';
        }

        private void guna2CircleButton17_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '3';
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '6';
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '4';
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '5';
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '7';
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '8';
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '9';
        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_result.Text))
            {
                double number = double.Parse(textBox_result.Text);
                // Inverser le signe
                number = -number;
                // Mettre à jour le textbox
                textBox_result.Text = number.ToString();
            }
        }

        private void guna2CircleButton18_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '0';
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox_result.Text;

                // Vérifier si un opérateur existe dans l'entrée
                if (input.Contains("+"))
                {
                    string[] numbers = input.Split('+');
                    double num1 = double.Parse(numbers[0]);
                    double num2 = double.Parse(numbers[1]);
                    double result = num1 + num2;
                    textBox_result.Text = result.ToString();
                }
                else if (input.Contains("-"))
                {
                    string[] numbers = input.Split('-');
                    double num1 = double.Parse(numbers[0]);
                    double num2 = double.Parse(numbers[1]);
                    double result = num1 - num2;
                    textBox_result.Text = result.ToString();
                }
                else if (input.Contains("×"))
                {
                    string[] numbers = input.Split('×');
                    double num1 = double.Parse(numbers[0]);
                    double num2 = double.Parse(numbers[1]);
                    double result = num1 * num2;
                    textBox_result.Text = result.ToString();
                }
                else if (input.Contains("÷"))
                {
                    string[] numbers = input.Split('÷');
                    double num1 = double.Parse(numbers[0]);
                    double num2 = double.Parse(numbers[1]);

                    if (num2 == 0) // Vérification de division par zéro
                    {
                        textBox_result.Text = "Erreur : Division par zéro";
                        return;
                    }

                    double result = num1 / num2;
                    textBox_result.Text = result.ToString();
                }
                else
                {
                    // Si aucun opérateur n'est trouvé, afficher l'entrée telle quelle
                    textBox_result.Text = input;
                }
            }
            catch (Exception)
            {
                // Gérer les erreurs (par exemple, une saisie incorrecte)
                textBox_result.Text = "Erreur";
            }
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '÷';
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '×';
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '-';
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            textBox_result.Text += '+';
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_result.Text))
            {
                double number = double.Parse(textBox_result.Text);
                // calcule le modulo
                number = number/100;
                // Mettre à jour le textbox
                textBox_result.Text = number.ToString();
            }
        }

        private void frmCalculatrice_Load(object sender, EventArgs e)
        {

        }
    }
}
