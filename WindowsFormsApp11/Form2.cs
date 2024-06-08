using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    using System;
    using System.Net.Mail;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !IsAllLetters(textBox2.Text))
            {
                MessageBox.Show("entrer the corect name ", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("enter the password corcet ", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(textBox4.Text))
            {
                MessageBox.Show("plaeas enter the email (@gmail.com)", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox3.Text, out int age) || age < 0 || age > 120)
            {
                MessageBox.Show("plaeas the enter the age  corect ", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"welcome،{textBox2.Text}!","welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (checkBox1.Checked)
            {

                Form3 form3 = new Form3();
                form3.ShowDialog();

            }
            else if (checkBox2.Checked)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();


            }
            else
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
            }


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

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}