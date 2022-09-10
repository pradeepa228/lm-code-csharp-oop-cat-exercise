using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        private int _averageHeight = 1100;
        private string _setting = "wild";

        public override int AverageHeight
        {
            get { return _averageHeight; }
            set { _averageHeight = value; }
        }
        public override string Eat()
        {
            return "Roar!!!!";
        }

        public override string Setting
        {
            get { return _setting; }
            set { _setting = value; }
        }

    }
}