// Abstract Class : Abstract class’lardan instance object (örnek nesne) oluşturulamaz. Abstract class’a ulaşmak için başka bir sınıftan kalıtım alınması gerekir.
// Abstract Method : Sadece abstract class içerisinde kullanılır. Metot içerisine herhangi birşey yazılmaz. Bir abstract class hem abstract metotlara hem de normal metotlara sahip olabilir. Bu kısım önemli. Şimdi bir örnekle bunu gösterelim.

namespace HelloWorld
{

    public abstract class Vehicle
    {
        public abstract double GetFuelInfo();
    }

    public class Car : Vehicle
    {
        public Car()
        {

        }

        public override double GetFuelInfo()
        {
            return 15;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car();
            var FuelInfo = bmw.GetFuelInfo();
            Console.WriteLine("BMW Fuel Info:{0}", FuelInfo.ToString());

        }
    }
}