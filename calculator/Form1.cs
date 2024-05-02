using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        public int result; // Ekta variable declare korlam, jeta te int store hobe and name result
        public int operand1;
        public int operand2;
        public bool isFirstOperandGiven;
        public string ourOperator; // Need to keep a track of which operation we are gonna do


        public Form1()
        {
            InitializeComponent();
            isFirstOperandGiven = false;
        }

        private void fourbtn(object sender, EventArgs e)
        {
            rendertext("4");
        }

        private void onebtn(object sender, EventArgs e)
        {
            rendertext("1");
        }
        private void rendertext(string text)
        {
            resultbox.Text = resultbox.Text + text;
        }

        private void twobtn(object sender, EventArgs e)
        {
            rendertext("2");
        }

        private void threebtn(object sender, EventArgs e)
        {
            rendertext("3");
        }

        private void zeroBtn(object sender, EventArgs e)
        {
            rendertext("0");
        }

        private void fivebtn(object sender, EventArgs e)
        {
            rendertext("5");
        }


        private void sixBtn_click(object sender, EventArgs e)
        {
            rendertext("6");
        }

        private void sevenBtn_click(object sender, EventArgs e)
        {
            rendertext("7");
        }

        private void eightBtn_click(object sender, EventArgs e)
        {
            rendertext("8");
            // Receive korbi? 
            // Baki korte thak 
        }


        private void ninebtn_click(object sender, EventArgs e)
        {
            rendertext("9");

        }

        private void addbtn_click(object sender, EventArgs e)
        {
            operand1 = convertStringToInt(resultbox.Text); // Eta kor but operand2 hobe
            resultbox.Text = "";
            isFirstOperandGiven = true;
            ourOperator = "plus";
        }

        private int convertStringToInt(string text)
        {
            // Ekhane ekta text nebo jeta string and setake int baniye return korabo
            return int.Parse(text);
        }

        private void equalto_click(object sender, EventArgs e)
        {
            operand2 = convertStringToInt(resultbox.Text);
            isFirstOperandGiven = false; // Eta jehetu = button tai ja korlam sob reset hoye jabe
            if (ourOperator.Equals("division") && operand2 == 0)
            {
                resultbox.Text = "Bruh, are you for real? 💀";
            }

            else
            {
                result = evaluateExpression(operand1, operand2, ourOperator); // Evaluation holo ebar print korabo
                resultbox.Text = result.ToString();
            }
        }

        // Ekta function create korlam operation er jonno
        private int evaluateExpression(int firstOperand, int secondOperand, string ourOperator)
        {
            if (ourOperator.Equals("plus")) return firstOperand + secondOperand;
            // One line er code ar bracket dilam na

            else if (ourOperator.Equals("minus")) return firstOperand - secondOperand;
            else if (ourOperator.Equals("multiply")) return firstOperand * secondOperand;
            // Ebar baki button
            else if (ourOperator.Equals("division")) return firstOperand / secondOperand;

            else return -404;
        }

        private void cleanBtn_click(object sender, EventArgs e)
        {
            resultbox.Text = "";
            isFirstOperandGiven = false;
        }

        private void minusBtn_click(object sender, EventArgs e)
        {
            operand1 = convertStringToInt(resultbox.Text);
            resultbox.Text = "";
            isFirstOperandGiven = true;
            ourOperator = "minus";
        }

        private void multiplyBtn_click(object sender, EventArgs e)
        {
            operand1 = convertStringToInt(resultbox.Text);
            resultbox.Text = "";
            isFirstOperandGiven = true;
            ourOperator = "multiply";
        }

        private void divisionBtn_click(object sender, EventArgs e)
        {
            operand1 = convertStringToInt(resultbox.Text);
            resultbox.Text = "";
            isFirstOperandGiven = true;
            ourOperator = "division";
        }
    }
}
