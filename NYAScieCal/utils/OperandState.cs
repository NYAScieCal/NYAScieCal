using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYAScieCal.utils
{
    class OperandState
    {

        private OperandStateConsts currentState;

        public void setCurrentState(OperandStateConsts currentState)
        {

            this.currentState = currentState;


        }

        public OperandStateConsts getCurrentState()
        {
            return this.currentState;
        }

    }
}
