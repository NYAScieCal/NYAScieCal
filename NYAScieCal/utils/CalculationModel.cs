using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYAScieCal.utils
{
    class CalculationModel
    {

        private string firstOperand, endOperand;

        public CalculationModel(string firstOperand,string endOperand)
        {

            this.firstOperand = firstOperand;
            this.endOperand = endOperand;

        }


        public string getFirstOperand()
        {

            return this.firstOperand;

        }

        public string getEndOperand()
        {

            return this.endOperand;

        }
    }
}
