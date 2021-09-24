namespace In_Class_Abstract_Class
{
    public class Ford : Vehicle
    {
        public override string Color {get; set;}

        public override void Drive()
        {
            System.Console.WriteLine("you are driving a ford");
        }
        

        public override void Start()
        {
            System.Console.WriteLine("The Ford is running");
        }

        public override void ShowColor()
        {
            Make = "ford";
            Model = "Focus";
            Color = "blue";
            System.Console.WriteLine($"The color is {Color}");
        }


    }

}
