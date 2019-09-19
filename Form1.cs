using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalculatorMahine;

namespace CalculatorWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        */
        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            var cal = new Calculator();
            if (comboBox1.Text=="Penambahan")
            {
                textBox3.Text=cal.Penambahan(a, b).ToString();
            }
            else if (comboBox1.Text == "Pengurangan")
            {
                textBox3.Text = cal.Pengurangan(a, b).ToString();
            }
            else if (comboBox1.Text == "Perkalian")
            {
                textBox3.Text = cal.Perkalian(a, b).ToString();
            }
            else if (comboBox1.Text == "Pembagian")
            {
                textBox3.Text = Calculator.Pembagian(a, b).ToString();
            }
            else if (comboBox1.Text == "Pangkat")
            {
                textBox3.Text = cal.Pangkat(a, b).ToString();
            }
            else if (comboBox1.Text == "Module")
            {
                textBox3.Text = Calculator.Modulo(a, b).ToString();
            }
            else
            {
                textBox3.Text = "Error";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
