using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opertationPerformed = "";
        bool isPerformed= false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox_Result.Text == "0")|| (isPerformed))
            {
                textBox_Result.Clear();
            }
            isPerformed = false;
            Button button = (Button)sender;
            if(button.Text==".")
            {
                if( ! textBox_Result.Text.Contains("."))
                 {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
               
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void opr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultValue!=0)
            {
                button16.PerformClick();
                opertationPerformed = button.Text;
                lableCurrentOperation.Text = resultValue + " " + opertationPerformed;
                isPerformed = true;
            }
            else
            {
                opertationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                lableCurrentOperation.Text = resultValue + " " + opertationPerformed;
                isPerformed = true;
            }
     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(opertationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue= Double.Parse(textBox_Result.Text);
            lableCurrentOperation.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
