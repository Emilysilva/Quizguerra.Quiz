using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizguerra.Quiz
{
    public partial class Form4 : Form
    {
        private int pro;

        public Form4()
        {
            InitializeComponent();
            pro = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pro == 0)
            {
                barra.Value = 20;
                pro = 20;
            }
            else if (pro == 20)
            {
                barra.Value = 40;
                pro = 40;
            }
            else if (pro == 40)
            {
                barra.Value = 60;
                pro = 60;
            }
            else if (pro == 60)
            {
                barra.Value = 80;
                pro = 80;
            }
            else if (pro == 80)
            {
                barra.Value = 100;
                pro = 100;
            }
            else if (pro == 100)
            {
                this.Close();
                Form3 questoes = new Form3();
                questoes.ShowDialog();
            }

        }

        private void barra_Click(object sender, EventArgs e)
        {

        }
    }
}
