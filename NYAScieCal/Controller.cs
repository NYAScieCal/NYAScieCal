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

        public void displayAnswer(RichTextBox textBox,string answer)
        {

            textBox.Text = answer;

        }

        public double log(double number)
        {
            return Math.Log(number); 

        }



    }


    //hello saan ang save ay oki na
    //Another comment

}
