using Arv_Övningar_9_Okt;

namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var lang = new List<Greeter> { new Greeter(), new Swahili() };
            //foreach (Greeter hejhej in lang)
            //{
            //    hejhej.Hello();
            //}

            Human human = new Human();
            Animal animal = new Animal();
            human.Name = "Jane Godall";
            human.Age = 87;
            human.CanDriveCar = true;
            animal.Name = "Jubilee";
            animal.Age = 7;
            animal.CanDriveCar = false;
            
            var fred = new MyHuman { Name = "Fred", LastName = "Flintstone" };
            var cat = new Cat { Name = "Baby Puss" };
            List<INameable> characters = new List<INameable> { fred, cat };
            List<IFamilyName> inside = new List<IFamilyName> { fred };

        }
    }
}