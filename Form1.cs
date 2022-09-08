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
                while(streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    if (line.Contains(operatory));
                    /*for(int i =0; i < line.Length; i++)
                    {
                        
                    }*/
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
