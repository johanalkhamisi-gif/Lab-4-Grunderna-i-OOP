

namespace Lab_4__Grunderna_i_OOP
{
    internal class Circle
    {
        //här sparas cirkelns radie
        public double Radius;

        //här sparas enheter för längd, area och volym
        public string Unit;
        public string AreaUnit;
        public string VolumeUnit;

        //konstruktor körs när jag skapar ett objekt med new Circle. Om jag inte skickar in någon enhet så används meter som standard värde.
        public Circle(double radius, string unit = "m" )
        {
            Radius = radius;
            Unit = unit;

            //Här har jag gjort så att baserat på enheten så visas det korrekta tecknet för kvadrat och kubik.
            AreaUnit = unit + "\u00B2";
            VolumeUnit = unit + "\u00B3";


        }

        // räknar ut cirkelns omkrets och använder mig av math.pi som innehåller värdet för pi.
        public double GetCircumference()
        {
            double circumferenceCalc = 2 * Math.PI * Radius;
            return circumferenceCalc;
        }

        //räknar ut cirkelns area och använder mig av math.pow är upphöjt, så det jag skriver innebär radien upphöjt i 2.
        public double GetArea()
        {
            double AreaCalc = Math.Pow(Radius, 2) * Math.PI;
            return AreaCalc;
        }

        //här räknar jag ut volymen för ett sfär. varför jag skrivit 4.0/3.0 är för att det gör så att divisionen get ett decimaltal.
        public double GetSphereVolume()
        {
            double VolumeCalc = Math.Pow(Radius, 3) * Math.PI * (4.0 / 3.0);
            return VolumeCalc;
        }

    }
}
