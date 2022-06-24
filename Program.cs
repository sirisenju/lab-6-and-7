
namespace labWork
{
    // labAssignment week 6.
    public class Program{
        public static void Main(string[] args){

            //Rectangle myRectangle = new Rectangle(5.0, 5.0);
            //Triangle myTriangle = new Triangle(3.9, 5.4);
            //Circle myCircle = new Circle(3.6);

            //myRectangle.CalculateSurface();
            //myTriangle.CalculateSurface();
            //myCircle.CalculateSurface();

            Console.WriteLine();

            Dog myDog = new Dog("Lily", "female", 5);
            Cat myCat = new Cat("Dindu", "female", 4);
            Frog myFrog = new Frog("Hobson", "Male", 4);

            myCat.AnimalSound();
            Console.WriteLine(myDog.name);

    }

    public abstract class Shape{
        public double width;
        public double height;
        public double radius;
        public abstract void CalculateSurface();

    }
    class Rectangle : Shape{

        public Rectangle(double width, double height){
            this.width = width; 
            this.height = height;
        }
        public override void CalculateSurface()
        {
            double area = this.width * this.height;
            Console.WriteLine($"The surface area rectangle of height {height} and width {width} is: {area}");
        }
    }
    class Triangle: Shape{
        public Triangle(double width, double height){
            this.width = width; 
            this.height = height;
        }

        public override void CalculateSurface()
        {
            double areaOfTriangle = height * (width/2);
            Console.WriteLine($"The surface area a triangle of height {height} and width {width} is: {areaOfTriangle}");
        }
    }
    class Circle: Shape{
        public Circle(double radius){
            this.radius = radius;
        }

        public override void CalculateSurface()
        {
            double areaOfTriangle = Math.Pow(radius, 2.0) * Math.PI;
            Console.WriteLine($"The area of a circle of radius {radius} is: {areaOfTriangle}");
        }
    }
   }
}