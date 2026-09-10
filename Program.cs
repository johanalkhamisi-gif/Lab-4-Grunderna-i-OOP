namespace Lab_4__Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            
            
            double CircumferenceCalc = circle.Circumference();
            Console.WriteLine($"Cirkelns omkrets är {CircumferenceCalc:F2}{circle.Unit} ");
            
            double Area = circle.GetArea();
            Console.WriteLine($"Cirkelns area är {Area:F2}{circle.AreaUnit}");

            double ValumeCalc = circle.Volume();
            Console.WriteLine($"Cirkelns volym är {ValumeCalc:F2}{circle.VolumeUnit}");
            
            Console.WriteLine();

            
            
            
            Circle circle2 = new Circle(6);

            double CircumferenceCalc2 = circle2.Circumference();
            Console.WriteLine($"Andra cirkelns omkrets är {CircumferenceCalc2:F2}{circle2.Unit} ");

            double Area2 = circle2.GetArea();
            Console.WriteLine($"Andra cirkelns area är {Area2:F2}{circle2.AreaUnit}");

            double ValumeCalc2 = circle2.Volume();
            Console.WriteLine($"Andra cirkelns volym är {ValumeCalc2:F2}{circle2.VolumeUnit}");


            
            
            Console.WriteLine();



            Triangle triangle = new Triangle(5,6,7);
            double CircumferenceTrianglecalc = triangle.CircumferenceTriangle();
            Console.WriteLine($"Triangelns omkrets är {CircumferenceTrianglecalc:F2}{triangle.UnitTriangle}");
            
            double AreaCalcTriangle = triangle.GetAreaTriangle();
            Console.WriteLine($"Triangelns area är {AreaCalcTriangle:F2}{triangle.AreaUnitTriangle}");

            double ValumeCalcTraingle = triangle.VolumeTriangle();
            Console.WriteLine($"Triangelns volym är {ValumeCalcTraingle:F2}{triangle.VolumeUnitTriangle}");

        }
        class Circle
        {
            public double Radius;
            public string Unit;

            public string AreaUnit;

            public string VolumeUnit;

            public Circle(double Radius, string Unit = "m", string AreaUnit = "m\u00B2", string VolumeUnit = "m\u00B3")
            {
                this.Radius = Radius;
                this.Unit = Unit;
                this.AreaUnit = AreaUnit;
                this.VolumeUnit = VolumeUnit;


            }
            public double Circumference()
            {
                double CircumferenceCalc = 2 * Math.PI * Radius;
                return CircumferenceCalc;
            }

            public double GetArea()
            {
                double AreaCalc = Math.Pow(Radius, 2) * Math.PI;
                return AreaCalc;
            }


            public double Volume()
            {
                double VolumeCalc = Math.Pow(Radius, 3) * Math.PI * (4.0 / 3.0);
                return VolumeCalc;
            }




        }


       

        class Triangle
                {

                public double Base;
                public double Hight;
                public double Side;
                public string UnitTriangle;

                public string AreaUnitTriangle;

                public string VolumeUnitTriangle;

            public Triangle (double Base, double Hight, double Side, string UnitTriangle = "m", string AreaUnitTrangle = "m\u00B2", string VolumeUnitTriangle = "m\u00B3")
                {
                    this.Base = Base;
                    this.Hight = Hight;
                    this.Side = Side;
                    this.UnitTriangle = UnitTriangle;
                    this.AreaUnitTriangle = AreaUnitTrangle;
                    this.VolumeUnitTriangle = VolumeUnitTriangle;
            }    
                 
                public double CircumferenceTriangle()
                {
                    double CircumferenceTrianglecalc = Base + Hight + Side;
                    return CircumferenceTrianglecalc;
                }
                public double GetAreaTriangle()
                {
                    double AreaCalcTriangle = (Base * Hight) / 2;
                    return AreaCalcTriangle;
                }

                public double VolumeTriangle ()
                {
                    double VolumeTriangleCalc = GetAreaTriangle() * Side;
                    return VolumeTriangleCalc;
                }




                }

        }

        

    }
        

           
            




  


    

