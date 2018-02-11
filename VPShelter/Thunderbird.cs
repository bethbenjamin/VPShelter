namespace VPShelter
{
    public class Thunderbird : VirtualPet
    {

        //fields
        public string typeOfPet;
        public string dietOfPet;
        public int thunderAge = 100;
        public int thunderHungry = 100;
        public int thunderHappy = 100;
        public int thunderEnergyLevel = 100;
        public int thunderWater = 100;
        

        //fields and properties should include type of pet and diet

        //properties

        public string TypeOfPet
        {
            get { return this.typeOfPet; }
            set { this.typeOfPet = value; }
        }
        public string DietOfPet
        {
            get { return this.dietOfPet; }
            set { this.dietOfPet = value; }
        }

        public Thunderbird(int thunderHungry, int thunderHappy, int thunderAge, int thunderEnergyLevel, int thunderWater, string dietOfPet, string typeOfPet)
        {
            this.thunderHungry = thunderHungry;
            this.thunderHappy = thunderHappy;
            this.thunderAge = thunderAge;
            this.thunderEnergyLevel = thunderEnergyLevel;
            this.thunderWater = thunderWater;
            this.typeOfPet = typeOfPet;
            this.dietOfPet = dietOfPet;

        }

        //constructors
        public Thunderbird()
        {
            //default constructor
        }
        public Thunderbird(string typeOfPet, string dietOfPet)
        {
            this.typeOfPet = typeOfPet;
            this.dietOfPet = dietOfPet;
        }

        //methods
        public override void Play() // if she plays she will get hungry, get thirsty and lose energy.
        {
            thunderHappy += 0;
            thunderHungry -= 6;
            thunderEnergyLevel -= 10;
            thunderWater -= 5;

        }//this is the end of thunderPlay method

        public override Feed() //if she feeds she will get thirsty and gain energy
        {
            if (thunderHungry > 10) //basically saying if thunderHungry is less than 1 do this:
            {
                return "Yum. She's full. She can't eat anymore.";
                
            }
            else if (thunderHungry > 50) //less than or equal to 60
            {
                return "Your Thunderbird seems to be quite hungry.  One or two Pygmy Puffs will do.";
            }
            else if (thunderHungry > 90) //almost at the end
            {
                return "Quick, someone get her an Erumpant!";
            }
            else
            {
                return "Thunderbirds are interesting creatures, keep her happy, there will be no problems. ";
            }

            //these are faded and i dont know why...
            thunderHungry += 6; //if she eats she will get thirsty, increase energy and make her happy
            thunderWater -= 5;
            thunderEnergyLevel += 5;
            thunderHappy += 3;
        } //this is the end of the feed method

        public override  Water() //this needs to  be in string 

        {
            if (thunderWater < 20) //basically saying if thunderWater is less than 9 do this:
            {
                return"Best to not give her anymore water.";
            }
            else if (thunderWater > 50) //half way 
            {
               return "Your Thunderbird seems thirsty. Fill the water dish!";
            }
            else if (thunderWater > 90)
            {
               return"Give Thunderbird her water!";
            }
            else
            {
                return "Thunderbirds thrive on water. It's now or never. ";
            }
            thunderWater += 3;//if thunder drinks water she will 
            thunderHungry -= 1;
            thunderEnergyLevel += 2;
            thunderHappy -= 3;
        } //this is the end of the Water method
        public void ThunderEat()
        {
            thunderHungry += 2; //this - an incrememnt of 2 (which is less than 5 set)
            thunderWater -= 1; //adds water when eats
            thunderEnergyLevel += 1;
            thunderHappy -= 1;
        }//this is the end of the thunderEat method






    }//end class VPTypeDiet
}//end Namespace
