
namespace Lab_4__Grunderna_i_OOP
{
    internal class Triangle
    {
        // här sparas triangelns mått
        public double BaseLength;
        public double Hight;
        public double SideLength;

        // här sparas enheterna för längd, area och volym
        public string Unit;
        public string AreaUnit;
        public string VolumeUnit;

        //konstruktor körs när jag skapar ett objekt med new Traingel och om jag inte skickar någon enhet används meter som standard
        public Triangle(double baseLength, double height, double sideLength, string unit = "m")
        {
            
            BaseLength = baseLength;
            Hight = height;
            SideLength = sideLength;
            Unit = unit;

            //Här har jag gjort så att baserat på enheten så visas det korrekta tecknet för kvadrat och kubik.
            AreaUnit = unit + "\u00B2";
            VolumeUnit = unit + "\u00B3";
        }

        //här räknar jag ut Triangel omkretsen genom omkretsen formel
        public double GetPerimeter()
        {
            double perimeterCalc = BaseLength + Hight + SideLength;
            return perimeterCalc;
        }

        //här räkmar ut triangel area via area formeln 
        public double GetArea()
        {
            double areaCalc = (BaseLength * Hight) / 2;
            return areaCalc;
        }

        //räknar ut volymen på prisma genom volym formel. Användet getarea för att få triangelns area och sidelength används som primats djup.
        public double GetPrismaVolume()
        {
            double prismaVolumeCalc = GetArea() * SideLength;
            return prismaVolumeCalc;
        }




    }
}

