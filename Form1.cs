using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtWord1.Text = Properties.Settings.Default.word1;
            txtWord2.Text = Properties.Settings.Default.word2;
        }

        public class Logic
        {
            public static string Comp(string word1, string word2)
            {
                string nrword1 = "";
                for (int i = 0; i < word1.Length; i++)
                {
                    if (nrword1.IndexOf(word1[i]) == -1)
                    {
                        nrword1 = nrword1 + word1[i];
                    }
                }
                string result = "";
                for (int i = 0; i < nrword1.Length; i++)
                {
                    if (word2.IndexOf(nrword1[i]) == -1)
                    {
                        result = result + "нет ";
                    }
                    else
                    {
                        result = result + "да ";
                    }
                }
                return result;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (txtWord1.Text!=String.Empty && txtWord2.Text!=String.Empty)
            {
              txtResult.Text=(Logic.Comp(txtWord1.Text, txtWord2.Text));
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            Properties.Settings.Default.word1 = txtWord1.Text;
            Properties.Settings.Default.word2 = txtWord2.Text;
            Properties.Settings.Default.Save();
        }
    }
}
