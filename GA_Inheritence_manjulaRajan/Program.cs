namespace GA_Inheritence_manjulaRajan
{
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {


            Vehicle vehicle1= new Vehicle("Red");
            //Console.WriteLine(vehicle1.ToString());

            Land land1 = new Land("Purple",4 );
            //Console.WriteLine(land1.ToString());

            Air air1 = new Air("Green");
            //Console.WriteLine(air1.ToString());

            Sea sea1 = new Sea("orange", "Submarine");
            //Console.WriteLine(sea1.ToString());

            Plane plane1 = new Plane("Pink", 3);
            //Console.WriteLine(plane1.ToString());

            Helicopter helicopter1 = new Helicopter("Blue", 2);
            Console.WriteLine(helicopter1.ToString());

            vehicles.Add(vehicle1);
            vehicles.Add(air1);
            vehicles.Add(helicopter1);
            vehicles.Add(plane1);
            vehicles.Add(sea1);
            vehicles.Add(land1);

            foreach (Vehicle v in vehicles)
            {

                Console.WriteLine(v);
            }

        }//Main





    }//Class




}//Namespaace