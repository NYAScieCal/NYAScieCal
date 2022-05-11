using NYAScieCal.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYAScieCal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Utility util = new Utility();
        public static Controller controller = new Controller();
        public static OperandState operandState = new OperandState();
        public static CalcMode calcMode = new CalcMode();
        public static NYAScieCal.utils.ButtonState buttonState = new NYAScieCal.utils.ButtonState();

        [STAThread]
        static void Main()
        {

            calcMode.setCalcMode(CalcModeConsts.STANDARD);

            /*Dito ang testingan*/

            Console.WriteLine(controller.modulo(12, 5));
            Console.WriteLine(controller.log(24));
            Console.WriteLine("Testing");

            /*End*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
