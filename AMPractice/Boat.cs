using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMPractice
{
    class Boat
    {
        //so far we've done fields as pricate, but we can do them as public
        public int numberOfPassengers;

        //Most of the time though we want our fields to be private
        private string name;
        private string engineSize;

        //Properties almost always have public as their access modifier
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Constructors always have a public access modifier, otherwise you wouldn't be able to use it
        public Boat()
        {
            //this is my default constructor
        }

        //Methods
        public void Move()
        {
            //code to make boat move
        }
        private double CalculateMPG()
        {
            double MPG = 20;
            //code to calculate MPG
            return MPG;
        }
    }
}
