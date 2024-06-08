using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp11
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {



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
            MessageBox.Show($"welcome،{textBox4.Text}", "welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (checkBox1.Checked) {

                Form3 form3 = new Form3();
                form3.ShowDialog();
            
           }
         else if (checkBox2.Checked) {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
