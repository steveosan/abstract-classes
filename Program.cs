using System;

namespace In_Class_Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {


            Ford ford = new Ford();
            ford.Start();
            
            Vehicle f150 = new Ford();
            f150.ShowColor();

            Vehicle camery = new Toyota();

            camery.ShowCarFax();

        }
    }
}



            // // Check out Tim Corey "IAmTimCorey" on Youtube.

            // //Encapsulation = hide behaviors from the user. 

            // // Be careful and use consideration to limit the number of class attributes!!! 
