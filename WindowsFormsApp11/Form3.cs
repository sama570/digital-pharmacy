using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !IsAllLetters(textBox2.Text))
            {
                MessageBox.Show("entrer the corect name ", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            


            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("enter the password corcet ", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("enter the Specialization","wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            MessageBox.Show($"welcome،{textBox2.Text}!", "welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool IsAllLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
