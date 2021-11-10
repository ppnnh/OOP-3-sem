using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    //букет: бумага, цветок: роза, гладиолус 
    //bouquet: paper, flower: rose, gladiolus
    public abstract class Bouqeut
    {
        private int cost;
        public virtual int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public Bouqeut(int _cost)
        {
            cost = _cost;
        }
        public Bouqeut()
        { }
    }
    public class Paper : Bouqeut
    {
        private string typeOfPaper;
        public string TypeOfPaper
        {
            get { return ("Type of paper: "+typeOfPaper); }
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
    public class Flower : Bouqeut
    {
        private int number;
        public virtual int Number
        { get { return number; } 
        set { number = value; }
        }
        public Flower(int _cost, int _number)
        {
            Cost = _cost;
            Number = _number;
        }
        public Flower()
        {
        }
    }
    public class Rose : Flower
    { 
        private string typeOfRose;
        public string TypeOfRose
        { get { return typeOfRose; }
        set { typeOfRose = value; }
        }
        public Rose(int _cost, int _number, string _typeOfRose)
        {
            Cost = _cost;
            Number = _number;
            TypeOfRose = _typeOfRose;
        }
    }
    public class Gladiolus : Flower
    {
        private string colour;
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public Gladiolus(int _cost, int _number, string _colour)
        {
            Cost = _cost;
            Number = _number;
            Colour = _colour;
        }
    }

}
