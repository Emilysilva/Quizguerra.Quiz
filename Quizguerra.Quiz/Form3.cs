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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

     

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(R1Q1.Checked)
            {
                R1Q1.BackColor = Color.Green;
            }
            pergunta2.Visible = false;
            pergunta1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (R2Q1.Checked)
            {
                R1Q1.BackColor = Color.Green;
            }
            pergunta2.Visible = false;
            Q3.Visible = true;
        }

        private void Q1P1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            if (R1Q1.Checked)
            {
                R1Q1.BackColor = Color.Green;
                pergunta1.Visible = false;
                pergunta2.Visible = true;
            }
            
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            if (R2Q2.Checked)
            {
                R2Q2.BackColor = Color.Green;
                pergunta2.Visible = false;
                pergunta3.Visible = true;
            }
            else
            {
                pergunta2.Visible = false;
                pergunta1.Visible = true;
            }
            
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            if (R2Q3.Checked)
            {
                R2Q3.BackColor = Color.Green;
                pergunta3.Visible = false;
                this.Close();
            }
            else
            {
                pergunta3.Visible = false;
                pergunta1.Visible = true;
            }
            
        }

        private void Q3_Click(object sender, EventArgs e)
        {

        }
    }
}
