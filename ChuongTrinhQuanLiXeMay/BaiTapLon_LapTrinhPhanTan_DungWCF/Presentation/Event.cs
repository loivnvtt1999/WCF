using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Presentation
{
    class Event
    {
        public delegate void SecondChangeHandler(object clock, EventArgs argrs);
        public event SecondChangeHandler OnSecondChange;
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (OnSecondChange != null)
                    OnSecondChange(this, new EventArgs());
            }
        }
    }
}
