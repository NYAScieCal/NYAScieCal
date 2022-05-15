using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYAScieCal.utils
{
    class ExponentButtonToggle
    {

        private ButtonStateConsts expBtnStatus;

        public void setExpBtnStatus(ButtonStateConsts status)
        {

            this.expBtnStatus = status;

        }

        public ButtonStateConsts getExpBtnStatus()
        {

            return this.expBtnStatus;

        }

    }
}
