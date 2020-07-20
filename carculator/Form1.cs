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
    public enum Operators { Add, Minus, Multi, Div}
    public partial class Form1 : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;
        public Form1()
        {
            InitializeComponent();

        }

      

        private void Numbtn1_Click(object sender, EventArgs e)
        {
            Button NumBtn = (Button)sender;
            SetNum(NumBtn.Text);
            SetText.Text += NumBtn.Text;

        }

        
        public void SetNum(string num)
        {
            if (isNewNum) //새로운 숫자임
            {
                NumText.Text = num;
                isNewNum = false;
            }
            else if (NumText.Text == "0")//새로운 숫자가아님
            {
                NumText.Text = num;
            }
            else
            {
                NumText.Text += num;
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                int num = int.Parse(NumText.Text); // string 형식을 int형식으로 변환
                if (Opt == Operators.Add)
                    Result += num;
                else if (Opt == Operators.Minus)
                    Result -= num;
                else if (Opt == Operators.Multi)
                    Result *= num;
                else if (Opt == Operators.Div)
                    Result /= num;

                NumText.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Minus;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "/")
                Opt = Operators.Div;


            SetText.Text += optButton.Text;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;
            NumText.Text = "0";
            SetText.Text = "";
        }
    }
}
