using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYAScieCal
{
    class Controller
    {

        //adding a comment

        public double modulo(double op1,double op2){

            return op1 % op2;

        }

        public double add(double op1, double op2)
        {

            return op1 + op2;


        }

        public double subtract(double op1, double op2)
        {

            return op1 - op2;

        }

        public double multiply(double op1, double op2)
        {

            return op1 * op2;

        }

        public double divide(double op1, double op2)
        {

            return op1 / op2;

        }

        public double sin(double op)
        {

            return Math.Sin(op);

        }

        public double cos(double op)
        {

            return Math.Cos(op);

        }

        public double tan(double op)
        {

            return Math.Tan(op);

        }

        public double cot(double op)
        {

            return 1/Math.Tan(op);

        }

        public double sec(double op)
        {

            return 1/Math.Cos(op);

        }

        public double csc(double op)
        {

            return 1/Math.Sin(op);

        }

        public void displayAnswer(RichTextBox textBox,string answer)
        {

            textBox.Text = answer;

        }

        public double natLog(double number)
        {
            return Math.Log(number); 

        }

        public double log(double number)
        {

            return Math.Log(number,10);

        }

        public double root(double num,double root)
        {

            return Convert.ToDouble(Math.Pow(num, (1 / root)));


        }

        public double factorial(double num)
        {

            double fact = num;
            for (int i = ((int)(num - 1)); i >= 1; i--)
            {

                fact *= i;

            }

            return fact;

        }

        public double pow(double baseNum,double exp)
        {

            return Math.Pow(baseNum, exp);

        }


    }


    //hello saan ang save ay oki na
    //Another comment

}
