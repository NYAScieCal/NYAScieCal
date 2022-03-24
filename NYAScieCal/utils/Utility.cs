using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYAScieCal.utils
{
    class Utility
    {


        public Image resizeImage(Image img, int width, int height)
        {
            
            Bitmap new_image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(img, 0, 0, width, height);
            return new_image;

        }

        public void executeNumberDisplay(String number,RichTextBox textBox)
        {
            
            if (checkZeroStartOccurence(textBox.Text)&&
                Program.buttonState.getCurrentState() == utils.ButtonStateConsts.OFF)
            {
               
                textBox.Text = "";
                
            }

            if (Program.buttonState.getCurrentState() == utils.ButtonStateConsts.OFF)
            {
                textBox.AppendText(number);
            }
            else if (Program.operandState.getCurrentState() == utils.OperandStateConsts.END_OPERAND_SET)
            {

                string temp1 = textBox.Lines[0];
                string temp2 = textBox.Lines[1];

                if (checkZeroStartOccurence(temp1))
                {
                    temp1 =  number;
                }
                else
                {
                    temp1 = temp1 + number;
                }
                
                textBox.Text = temp1;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.AppendText("\n" + temp2);
            }
           
            else
            {
                
                string temp = textBox.Text;
                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.AppendText("\n" + temp + " + ");
                Program.operandState.setCurrentState(utils.OperandStateConsts.END_OPERAND_SET);
            }

      
        }


        public string[] getOperands(RichTextBox textBox)
        {

            string str1 = textBox.Lines[0];
            string str2 = textBox.Lines[1];
            string[] str2Split = str2.Split(' ');
            string[] results = { str2Split[0] , str1 };

            return results;

        }

        public string getOperand(RichTextBox textBox)
        {
            return textBox.Lines[0];
        }

        public void resetAll()
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.OFF);
            Program.operandState.setCurrentState(OperandStateConsts.OFF);

        }

        public Boolean checkZeroStartOccurence(string text)
        {
            string str = text;
            if (str.StartsWith("0")&&(str.Length==1))
            {
                return true;
            }
            else
            {

                return false;

            }
           
        }

        public Boolean checkDotOccurence(string text)
        {

            string str = text;
            if (str.Contains('.'))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean isSingleOperand(RichTextBox textBox)
        {

            try
            {
                string strArr1 = textBox.Lines[0];
                string strArr2 = textBox.Lines[1];
                return false;
            }
            catch (Exception)
            {
      
                return true;

            }

        }

        public void paintGraph(Panel panel)
        {

            System.Drawing.Graphics graphicsObj;
            Point origin = new Point((int)panel.Width / 2, (int)panel.Height / 2);
            Point boundaryY = new Point(0,panel.Height);
            Point boundaryX = new Point(0, panel.Width);
            graphicsObj = panel.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Blue, 1);
            graphicsObj.DrawLine(myPen, (int)panel.Width / 2, 0, (int)panel.Width / 2,panel.Height);
            myPen = new Pen(System.Drawing.Color.Blue, 2);
            graphicsObj.DrawLine(myPen, 0, (int)panel.Height / 2, panel.Width, (int)panel.Height / 2);
           
            for (int i=origin.Y;i>=boundaryY.X;i-=5)
            {
                graphicsObj.DrawLine(myPen, origin.X - 2, i, origin.X + 2, i);
            }

            for (int i = origin.Y; i <=boundaryY.Y ; i += 5)
            {
                graphicsObj.DrawLine(myPen, origin.X - 2, i, origin.X + 2, i);
            }

            myPen = new Pen(System.Drawing.Color.Blue, 1);

            for (int i = origin.X-5; i >= boundaryX.X; i -= 5)
            {
                graphicsObj.DrawLine(myPen, i, origin.Y-3, i, origin.Y+2);
            }

            for (int i = origin.X + 5; i <= boundaryX.Y; i += 5)
            {
                graphicsObj.DrawLine(myPen, i, origin.Y - 3, i, origin.Y + 2);
            }

           

        }

    }
}
