using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
namespace morseovka
{
    public partial class Morseovka : Form
    {
        public bool blinkPause;
        public string morseCode;
        public String[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        public String[,] special = { { "?", ",", ".", "!", ";", "=" }, { "..--..", "--..--", ".-.-.-", "--...-", "-.-.-.", "-...-" } };
        public Morseovka()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = txt_decode.Text.ToLower().Replace(" ", "|");
            string coded = "";
            int znak;

            for (int i = 0; i < text.Length; i++)
            {
                znak = Convert.ToInt32(Convert.ToChar(text[i]) - 97);

                if (znak < 26 && znak >= 0)
                {
                    coded += morse[znak] + " ";
                }
                else if (text[i].ToString() == "|")
                {
                    coded += "| ";
                }
            }
            txt_code.Text = coded.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = txt_code.Text.ToLower();
            string decoded = "";
            int kod;
            string[] txt = text.Split(' ');

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i].Equals("|"))
                {
                    decoded += " ";
                }
                for (int a = 0; a < morse.Length; a++)
                {
                    if (morse[a].Equals(txt[i]))
                    {
                        kod = a + 97;
                        decoded += Convert.ToChar(kod);
                    }
                }
            }

            txt_decode.Text = decoded.ToString();
        }

        private void btn_blink_Click(object sender, EventArgs e)
        {
            timerBlink.Start();
            morseCode = txt_code.Text.ToLower();

        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            if (blinkPause)
            {
                blinkPause = false;
                blink.BackColor = Color.Black;
                timerBlink.Interval = 200;
            }
            else if (morseCode.Equals("")) timerBlink.Stop();
            else if (morseCode[0].Equals('.'))
            {
                blink.BackColor = Color.Red;
                timerBlink.Interval = 200;
                morseCode = morseCode.Substring(1);
                blinkPause = true;
            }
            else if (morseCode[0].Equals('-'))
            {
                blink.BackColor = Color.Red;
                timerBlink.Interval = 600;
                morseCode = morseCode.Substring(1);
                blinkPause = true;
            }
            else if (morseCode[0].Equals('|'))
            {
                timerBlink.Interval = 600;
                morseCode = morseCode.Substring(1);
                blinkPause = true;
            }
            else if (morseCode[0].Equals(' '))
            {
                timerBlink.Interval = 800;
                morseCode = morseCode.Substring(1);
                blinkPause = true;
            }
        }
    }
}
