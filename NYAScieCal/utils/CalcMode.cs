using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYAScieCal.utils
{
    class CalcMode
    {

        private CalcModeConsts calcMode;

        public void setCalcMode(CalcModeConsts calcMode)
        {

            this.calcMode = calcMode;

        }

        public CalcModeConsts GetCalcMode()
        {

            return this.calcMode;

        }




    }
}
