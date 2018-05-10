using System;

namespace _9998329_assessment1_question01
{
    //Creating a new Class named Car
    class Cars{
        //setting the field access to private and the field type to string
        private string _Colour;
        private string _Make;
        private string _Gearbox;
        
        //Seting method for each of the 3 instance variables
        public string Colour{
            set{
                _Colour = value;
            }
        }
        public string Make{
            set{
                _Make = value;
            }
        } 
        public string Gearbox{
            set{
                _Gearbox = value;
            }
        }
        //Constructor
        public Cars(string _Colour, string _Make, string _Gearbox){
            Colour = _Colour;
            Make = _Make;
            Gearbox = _Gearbox;
        }

        //Setting method access to public
        //Adding the method to the class
        public string DisplayCar(){
            var carDetails = "Enter new car details below\n";            
            carDetails += $"Colour: {_Colour}\n";
            carDetails += $"Make: {_Make}\n";
            carDetails += $"Gearbox type: {_Gearbox}\n";
            return carDetails;            
        }
        //Overriding the method in the Car class
        public override string ToString(){
            return $"This car is a "+ _Colour + " " + _Make + " with a " +  _Gearbox  + " transmission. ";
        } 
    } 
    class Program
    {
        static void Main(string[] args)
        {
            //Star the program with Clear()
            Console.Clear();
            
            //Using the new operater to creating a Car object 
            //Assigning the object reference to a variable
            var car1 = new Cars("green" , "Ford" , "manual");       
            Console.WriteLine(car1.DisplayCar());            
            Console.WriteLine(car1.ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();                           
        }
    }
}
