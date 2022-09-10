using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        private int _averageHeight = 200;
        private string _setting = "wild";

        public override string Eat()
        {
            return "Zzzzzzz";
        }
        public override int AverageHeight
        {
            get { return _averageHeight; }
            set { _averageHeight = value; }
        }

        public override string Setting
        {
            get { return _setting; }
            set { _setting = value; }
        }
    }
}