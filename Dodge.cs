namespace In_Class_Abstract_Class
{
    public class Dodge : Vehicle
    {
        public string Color {get; set;}

        public override void Drive()
        {
            System.Console.WriteLine("The Dodge is running");
        }

    }

}