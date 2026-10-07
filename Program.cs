namespace Lab_4__Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här skapar jag en cirkel med radien 5. 
            Circle circle = new Circle(5,"mm");

            //Här hämtar kag cirkelns omkrets och skriver resultatet, F2 gör så man får 2 decimaler
            double CircumferenceCalc = circle.GetCircumference();
            Console.WriteLine($"Cirkelns omkrets är {CircumferenceCalc:F2}{circle.Unit} ");

            //här hämtar jag cirkelns area och skriver ut resultat
            double Area = circle.GetArea();
            Console.WriteLine($"Cirkelns area är {Area:F2}{circle.AreaUnit}");

            // här hämtar jag volymen för en sfär.
            double ValumeCalc = circle.GetSphereVolume();
            Console.WriteLine($"Sfärens volym är {ValumeCalc:F2}{circle.VolumeUnit}");


            Console.WriteLine();



            //här skapar jag en annan cirkel med radie 6
            Circle circle2 = new Circle(6);

            //här hämtar jag den andra cirkelns omkrets
            double CircumferenceCalc2 = circle2.GetCircumference();
            Console.WriteLine($"Andra cirkelns omkrets är {CircumferenceCalc2:F2}{circle2.Unit} ");
            
            //hämtar jag den andra cirkelns area 
            double Area2 = circle2.GetArea();
            Console.WriteLine($"Andra cirkelns area är {Area2:F2}{circle2.AreaUnit}");
            
            //hämtar jag volymen för en sfär med den andra cirkeln
            double ValumeCalc2 = circle2.GetSphereVolume();
            Console.WriteLine($"Andra sfärens volym är {ValumeCalc2:F2}{circle2.VolumeUnit}");




            Console.WriteLine();


            //här skapar jag en triangel och skickar in måtten för basens längd, höjdens längd och sidans längd.
            Triangle triangle = new Triangle(3, 4, 5);

            // här anropar jag metoden som räknar ut triangels omkrets
            double CircumferenceTrianglecalc = triangle.GetPerimeter();
            Console.WriteLine($"Triangelns omkrets är {CircumferenceTrianglecalc:F2}{triangle.Unit}");

            //Här hämtar jag triangelns area och skriver ut resultat
            double AreaCalcTriangle = triangle.GetArea();
            Console.WriteLine($"Triangelns area är {AreaCalcTriangle:F2}{triangle.AreaUnit}");

            //här hämtar jag ut volymen för prisma.
            double ValumeCalcTraingle = triangle.GetPrismaVolume();
            Console.WriteLine($"Prismats volym är {ValumeCalcTraingle:F2}{triangle.VolumeUnit}");

        }





    }



}













