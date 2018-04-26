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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form4 tela = new Form4();
            tela.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pergunta4.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                pergunta4.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else
            {
                pergunta4.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                panel3.Visible = false;
                panel4.Visible = true;
            }
            else
            {
                pergunta4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                panel4.Visible = false;
                panel5.Visible = true;
            }
            else
            {
                pergunta4.Visible = true;
            }
        }
    }
    }


