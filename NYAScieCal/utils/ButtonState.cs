using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYAScieCal.utils
{
    class ButtonState
    {

        private ButtonStateConsts currentState;

        public void setCurrentState(ButtonStateConsts currentState)
        {

            this.currentState = currentState;


        }

        public ButtonStateConsts getCurrentState()
        {
            return this.currentState;
        }

    }
}
