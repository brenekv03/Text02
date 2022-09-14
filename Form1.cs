using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                int pcVelkych = 0;
                int pcMalych = 0;
                int pcCifer = 0;
                int pcAritOpe = 0;
                int jinZnak = 0;
                string operatory = "+-*/";
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                while(!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    foreach(char c in line)
                    {
                        if (char.IsUpper(c)) pcVelkych++;
                        else if (char.IsLower(c)) pcMalych++;
                        else if (char.IsDigit(c)) pcCifer++;
                        else if (operatory.Contains(c.ToString())) pcAritOpe++;
                        else jinZnak++;
                    }
                }
                MessageBox.Show("Počet velkých: " + pcVelkych + "\nPočet malých: " + pcMalych + "\nPočet cifer: " + pcCifer + "\nPočet operátorů: " + pcAritOpe + "\nPočet ostatních: " + jinZnak);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
