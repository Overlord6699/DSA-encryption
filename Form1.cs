using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace TILab4
{
    public partial class Form1 : Form
    {
        BigInteger q, p, k, x, h;

        byte[] input;
        string message;

        bool openedFromFile = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearOutput()
        {
            RTextBox.Text = "";
            STextBox.Text = "";
            HashTextBox.Text = "";
        }

        private void Sign()
        {
            if (Signer.Sign(input, q, p, k, x, h, out BigInteger r, out BigInteger s))
            {
                var hash = Hash.GetHash(input, q);

                OutputResult(hash, r, s);

                MessageTextBox.Text += "," + r.ToString() + "," + s.ToString();
            }
            else
            {
                MessageBox.Show("R или S равно 0. Перепишите значение k.");
            }
        }

        private string GetSignatureFromFile(string msg, out BigInteger r, out BigInteger s)
        {
            r = 0;
            s = 0;

            string rStr = "";
            string sStr = "";

            int zapNumber = 0;
            int index = msg.Length - 1;

            //должно быть 2 запятые
            while (index > 0 && zapNumber < 2)
            {
                if (zapNumber == 0)
                {
                    //чтение s
                    sStr = msg[index] + sStr;
                    index--;

                    if (msg[index] == ',')
                    {
                        zapNumber++;
                        index--;
                    }
                }

                if (zapNumber == 1)
                {
                    //чтение r
                    rStr = msg[index] + rStr;
                    index--;

                    if (msg[index] == ',')
                    {
                        zapNumber++;
                    }
                }
            }

            if (zapNumber < 2)
            {
                throw new ArgumentException("Некорректная запись подписи.");
            }
            if(!BigInteger.TryParse(rStr, out r))
            {
                throw new ArgumentException("Некорректное значение r.");
            }
            if(!BigInteger.TryParse(sStr, out s))
            {
                throw new ArgumentException("Некорректное значение s.");
            }

            //нужно передать только сообщение
            return msg.Substring(0, index);
        }

        private void Check()
        {
            BigInteger r;
            BigInteger s;

            try
            {
                message = GetSignatureFromFile(message, out r, out s);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            input = Encoding.ASCII.GetBytes(message);

            BigInteger hash = Hash.GetHash(input,q);

            OutputResult(hash, r, s);

            string result;
            if (Signer.CheckSign(input, r, s, q, p, h, x,
                out BigInteger v, out BigInteger w, out BigInteger u1, out BigInteger u2))
            {
                result = "Подпись верна";
            }
            else
            {
                result = "Подпись неверна";
            }

            MessageBox.Show($"Результат:\nr = {r}\nv = {v}\nВывод: {result}");
        }

        private bool CheckFilledFields(in bool sign)
        {
            if (QTextBox.Text == "" || PTextBox.Text == "" ||
               XTextBox.Text == "")
            {
                MessageBox.Show("Нужно заполнить все обязательные поля!");

                return false;
            }

            if (sign && KTextBox.Text == "")
            {
                MessageBox.Show("Нужно заполнить k!");

                return false;
            }

            return true;
        }

        private void OutputResult(in BigInteger hash, in BigInteger r, in BigInteger s)
        {
            RTextBox.Text = r.ToString();
            STextBox.Text = s.ToString();
            HashTextBox.Text = hash.ToString();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string path = openFileDialog1.FileName;
                /*
                input = File.ReadAllBytes(path);            
                string msg = Encoding.UTF8.GetString(input);
                */

                StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251));
                string msg = sr.ReadToEnd();
                sr.Close();

                input = Encoding.ASCII.GetBytes(msg);

                MessageTextBox.Text = msg;

                ProcessButton.Enabled = false;
                openedFromFile = true;
            }
        }

        private void GetMessage()
        {
            message = MessageTextBox.Text;
            input = Encoding.ASCII.GetBytes(message);
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (SignRB.Checked)
            {
                Sign();
            }
            else
            {
                Check();
            }

            ProcessButton.Enabled = false;
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string path = saveFileDialog1.FileName;

                StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding(1251));
                sw.Write(MessageTextBox.Text);
                sw.Close();

                //File.WriteAllText(path,MessageTextBox.Text);           
            }
        }

        private void QTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessButton.Enabled = false;
        }

        private void PTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessButton.Enabled = false;
        }

        private void HTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessButton.Enabled = false;
        }

        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessButton.Enabled = false;
        }

        private void KTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessButton.Enabled = false;
        }

        private void CheckRB_CheckedChanged(object sender, EventArgs e)
        {
            KTextBox.Enabled = false;
        }

        private void SignRB_CheckedChanged(object sender, EventArgs e)
        {
            KTextBox.Enabled = true;
        }

        private bool CheckFields(in bool sign)
        {
            bool isCorrect = true;

            if (!ValuesChecker.CheckQ(QTextBox.Text))
            {
                MessageBox.Show("Q должно быть простым.");
                isCorrect = false;
            }

            if (!ValuesChecker.CheckP(QTextBox.Text, PTextBox.Text))
            {
                MessageBox.Show("P должно быть простым и должно выполняться:\n (p - 1) mod q = 0");
                isCorrect = false;
            }
            
            if (!ValuesChecker.CheckH(QTextBox.Text, PTextBox.Text, HTextBox.Text))
            {
                MessageBox.Show("H должно быть в диапазоне [2; p - 2], являться простым и  должно выполняться:\n" +
                    "h ^ ((p - 1) / q) mod p > 1.\n g > 1");
                isCorrect = false;
            }

            if (!ValuesChecker.CheckInterval(1, q-1,
                x))
            {
                MessageBox.Show("X должно попадать в  [1; q-1]");
                isCorrect = false;
            }

            if (sign && !ValuesChecker.CheckInterval(1, q-1,
                k))
            {
                MessageBox.Show("K должно попадать в [1; q-1]");
                isCorrect = false;
            }

            return isCorrect;
        }

        private bool ReadValues()
        {
            if ((q = ValuesChecker.TryParseValue(QTextBox.Text)) == -1)
            {
                MessageBox.Show("Некорректный ввод q");
                return false;
            }
            if ((p = ValuesChecker.TryParseValue(PTextBox.Text)) == -1)
            {
                MessageBox.Show("Некорректный ввод p");
                return false;
            }
            if ((x = ValuesChecker.TryParseValue(XTextBox.Text)) == -1)
            {
                MessageBox.Show("Некорректный ввод x");
                return false;
            }
            if ((h = ValuesChecker.TryParseValue(HTextBox.Text)) == -1)
            {
                MessageBox.Show("Некорректный ввод h");
                return false;
            }

            return true;
        }

        private void InputButton_Click(object sender, EventArgs e)
        {

            if (!ReadValues())
                return;

            if (SignRB.Checked)
            {
                if ((k = ValuesChecker.TryParseValue(KTextBox.Text)) == -1)
                {
                    MessageBox.Show("Некорректный ввод k");
                    return;
                }

                if (!CheckFilledFields(true))
                    return;
                if (!CheckFields(true))
                    return; 
            }
            else
            {
                if (!CheckFilledFields(false))
                    return;
                if (!CheckFields(false))
                    return;
            }          

            //if (!openedFromFile)
            GetMessage();

            //openedFromFile = false;

            HashTextBox.Text = Hash.GetHash(input, q).ToString();

            MessageBox.Show("Ввод выполнен корректно");
            ProcessButton.Enabled = true;
        }
    }
}
