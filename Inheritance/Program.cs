namespace HelloWorld
{
    //
    class BaseProduct
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }

    class Phone : BaseProduct
    {
        public double ScreenSize { get; set; }
    }
    class Mouse : BaseProduct
    {
        public int Dpi { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Phone Iphone = new Phone()
            {
                Brand = "Apple",
                Model = "Iphone 12",
                ScreenSize = 4.7

            };

            Mouse GM41 = new Mouse()
            {
                Brand = "MSI",
                Model = "GM41",
                Dpi = 2000
            };


            Console.WriteLine("Phone Brand:{0} - Model:{1} - Screen Size:{2}", Iphone.Brand, Iphone.Model, Iphone.ScreenSize);
            Console.WriteLine("Mouse Brand:{0} - Model:{1} - DPI:{2}", GM41.Brand, GM41.Model, GM41.Dpi);

        }
    }
}