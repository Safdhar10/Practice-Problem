using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchButton
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch s1 = new Switch();
            Console.WriteLine(s1.SwitchOn());
            Console.WriteLine(s1.SwitchOff());
        }
    }
    public enum SwitchState
    {
        on=0,
        off=1
    }
    public class Switch
    {
        SwitchState state;
        public Switch()
        {
            state = SwitchState.off;
        }
        public SwitchState SwitchOn()
        {
            if(state==SwitchState.off)
            {
                state = SwitchState.on;
            }
            return state;
        }
        public SwitchState SwitchOff()
        {
            if (state == SwitchState.on)
            {
                state = SwitchState.off;
            }
            return state;
        }

    }

}
