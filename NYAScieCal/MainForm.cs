using NYAScieCal.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYAScieCal
{
    public partial class MainForm : Form
    {

        private int currentX;
        private int currentY;

        public MainForm()
        {
            InitializeComponent();
            modeComboBox.SelectedIndex = 0;
            //this.textBox.SelectionAlignment = HorizontalAlignment.Right;
            /*this.trigoBtn.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\images\\25243.png"),15,15);
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.Image= Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\images\\closeIcon.png"), 15, 15);
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Program.util.resizeImage((System.Drawing.Image)(resources.GetObject("button1.Image")), 80, 40);*/
            this.buttonAdd.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\plus-icon.png"), 20, 20);
            this.buttonSubtract.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\subtract-icon.png"), 20, 20);
            this.buttonMultiply.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\multiply-icon.png"), 15, 15);
            this.buttonDivide.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\division-icon.png"), 20, 20);
            this.parOpBtn.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\open-parenthesis-icon.png"), 20, 20);
            this.parEndBtn.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\close-parenthesis-icon.png"), 20, 20);
            this.eulerBtn.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\euler-icon.png"), 20, 20);
            this.logFuncBtn.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\log-func-icon.png"), 40, 40); 
            this.eulerFuncBtn.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\euler-func-icon.png"), 40, 40);
            //numbers
            this.button7.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\7-icon.png"), 40, 40);
            this.button8.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\8-icon.png"), 40, 40);
            this.button9.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\9-icon.png"), 40, 40);
            this.button4.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\4-icon.png"), 40, 40);
            this.button5.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\5-icon.png"), 40, 40);
            this.button6.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\6-icon.png"), 40, 40);
            this.button1.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\1-icon.png"), 40, 40);
            this.button2.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\2-icon.png"), 40, 40);
            this.button3.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\3-icon.png"), 40, 40);
            this.button0.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\NYAScieCal\\images\\0-icon.png"), 40, 40);

        }

        private void trigoBtn_Click(object sender, EventArgs e)
        {
            int x = this.DesktopLocation.X;
            int y = this.DesktopLocation.Y;
            TrigoDialog dialog = new TrigoDialog(this.textBox);
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.SetDesktopLocation(trigoBtn.Location.X + x, trigoBtn.Location.Y + y + trigoBtn.Height);
            dialog.ShowDialog(this);
            

        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {

            if (Control.MouseButtons == MouseButtons.Left)
            {

                if (this.currentX==0&&this.currentY==0)
                {

                    this.currentX = e.X;
                    this.currentY = e.Y;

                }

                this.SetDesktopLocation(this.Location.X + (e.X - this.currentX), this.Location.Y + (e.Y - this.currentY)) ;

            }

            if (Control.MouseButtons == MouseButtons.None)
            {
                this.currentX = e.X;
                this.currentY = e.Y;
            }

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("7", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("7",textBox);

            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("6", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("6", textBox);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("3", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("3", textBox);

            }


        }

        private void button0_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                if (!Program.util.checkZeroStartOccurence(this.textBox.Text))
                {
                    Program.util.executeNumberDisplay("0", textBox);
                }

            }
            else
            {

                if (!Program.util.checkZeroStartOccurence(this.textBox.Text))
                {

                    Program.util.executeCharacterDisplay("0", textBox);

                }

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("8", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("8", textBox);

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("9", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("9", textBox);

            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("2", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("2", textBox);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("4", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("4", textBox);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("5", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("5", textBox);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                Program.util.executeNumberDisplay("1", textBox);

            }
            else
            {

                Program.util.executeCharacterDisplay("1", textBox);

            }

        }

        private void buttonEq_Click(object sender, EventArgs e)
        {

            try
            {
                double ans = 0;
                
                //Perform operation
                if (Program.buttonState.getCurrentState()==ButtonStateConsts.ADD_BUTTON_SET)
                {
                    //Get string array value of operands
                    string[] str = Program.util.getOperands(this.textBox);
                    //Create instance of CalculationModel
                    CalculationModel model = new CalculationModel(str[0], str[1]);
                    ans = Program.controller.add(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.SUBTRACT_BUTTON_SET)
                {
                    //Get string array value of operands
                    string[] str = Program.util.getOperands(this.textBox);
                    //Create instance of CalculationModel
                    CalculationModel model = new CalculationModel(str[0], str[1]);
                    ans = Program.controller.subtract(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.MULTIPLY_BUTTON_SET)
                {
                    //Get string array value of operands
                    string[] str = Program.util.getOperands(this.textBox);
                    //Create instance of CalculationModel
                    CalculationModel model = new CalculationModel(str[0], str[1]);

                    ans = Program.controller.multiply(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.DIVIDE_BUTTON_SET)
                {//Get string array value of operands
                    string[] str = Program.util.getOperands(this.textBox);
                    //Create instance of CalculationModel
                    CalculationModel model = new CalculationModel(str[0], str[1]);

                    ans = Program.controller.divide(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.MODULO_BUTTON_SET)
                {
                    //Get string array value of operands
                    string[] str = Program.util.getOperands(this.textBox);
                    //Create instance of CalculationModel
                    CalculationModel model = new CalculationModel(str[0], str[1]);
                    ans = Program.controller.modulo(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.SIN_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("sin (") + "sin (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start,end-start);
                    ans = Program.controller.sin(double.Parse(op));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.COS_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("cos (") + "cos (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start, end - start);
                    ans = Program.controller.cos(double.Parse(op));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.TAN_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("tan (") + "tan (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start, end - start);
                    ans = Program.controller.tan(double.Parse(op));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.COT_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("cot (") + "cot (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start, end - start);
                    ans = Program.controller.cot(double.Parse(op));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.SEC_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("sec (") + "sec (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start, end - start);
                    ans = Program.controller.sec(double.Parse(op));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.CSC_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("csc (") + "csc (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start, end - start);
                    ans = Program.controller.csc(double.Parse(op));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.LOG_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("Log (") + "Log (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start, end - start);
                    ans = Program.controller.log(double.Parse(op));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.NAT_LOG_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("ln (") + "ln (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start, end - start);
                    ans = Program.controller.natLog(double.Parse(op));

                }
                else if (Program.buttonState.getCurrentState() == ButtonStateConsts.FACTORIAL_BUTTON_SET)
                {
                    int start = this.textBox.Text.IndexOf("fact (") + "fact (".Length;
                    int end = this.textBox.Text.LastIndexOf(")");
                    string op = this.textBox.Text.Substring(start, end - start);
                    ans = Program.controller.factorial(double.Parse(op));

                }
                else
                {

                    string s = this.textBox.Text;
                    string exp = "";
                    string baseNum = "";
                    for (int i=0;i<s.Length;i++)
                    {

                        this.textBox.SelectionStart = i;
                        this.textBox.SelectionLength = 1;

                        if (this.textBox.SelectionCharOffset > 0)
                        {

                            exp += s[i];

                        }
                        else
                        {

                            baseNum += s[i];

                        }

                    }

                    if (!(baseNum.Equals("")&&exp.Equals("")))
                    {

                        ans = Program.controller.pow(Convert.ToDouble(baseNum),Convert.ToDouble(exp));

                    }

                }

                //Display answer
                Program.controller.displayAnswer(this.textBox, ans.ToString());
                //Reset na lahat walanjo
                Program.util.resetState();
            }

            catch (Exception)
            {

            }
            


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                //temporary
                try
                {

                    string[] str = Program.util.getOperands(this.textBox);
                    CalculationModel model = new CalculationModel(str[0], str[1]);
                    double ans = Program.controller.add(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));
                    Program.controller.displayAnswer(this.textBox, ans.ToString());
                    Program.operandState.setCurrentState(OperandStateConsts.OFF);
                }

                catch (IndexOutOfRangeException) { 
                

                    Program.buttonState.setCurrentState(utils.ButtonStateConsts.ADD_BUTTON_SET);

                }



            }
            else
            {

                Program.util.executeCharacterDisplay("+", this.textBox);

            }



        }

        private void button11_Click(object sender, EventArgs e)
        {
            //temporary
            try { 

                string[] str = Program.util.getOperands(this.textBox);
                CalculationModel model = new CalculationModel(str[0], str[1]);
                double ans = Program.controller.modulo(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));
                Program.controller.displayAnswer(this.textBox, ans.ToString());
                Program.operandState.setCurrentState(OperandStateConsts.OFF);
            }

            catch(IndexOutOfRangeException)
            {
                Program.buttonState.setCurrentState(utils.ButtonStateConsts.MODULO_BUTTON_SET);
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logBtn_Click(object sender, EventArgs e)
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.LOG_BUTTON_SET);
            this.textBox.Text = "Log (" + this.textBox.Text + ")";


        }

        private void clrBtn_Click(object sender, EventArgs e)
        {

            this.textBox.Text = "0";
            Program.util.resetState();

        }

        private void dotBtn_Click(object sender, EventArgs e)
        {

            if (!Program.util.checkDotOccurence(this.textBox.Text))
            {

                if (Program.util.checkZeroStartOccurence(this.textBox.Text))
                {
                    Program.util.executeNumberDisplay("0.", this.textBox);
                }
                else
                {
                    Program.util.executeNumberDisplay(".", this.textBox);
                }
                
            }
           

           
            
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            /*
            if (Program.util.isSingleOperand(this.textBox))
            {
                string s = Program.util.getOperand(this.textBox);
                double ans = Program.controller.log(double.Parse(s));
                Program.controller.displayAnswer(this.textBox, ans.ToString());
            }*/

            Program.buttonState.setCurrentState(ButtonStateConsts.NAT_LOG_BUTTON_SET);
            this.textBox.Text = "ln (" + this.textBox.Text + ")";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Program.util.paintGraph(this.panel1,15);


        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            double[] arr = Program.util.getTranslatedCoordinates(this.panel1.Width, this.panel1.Height, new Point(e.X, e.Y),15);

            Console.Write("Actual x corrdinate: " + e.X);
            double transX = Program.util.getTranslatedXCoordinate(this.panel1.Width, e.X, 15);
            Console.Write(" Translated x coordinate: " + transX);
            Console.WriteLine(" Actual x coordinate again: " + Program.util.getActualXValue(this.panel1.Width, transX, 15));

        }

        private void button10_Click(object sender, EventArgs e)
        {
           




        }

        private void expBtn_Click(object sender, EventArgs e)
        {

            if (Program.expBtnToggle.getExpBtnStatus() == ButtonStateConsts.EXPONENT_BUTTON_ON)
            {

                Program.expBtnToggle.setExpBtnStatus(ButtonStateConsts.EXPONENT_BUTTON_OFF);
                Program.util.resetFont(this.textBox);
                this.expBtn.BackColor = System.Drawing.SystemColors.Control;

            }
            else
            {

                Program.expBtnToggle.setExpBtnStatus(ButtonStateConsts.EXPONENT_BUTTON_ON);
                this.expBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;


            }

           
            if(Program.expBtnToggle.getExpBtnStatus() == ButtonStateConsts.EXPONENT_BUTTON_ON)
            {

                if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
                {

                    Program.util.executeExponentDisplay(this.textBox.Text, this.textBox);

                }
                else
                {

                    Program.util.executeExponentDisplay("x", this.textBox);

                }



            }
            


        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (modeComboBox.SelectedIndex==0)
            {

                Program.calcMode.setCalcMode(CalcModeConsts.STANDARD);

            }
            else
            {

                Program.calcMode.setCalcMode(CalcModeConsts.GRAPHING);


            }

        }

        private void parOpBtn_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.GRAPHING)
            {

                Program.util.executeCharacterDisplay("(", this.textBox);

            }

        }

        private void parEndBtn_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.GRAPHING)
            {

                Program.util.executeCharacterDisplay(")", this.textBox);

            }

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                //temporary
                try
                {

                    string[] str = Program.util.getOperands(this.textBox);
                    CalculationModel model = new CalculationModel(str[0], str[1]);
                    double ans = Program.controller.subtract(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));
                    Program.controller.displayAnswer(this.textBox, ans.ToString());
                    Program.operandState.setCurrentState(OperandStateConsts.OFF);
                }

                catch (IndexOutOfRangeException)
                {


                    Program.buttonState.setCurrentState(utils.ButtonStateConsts.SUBTRACT_BUTTON_SET);

                }



            }
            else
            {

                Program.util.executeCharacterDisplay("-", this.textBox);

            }

        }

        private void eulerBtn_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                //temporary
                try
                {

                    string[] str = Program.util.getOperands(this.textBox);
                    CalculationModel model = new CalculationModel(str[0], str[1]);
                    double ans = Program.controller.multiply(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));
                    Program.controller.displayAnswer(this.textBox, ans.ToString());
                    Program.operandState.setCurrentState(OperandStateConsts.OFF);
                }

                catch (IndexOutOfRangeException)
                {


                    Program.buttonState.setCurrentState(utils.ButtonStateConsts.MULTIPLY_BUTTON_SET);

                }



            }
            else
            {

                Program.util.executeCharacterDisplay("*", this.textBox);

            }

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {

                //temporary
                try
                {

                    string[] str = Program.util.getOperands(this.textBox);
                    CalculationModel model = new CalculationModel(str[0], str[1]);
                    double ans = Program.controller.divide(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));
                    Program.controller.displayAnswer(this.textBox, ans.ToString());
                    Program.operandState.setCurrentState(OperandStateConsts.OFF);
                }

                catch (IndexOutOfRangeException)
                {


                    Program.buttonState.setCurrentState(utils.ButtonStateConsts.DIVIDE_BUTTON_SET);

                }



            }
            else
            {

                Program.util.executeCharacterDisplay("/", this.textBox);

            }

        }

        private void radicalBtn_Click(object sender, EventArgs e)
        {

            if (Program.calcMode.GetCalcMode() == CalcModeConsts.STANDARD)
            {


                Program.buttonState.setCurrentState(ButtonStateConsts.RADICAL_BUTTON_SET);
                this.textBox.Text = "root (" + this.textBox.Text + " , )";


            }
            else
            {

               

            }


        }

        private void permBtn_Click(object sender, EventArgs e)
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.FACTORIAL_BUTTON_SET);
            this.textBox.Text = "fact (" + this.textBox.Text + ")";


        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            string a = Program.util.normalizedExpression(this.textBox);
            Console.WriteLine(a);
            //String[] splittedExp = a.Split('*', '/', '+', '-');
            //double value = Program.util.calculate(a);
            Program.util.graphFunction(this.panel1, a);


            //double[,] s = new double[,] { { 1, 2 },{ 3 , 4} };
            //double[,] s = new double[,] { { 1, 2 },{ 4 , 1 } ,{ 4 , 0} };
            //double[,] s = new double[,] { { 1, 2 }};
            //double[,] s = new double[,] { { 1, 1 },{ 3,0} };
            //double[,] s = new double[,] { { 1, 3 }, { 2, 0 } };

            //double[,] s = new double[,] { { 6, 2 }, { 4, 3 } , { 5, 0 } };

            //Program.util.graphFunction(this.panel1,new PolynomialModel(s,2));

            //double[,] s = new double[,] { { 1, 2 }, { 6, 0 } };
            //Program.util.graphFunction(this.panel1, new PolynomialModel(s, 2));


        }
    }
}
