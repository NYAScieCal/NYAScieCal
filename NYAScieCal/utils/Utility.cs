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

                string opSign = "";

                if (Program.buttonState.getCurrentState() == utils.ButtonStateConsts.ADD_BUTTON_SET)
                {
                    opSign = "+";
                }
                else if(Program.buttonState.getCurrentState() == utils.ButtonStateConsts.SUBTRACT_BUTTON_SET)
                {
                    opSign = "-";
                }
                else if (Program.buttonState.getCurrentState() == utils.ButtonStateConsts.MULTIPLY_BUTTON_SET)
                {
                    opSign = "x";
                }
                else if (Program.buttonState.getCurrentState() == utils.ButtonStateConsts.DIVIDE_BUTTON_SET)
                {
                    opSign = "/";
                }
                else
                {
                    opSign = "%";
                }
                string temp = textBox.Text;
                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.AppendText("\n" + temp + " "+opSign+" ");
                Program.operandState.setCurrentState(utils.OperandStateConsts.END_OPERAND_SET);

            }

      
        }

        public void executeCharacterDisplay(String character, RichTextBox textBox)
        {


            if (!textBox.Text.Equals("0"))
            {

                textBox.AppendText(character);

            }

            else
            {

                textBox.Text = "";
                textBox.Text = character;


            }

        }

        public void executeExponentDisplay(String character, RichTextBox textBox)
        {

            if (textBox.Text.Equals("0"))
            {

                textBox.Text = "";

            }

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {


                textBox.Text = "";
                textBox.SelectedText = character;

            }
            else
            {

                textBox.SelectedText = "x";

            }

            // Set the CharOffset to display superscript text.
            textBox.SelectionCharOffset = 15;
            // Set the superscripted text.	
            textBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.SelectedText = "";
            

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

        public void resetState()
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.OFF);
            Program.operandState.setCurrentState(OperandStateConsts.OFF);

        }

        public void resetFont(RichTextBox textBox)
        {

            textBox.SelectionCharOffset = 0;
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
            textBox.SelectionFont= new System.Drawing.Font("Microsoft Sans Serif", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

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

        public void paintGraph(Panel panel,int range)
        {

            System.Drawing.Graphics graphicsObj;
            Point origin = new Point(panel.Width / 2, panel.Height / 2);
            Point boundaryY = new Point(0,panel.Height);
            Point boundaryX = new Point(0, panel.Width);
            graphicsObj = panel.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Blue, 1);
            graphicsObj.DrawLine(myPen, panel.Width / 2, 0, panel.Width / 2,panel.Height);
            myPen = new Pen(System.Drawing.Color.Blue, 2);
            graphicsObj.DrawLine(myPen, 0, panel.Height / 2, panel.Width, panel.Height / 2);

            for (int i=origin.Y;i>=boundaryY.X;i-=range)
            {
                graphicsObj.DrawLine(myPen, origin.X - 2, i, origin.X + 2, i);
            }

            for (int i = origin.Y; i <=boundaryY.Y ; i += range)
            {
                graphicsObj.DrawLine(myPen, origin.X - 2, i, origin.X + 2, i);
            }

            myPen = new Pen(System.Drawing.Color.Blue, 1);

            for (int i = origin.X-range; i >= boundaryX.X; i -= range)
            {
                graphicsObj.DrawLine(myPen, i, origin.Y-2, i, origin.Y+2);
            }

            for (int i = origin.X + range; i <= boundaryX.Y; i += range)
            {
                graphicsObj.DrawLine(myPen, i, origin.Y - 2, i, origin.Y + 2);
            }

           

        }

        public void graphFunction(Panel panel,PolynomialModel model)
        {

            System.Drawing.Graphics graphicsObj = panel.CreateGraphics();
            graphicsObj.SmoothingMode = SmoothingMode.AntiAlias;
            Pen myPen = new Pen(System.Drawing.Color.Black, 1);
            Point[] points = new Point[panel.Width];

            for (int i=0;i<panel.Width;i++)
            {

                double[,] arr = model.getTerm();
                double total = 0;

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    double res = arr[j,0];

                    for (int k = 0; k < arr[j,1]; k++)
                    {

                        res = res * getTranslatedXCoordinate(panel.Width,i,15);

                    }

                    total = total + res;

                }

                points[i] = new Point(i,getActualRangeValue(panel.Height,total,15));

                Console.Write("Actual x corrdinate: "+i);
                Console.Write(" Translated x coordinate: "+getTranslatedXCoordinate(panel.Width, i, 15));
                Console.Write(" Range: "+total);
                Console.WriteLine(" Actual Range: " + getActualRangeValue(panel.Height,total,15));


            }

            graphicsObj.DrawCurve(myPen, points);

        }

        public double[] getTranslatedCoordinates(int xBoundery,int yBoundery,Point point,int range)
        {

           double[] arr = new double[2];

           arr[0] = (double)(point.X - (xBoundery / 2))/range;
           arr[1] = (double)((yBoundery / 2) - point.Y)/range;

           arr[0] = Convert.ToDouble(arr[0].ToString("0.###"));
           arr[1] = Convert.ToDouble(arr[1].ToString("0.###"));

           return arr;

        }

        public double getTranslatedXCoordinate(int xBoundery,int x,int range)
        {
            double val = (double)(x - (xBoundery / 2)) / range;
            val= Convert.ToDouble(val.ToString("0.###"));
            return val;
        }

        public double getTranslatedYCoordinate(int yBoundery, int y,int range)
        {
            double val = (double)((yBoundery / 2) - y) / range;
            val = Convert.ToDouble(val.ToString("0.###"));
            return val;

        }

        public int getActualRangeValue(int yBoundery,double y,int range)
        {

            int val = (int)((yBoundery/2)-(y*range));
            return val;

        }

        public int getActualXValue(int xBoundery,double x,int range)
        {

            int val = (int)((x * range) + (xBoundery / 2));
            return val;

        }


        public string normalizedExpression(RichTextBox textBox,double domain)
        {

           
            string s = "";

            for (int i=0;i<textBox.Text.Length;i++)
            {

                textBox.SelectionStart = i;
                textBox.SelectionLength = 1;

                Console.WriteLine(textBox.SelectionCharOffset + " " + textBox.Text[i]);


                if (textBox.SelectionCharOffset == 15)
                {

                    if (s[s.Length - 1].ToString().Equals("}"))
                    {

                        s=s.Remove(s.Length - 1 , 1).Insert(s.Length - 1 , textBox.Text[i]+"}");
       
                       

                    }
                    else
                    {

                        s += "pow{" + textBox.Text[i].ToString() + "}";

                    }

                  
                 
              
                }
              
                else if (textBox.Text[i].ToString().Equals("x"))
                {

                    try
                    {

                        if (isNumber(textBox.Text[i - 1].ToString()) || textBox.Text[i - 1].ToString().Equals("x"))
                        {

                            s += "*" + domain.ToString();

                        }
                        else
                        {

                            s += domain.ToString();

                        }

                        

                    }
                    catch (Exception e)
                    {

                        s += domain.ToString();
                        Console.WriteLine(e.Message);

                    }

                    


                }

                else if (textBox.Text[i].ToString().Equals("("))
                {
                    try
                    {

                        if (textBox.Text[i - 1].ToString().Equals("+") || textBox.Text[i - 1].ToString().Equals("-"))
                        {

                            s = s.Remove(s.Length - 1, 1).Insert(s.Length - 1, textBox.Text[i - 1] + "(");

                        }
                        else
                        {

                            s += "*(";

                        }

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);

                    }
                   

                }

                else if (textBox.Text[i].ToString().Equals(")"))
                {

                    try
                    {

                        if (textBox.Text[i + 1].ToString().Equals("+") || textBox.Text[i + 1].ToString().Equals("-"))
                        {
                            s +=textBox.Text[i];
                        }
                        else
                        {

                            s += ")*";


                        }

                    }
                    catch (Exception e)
                    {

                        s += ")";
                        Console.WriteLine(e.Message);

                    }
                   

                }


                else
                {

                    s += textBox.Text[i].ToString();

                }
            

            }

            return s;

        }

        public Boolean isNumber(string number)
        {

            try
            {


                Convert.ToDouble(number);
                return true;
                

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;


            }

        }


    }
}
