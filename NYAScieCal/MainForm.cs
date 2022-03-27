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
            //this.textBox.SelectionAlignment = HorizontalAlignment.Right;
            /*this.trigoBtn.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\images\\25243.png"),15,15);
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.Image= Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\images\\closeIcon.png"), 15, 15);
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Program.util.resizeImage((System.Drawing.Image)(resources.GetObject("button1.Image")), 80, 40);*/


        }

        private void trigoBtn_Click(object sender, EventArgs e)
        {
            int x = this.DesktopLocation.X;
            int y = this.DesktopLocation.Y;
            TrigoDialog dialog = new TrigoDialog();
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

            Program.util.executeNumberDisplay("7", textBox);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Program.util.executeNumberDisplay("6", textBox);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Program.util.executeNumberDisplay("3", textBox);

        }

        private void button0_Click(object sender, EventArgs e)
        {

            if (!Program.util.checkZeroStartOccurence(this.textBox.Text))
            {
                Program.util.executeNumberDisplay("0", textBox);
            }

           

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Program.util.executeNumberDisplay("8", textBox);

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Program.util.executeNumberDisplay("9", textBox);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Program.util.executeNumberDisplay("2", textBox);


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Program.util.executeNumberDisplay("4", textBox);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Program.util.executeNumberDisplay("5", textBox);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Program.util.executeNumberDisplay("1",textBox);

        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            try
            {
                //Get string array value of operands
                string[] str = Program.util.getOperands(this.textBox);
                //Create instance of CalculationModel
                CalculationModel model = new CalculationModel(str[0], str[1]);
                //Perform operation
                double ans = Program.controller.modulo(double.Parse(model.getFirstOperand()), double.Parse(model.getEndOperand()));
                //Display answer
                Program.controller.displayAnswer(this.textBox, ans.ToString());
                //Reset na lahat walanjo
                Program.util.resetAll();
            }
            catch (IndexOutOfRangeException)
            {

            }
            


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
         
                
           
                    
           
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
           
           
    

           
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {

            this.textBox.Text = "0";
            Program.util.resetAll();

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

            if (Program.util.isSingleOperand(this.textBox))
            {
                string s = Program.util.getOperand(this.textBox);
                double ans = Program.controller.log(double.Parse(s));
                Program.controller.displayAnswer(this.textBox, ans.ToString());
            }

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
            //double[,] s = new double[,] { { 1, 2 },{ 3 , 4} };
            //double[,] s = new double[,] { { 1, 2 },{ 4 , 1 } ,{ 4 , 0} };
            //double[,] s = new double[,] { { 1, 2 }};
            double[,] s = new double[,] { { 1, 1 },{ 3,0} };
            Program.util.graphFunction(this.panel1,new PolynomialModel(s,2));

        }
    }
}
