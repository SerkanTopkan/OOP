namespace HelloWorld
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }

    class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
    }
    class Aeroplane : Vehicle
    {
        public int NumberOfFlap { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car Bmw = new Car()
            {
                Brand = "BMW",
                Model = "3.16",
                NumberOfWheels = 4

            };

            Aeroplane Boeing737 = new Aeroplane()
            {
                Brand = "Boeing",
                Model = "737",
                NumberOfFlap = 2
            };


            Console.WriteLine("Car Brand:{0} - Model:{1} - Number Of Wheels:{2}", Bmw.Brand, Bmw.Model, Bmw.NumberOfWheels);
            Console.WriteLine("Aeroplane Brand:{0} - Model:{1} - Number Of Flap:{2}", Boeing737.Brand, Boeing737.Model, Boeing737.NumberOfFlap);

        }
    }
}