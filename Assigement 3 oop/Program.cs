using System;

namespace Assignment03OOP
{
    // ==========================================
    // Q10: Interfaces Creation
    // ==========================================
    public interface IMoveable
    {
        void MoveForward();
        void MoveBackward();
    }

    public interface IFlyable
    {
        void MoveUp();
        void MoveDown();
    }

    // ==========================================
    // Q11 & Q14: Implementation in Classes
    // ==========================================
    public class Car : IMoveable
    {
        public void MoveForward() => Console.WriteLine("Car is moving forward on the ground.");
        public void MoveBackward() => Console.WriteLine("Car is moving backward on the ground.");
    }

    public class Ship : IMoveable
    {
        // Q14: Explicit interface implementation
        void IMoveable.MoveForward() => Console.WriteLine("Ship is moving forward on the sea (Explicit Implementation).");

        public void MoveBackward() => Console.WriteLine("Ship is moving backward on the sea.");
    }

    public class Airplane : IMoveable, IFlyable
    {
        public void MoveForward() => Console.WriteLine("Airplane is moving forward.");
        public void MoveBackward() => Console.WriteLine("Airplane is moving backward.");
        public void MoveUp() => Console.WriteLine("Airplane is flying up in the air.");
        public void MoveDown() => Console.WriteLine("Airplane is flying down.");
    }

    // ==========================================
    // Q13: Interface Inheritance
    // ==========================================
    public interface IVehicle : IMoveable, IFlyable
    {
        // Inherits all 4 methods without adding new ones
    }

    public class Vehicle : IVehicle
    {
        public virtual void MoveForward() => Console.WriteLine("Vehicle moving forward.");
        public virtual void MoveBackward() => Console.WriteLine("Vehicle moving backward.");
        public virtual void MoveUp() => Console.WriteLine("Vehicle moving up.");
        public virtual void MoveDown() => Console.WriteLine("Vehicle moving down.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Q12: Concrete Types
            Console.WriteLine("--- Concrete Types ---");
            Car myCar = new Car();
            Airplane myPlane = new Airplane();

            myCar.MoveForward();
            myPlane.MoveUp();

            // Q12: Interface References
            Console.WriteLine("\n--- Interface References ---");
            IMoveable carRef = new Car();
            IMoveable planeRef = new Airplane();

            carRef.MoveForward();
            planeRef.MoveForward();
            // planeRef.MoveUp(); 

            // Q14: Explicit Implementation
            Console.WriteLine("\n--- Explicit Implementation ---");
            Ship myShip = new Ship();
            // myShip.MoveForward(); 
            ((IMoveable)myShip).MoveForward();

            Console.ReadLine();
        }
    }
}