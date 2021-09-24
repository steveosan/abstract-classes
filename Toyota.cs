namespace In_Class_Abstract_Class
{
    public class Toyota : Vehicle
    {
        public override string Color {get; set;}

        public override void Drive()
        {
            System.Console.WriteLine("you are driving a Toyota");
        }
        

        public override void Start()
        {
            System.Console.WriteLine("The Toyota is running");
        }

        public override void ShowCarFax()
        {
            Make = "Toyota";
            Model = "Camery";
            Color = "Grey";
            System.Console.WriteLine($"The {Make} {Model}  color is {Color}");
        }


    }

}