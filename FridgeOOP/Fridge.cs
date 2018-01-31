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
            get { return this.isClean; }   //Allows us to see the value
            set { this.isClean = value; }  //Allow us to set the value
        }

        public string DispenserType
        {
            get { return this.dispenserType; }
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }
        
        //Constructors
        public Fridge()
        {
            this.dispenserType = "basic water dispenser";
        }
        
        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType;
        }

        public Fridge(bool isClean, string dispenserType,int foodAmount, bool bulbsWork) 
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;         
        }    
        

        //Methods()
        
        public void DispenseWater()
        {
            if (dispenserType is == "basic water dispenser")
            {
                Console.WriteLine("Here's some lukewarm water!");
            }

            else if(dispenserType == "deluxe dispenser")
            {
                Console.WriteLine("Enjoy your water, its greats tasting!");
            }

            else
            {
                Console.WriteLine("What are you going to do when Hulk Hogan and the luckwarm water comes from you?");
            }
        }
    }
}
