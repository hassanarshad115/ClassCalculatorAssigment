using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCalculatorAssigment
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Developer Hassan Arshad
        /// Student of MCS in IUB 
        /// Mobile: 0334-9055786
        /// </summary>
        

        //operation k lye veriables declare krny ha r initialize b
        private double firstNumber = 0.0;
        private double secondNumber = 0.0;
        private string operation = "";
        private double result = 0.0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RemoveZero(4);
        }

        private void zerobutton_Click(object sender, EventArgs e)
        {
            textBox1.Text  += "0";
        }

        private void onebutton4_Click(object sender, EventArgs e)
        {
            RemoveZero(1);
        }

        /// <summary>
        /// 0 to 9 tk jtny b button ha usmy ye method add krna ha
        /// its code for all 0 to 9
        /// </summary>
        /// <param name="number"></param>
        private void RemoveZero(int number)
        {
            if (textBox1.Text == "0")
                textBox1.Text = number.ToString();
            else
                textBox1.Text += number.ToString();
        }

        private void twobutton_Click(object sender, EventArgs e)
        {
            RemoveZero(2);
        }

        private void threebutton6_Click(object sender, EventArgs e)
        {
            RemoveZero(3);
        }

        private void fivebutton_Click(object sender, EventArgs e)
        {
            RemoveZero(5);
        }

        private void sixbutton_Click(object sender, EventArgs e)
        {
            RemoveZero(6);
        }

        private void sevenbutton_Click(object sender, EventArgs e)
        {
            RemoveZero(7);
        }

        private void eightbutton_Click(object sender, EventArgs e)
        {
            RemoveZero(8);
        }

        private void ninebutton_Click(object sender, EventArgs e)
        {
            RemoveZero(9);
        }

        private void Cebutton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        /// <summary>
        /// dot jst ak br ay r agr phly aya ha ha to again na ay
        /// islye !not k sath lgaya ha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dotbutton3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(".")) // agr dot phly he include ha to ye again include ni kryga
                textBox1.Text += ".";
        }



        private void multibutton_Click(object sender, EventArgs e)
        {
            operation = "*";

            FirstNumberKoValueJayOperationSyPhlyWali();
        }


        //its code for firstNubmer jo k ktextbox ma phly chose krna ha
        private void FirstNumberKoValueJayOperationSyPhlyWali()
        {
            firstNumber = Convert.ToDouble(textBox1.Text); // textbox ma jo b value ay phly wo firstnumber ma chli jay
             textBox1.Text = "0";
        }

        /// <summary>
        /// all operation ma operation ko asl value asign krni ha
        /// firstNumber ko vlaue dni ha jo k textbox ma ho
        /// ye value phly he dni ha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minusbutton_Click(object sender, EventArgs e)
        {
            operation = "-";
            FirstNumberKoValueJayOperationSyPhlyWali();
        }

        private void percentbutton_Click(object sender, EventArgs e)
        {
            operation = "%";
            FirstNumberKoValueJayOperationSyPhlyWali();
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            operation = "/";
            FirstNumberKoValueJayOperationSyPhlyWali();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            operation = "+";
            FirstNumberKoValueJayOperationSyPhlyWali();
        }


        private void equallbutton_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(textBox1.Text); //second nbr jo b enter ho secondNumber ma ajay

            //all operaton ider perform horhy ha
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    break;

            }
            textBox1.Text = result.ToString();
        }

        //its for hyperlink
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://allice9554.000webhostapp.com/");
        }
    }
}
