using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge
    {
        //fields
        private bool isClean;
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;

        //Properties

        public bool IsClean
        {
            get {return this.isClean; }   //Allows us to see the value
            set {this.isClean = value; }  //Allow us to set the value
        }

        public string DispenserType
        {
            get { return this.dispenserType; }
        }
        //Constructors

        //Methods()
    }
}
