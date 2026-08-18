using System;

namespace InterfaceLab
{
    // =====================================================
    // EXERCISE 1 - BASIC INTERFACE IMPLEMENTATION
    // =====================================================

    public interface IMovable
    {
        void Move();
        void Stop();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped.");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is pedaling.");
        }

        public void Stop()
        {
            Console.WriteLine("Bicycle has stopped.");
        }
    }


    // =====================================================
    // EXERCISE 2 - INTERFACE WITH PROPERTIES
    // =====================================================

    public interface IShape
    {
        double Area { get; }

        void Draw();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }


    // =====================================================
    // EXERCISE 3 - IMPLEMENTING MULTIPLE INTERFACES
    // =====================================================

    public interface IWorker
    {
        void PerformWork();
    }

    public interface ILeader
    {
        void LeadTeam();
        void MakeReports();
    }

    public class ProjectManager : IWorker, ILeader
    {
        public void PerformWork()
        {
            Console.WriteLine("Project Manager is performing work.");
        }

        public void LeadTeam()
        {
            Console.WriteLine("Project Manager is leading the team.");
        }

        public void MakeReports()
        {
            Console.WriteLine("Project Manager is creating reports.");
        }
    }


    // =====================================================
    // MAIN PROGRAM
    // =====================================================

    class Program
    {
        static void Main(string[] args)
        {
            // =================================================
            // EXERCISE 1
            // =================================================

            Console.WriteLine("===== EXERCISE 1 =====");
            Console.WriteLine();

            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Move();
            car.Stop();

            Console.WriteLine();

            bicycle.Move();
            bicycle.Stop();


            // =================================================
            // EXERCISE 2
            // =================================================

            Console.WriteLine();
            Console.WriteLine("===== EXERCISE 2 =====");
            Console.WriteLine();

            Circle circle = new Circle();

            circle.Radius = 5;

            circle.Draw();

            Console.WriteLine("Circle Area: " + circle.Area);


            Console.WriteLine();


            Rectangle rectangle = new Rectangle();

            rectangle.Width = 4;
            rectangle.Height = 6;

            rectangle.Draw();

            Console.WriteLine("Rectangle Area: " + rectangle.Area);


            // =================================================
            // EXERCISE 3
            // =================================================

            Console.WriteLine();
            Console.WriteLine("===== EXERCISE 3 =====");
            Console.WriteLine();

            ProjectManager manager = new ProjectManager();

            manager.PerformWork();
            manager.LeadTeam();
            manager.MakeReports();


            Console.ReadLine();
        }
    }
}
