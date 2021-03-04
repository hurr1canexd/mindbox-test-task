namespace AreaCalculatorLibrary
{
    public abstract class Shape
    {
        public double Area => GetArea();

        public abstract double GetArea();
    }
}
