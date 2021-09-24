namespace In_Class_Abstract_Class
{
    public abstract class Ford : Vehicle
    {
        public string Color {get; set;}

        public override void Drive()
        {
            System.Console.WriteLine("The Ford is running");
        }


    }

}