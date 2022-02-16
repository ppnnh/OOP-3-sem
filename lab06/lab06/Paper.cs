using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Paper : Bouqeut
    {
        private string typeOfPaper;
        public string TypeOfPaper
        {
            get { return ("Type of paper: " + typeOfPaper); }
            set { typeOfPaper = value; }
        }
        public Paper(int _cost, string _typeOfPaper)
        {
            Cost = _cost;
            TypeOfPaper = _typeOfPaper;
        }
        public Paper()
        { }
    }
}
