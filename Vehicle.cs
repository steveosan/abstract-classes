namespace In_Class_Abstract_Class
{

    public abstract class Vehicle
    {
        public string Make { get; set;}

        public string Model {get; set;}

        public string Color {get; set;}

        public abstract void Drive():

        public abstract void BurnRubber(); 
        {
            //this is where I would of made my abstract method
        }


        public virtual void Start()
        {
            System.Console.WriteLine("the car has started");
        }

        public void Stop()
        {
            System.Console.WriteLine("the car has stoped");
        }
        public void Drive()
        {
            System.Console.WriteLine("the car is now driving");
        }
    }
}