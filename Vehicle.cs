namespace In_Class_Abstract_Class
{

    public abstract class Vehicle
    {
        public string Make { get; set;}

        public string Model {get; set;}

        public abstract string Color {get; set;}
        public virtual void ShowCarFax() 
        {
            System.Console.WriteLine("unknown car");
        }

        public virtual void Drive()
        {
            System.Console.WriteLine("you drive an unknown vehicle");
        }

        // public void BurnRubber(); 


        public virtual void Start()
        {
            System.Console.WriteLine("the car has started");
        }

        public virtual void Stop()
        {
            System.Console.WriteLine("the car has stoped");
        }
        public virtual void ShowColor()
        {

        }


    }
}
