using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyoukaiNoAngou
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

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] bax = new byte[50];
            int ctr = 0;

            bool firstword = true;

            string input = InputBox.Text;

            string[] words = input.Split(' ');

            OutputBox.Text = "";

            foreach (string word in words)
            { 
                byte[] asciiBytes = Encoding.ASCII.GetBytes(word);

                ctr = 0;

                foreach (byte box in asciiBytes)
                {
                    string trf = box.ToString();
                    int handler = int.Parse(trf);

                    if(handler > 96 && handler < 120)
                    {
                        handler = handler + 3;
                    }
                    else
                    {
                        handler = handler - 23;
                    }

                    trf = handler.ToString();

                    bax[ctr] = Byte.Parse(trf);
                    ctr += 1;
                }

                string handler2 = Encoding.ASCII.GetString(bax);

                for (int i = 0; i < bax.Length; i++)
                {
                    bax[i] = 0;
                }

                if (firstword == false)
                    OutputBox.Text += " ";

                OutputBox.Text += handler2;

                firstword = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bax = new byte[50];
            int ctr = 0;

            bool firstword = true;

            string input = InputBox.Text;

            string[] words = input.Split(' ');

            OutputBox.Text = "";

            foreach (string word in words)
            {
                byte[] asciiBytes = Encoding.ASCII.GetBytes(word);

                ctr = 0;

                foreach (byte box in asciiBytes)
                {
                    string trf = box.ToString();
                    int handler = int.Parse(trf);

                    if (handler > 99)
                    {
                        handler = handler - 3;
                    }
                    else
                    {
                        handler = handler + 23;
                    }

                    trf = handler.ToString();

                    bax[ctr] = Byte.Parse(trf);
                    ctr += 1;
                }

                string handler2 = Encoding.ASCII.GetString(bax);

                for (int i = 0; i < bax.Length; i++)
                {
                    bax[i] = 0;
                }

                if(firstword == false)
                    OutputBox.Text += " ";

                OutputBox.Text += handler2;

                firstword = false;
            }
        }
    }
}
