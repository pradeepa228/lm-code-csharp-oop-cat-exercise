using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        private string _setting = "domestic";
        private int _averageHeight = 23;

        public bool IsAsleep 
        { 
            get; 
            set; 
        }
        public override string Setting
        {  
            get { return _setting; } 
            set { _setting = value; }
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }

        public override int AverageHeight
        {
            get { return _averageHeight; }
            set { _averageHeight = value; }
        }

        public override string Eat()
        {
            return "Purrrrrrr";
        }
        /*
        public override string Eat()
        {
            return WillComment() ? "Purrrrrrr" : "Purrrrrrr. It will do I suppose";
            
        }
        private bool WillComment()
        {
            Random rnd = new Random();
            return rnd.Next(2) == 1;

        }
        */

    }
}