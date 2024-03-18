namespace GA_Inheritence_manjulaRajan
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Vehicle vehicle1= new Vehicle("Red");
            Land land = new Land("Purple",4);
            Sea sea = new Sea("orange", "Submarine");


            Console.WriteLine(vehicle1.ToString());


        }//Main





    }//Class




}//Namespaace