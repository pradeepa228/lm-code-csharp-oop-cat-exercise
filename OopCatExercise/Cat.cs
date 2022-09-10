using System;
using System.Drawing;

namespace OopCatExercise
{
    public abstract class Cat : ICat
    {
        public bool IsAsleep 
        { 
            get; 
            set; 
        }

        public abstract int AverageHeight
        {
            get;  
            set; 
        }
        

        public abstract string Setting
        {
            get; 
            set;
        }

        public abstract string Eat();
        public void GoToSleep()
        {
        }

        public void WakeUp()
        {            
        }
    }
}
