using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palindrome_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtword.Clear();
        }

        private void btnmth1_Click(object sender, EventArgs e)
        {
            //this method is 1 (1)
            
            if (txtword.Text != "")
            {

                string word = txtword.Text;
                string reverswword = "";
                for (int i = word.Length - 1  ; i >= 0; i--)
                {
                    //this line is different
                    reverswword += word[i];

                }
                if (word == reverswword)
                {
                    MessageBox.Show("your input word is palindrome");
                }
                else
                {
                    MessageBox.Show("your input word is not palindrome");
                }
            }
            else
            {
                MessageBox.Show("ENTER A WORD");
            }
        }


        private void btnmth1_2_Click(object sender, EventArgs e)
        {
            //this method is 1 (2) (using substring)

            if (txtword.Text != "")
            {

                string word = txtword.Text;
                string reverswword = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    //this line is different
                    reverswword += word.Substring(i,1);

                }

                if(word == reverswword)
                {
                    MessageBox.Show("your input word is palindrome");
                }

                else
                {
                    MessageBox.Show("your input word is not palindrome");
                }

            }
            else
            {
                MessageBox.Show("ENTER A WORD");
            }

        }

        private void btnmth2_Click(object sender, EventArgs e)
        {
            //this method is 2 (1) 

            if (txtword.Text != "")
            {
                string word = txtword.Text;
               char[] c = word.ToCharArray();
                Array.Reverse(c);

                //this line is different
                string reverseword =new string(c);

                if (reverseword == word) 
                {
                    MessageBox.Show("your input word is palindrome");
                }

                else
                {
                    MessageBox.Show("your input word is not palindrome");
                }

            }
            else
            {
                MessageBox.Show("ENTER A WORD");
            }
        }

        private void btnmth2_2_Click(object sender, EventArgs e)
        {
            //this method is 2 (2) (using foreach) 

            if (txtword.Text != "")
            {
                string word = txtword.Text;
                char[] c = word.ToCharArray();
                Array.Reverse(c);

                //this line is different
                string reverseword = "";

                foreach(char ch in c)
                {
                    reverseword += ch.ToString();
                }

                if (reverseword == word)
                {
                    MessageBox.Show("your input word is palindrome");
                }

                else
                {
                    MessageBox.Show("your input word is not palindrome");
                }

            }
            else
            {
                MessageBox.Show("ENTER A WORD");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
