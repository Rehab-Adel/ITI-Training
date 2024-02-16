namespace Lab3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfShapes;

            Console.Write("Enter number of shapes: ");

            if (int.TryParse(Console.ReadLine(), out numberOfShapes))
            {
                Shape[] shapes = new Shape[numberOfShapes];

                for (int i = 0; i < numberOfShapes; i++)
                {
                    Console.WriteLine($"Enter the type of shape {i + 1}:");
                    Console.WriteLine("1- Circle");
                    Console.WriteLine("2- Rectangle");
                    Console.WriteLine("3- Square");
                    Console.WriteLine("4- Triangle");
                    Console.WriteLine("5- Parallelogram");
                    int c = int.Parse(Console.ReadLine());

                    switch (c)
                    {
                        case 1:
                            Console.Write("Enter the circle radius: ");
                            float r = float.Parse(Console.ReadLine());
                            shapes[i] = new Circle(r);
                            Console.WriteLine($"The circle's area is: {shapes[i].Area()}\n");
                            break;

                        case 2:
                            Console.Write("Enter the rectangle width: ");
                            float w = float.Parse(Console.ReadLine());
                            Console.Write("Enter the rectangle height: ");
                            float h = float.Parse(Console.ReadLine());
                            shapes[i] = new Rectangle(w, h);
                            Console.WriteLine($"The rectangle's area is: {shapes[i].Area()}\n");
                            break;

                        case 3:
                            Console.Write("Enter the square side: ");
                            float a = float.Parse(Console.ReadLine());
                            shapes[i] = new Square(a);
                            Console.WriteLine($"The square's area is: {shapes[i].Area()}\n");
                            break;

                        case 4:
                            Console.Write("Enter triangle base: ");
                            float Tb = float.Parse(Console.ReadLine());
                            Console.Write("Enter triangle height: ");
                            float Th = float.Parse(Console.ReadLine());
                            shapes[i] = new Triangle(Tb, Th);
                            Console.WriteLine($"The triangle's area is: {shapes[i].Area()}\n");
                            break;

                        case 5:
                            Console.Write("Enter the parallelogram base: ");
                            float Pb = float.Parse(Console.ReadLine());
                            Console.Write("Enter the parallelogram height: ");
                            float Ph = float.Parse(Console.ReadLine());
                            shapes[i] = new Parallelogram(Pb, Ph);
                            Console.WriteLine($"The parallelogram's area is: {shapes[i].Area()}\n");
                            break;

                        default:
                            Console.WriteLine("Your choice is invalid");
                            break;
                    }
                }

                GeoShape GSh = new GeoShape();
                Console.WriteLine($"Sum of the shapes' areas: {GSh.TotalAreas(shapes)}");
            }
            else
            {
                Console.WriteLine("Invalid integer.");
            }







            //Console.WriteLine("\n---------------------------------Circle---------------------------------");
            //Console.Write("Enter the circle raduis: ");
            //float r = float.Parse(Console.ReadLine());
            //Circle circle = new Circle(r);
            //Console.WriteLine(circle.Area());

            //Console.WriteLine("\n-------------------------------Rectangle---------------------------------");
            //Console.Write("Enter the rectangle width: ");
            //float w = float.Parse(Console.ReadLine());
            //Console.Write("Enter the rectangle hight: ");
            //float h = float.Parse(Console.ReadLine());
            //Rectangle rect = new Rectangle(w, h);
            //Console.WriteLine(rect.Area());
        }
    }
}
