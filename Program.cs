//class Car // Exercise 1
//{
//    private string brand;
//    private int year;
//    private float price;


//    public Car(string brand, int year, float price) // Constructor
//    {
//        this.brand = brand;
//        this.year = year;
//        this.price = price;
//    }

//    public void PrintCarDetails()
//    {
//        Console.WriteLine("Brand: " + brand);
//        Console.WriteLine("Year: " + year);
//        Console.WriteLine("Price: " + price);
//    }
//    static void Main(string[] args)
//    {
//        //Instance of the Car
//        Car car = new Car("Rolls Royce", 2003, 250000.0f);
//        //Car details
//        car.PrintCarDetails();
//    }

//}

//Excercise 2
//using System;

//public class BankAccount
//{
//    private string accountNumber;
//    private decimal balance;

//    // Constructor
//    public BankAccount(string accountNumber)
//    {
//        this.accountNumber = accountNumber;
//        this.balance = 0;
//    }

//    public void Deposit(decimal amount)
//    {
//        balance += amount;
//    }

//    public void Withdraw(decimal amount)
//    {
//        if (balance >= amount)
//        {
//            balance -= amount;
//        }
//        else
//        {
//            Console.WriteLine("Insufficient balance.");
//        }
//    }

//    public decimal GetBalance()
//    {
//        return balance;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // instance of the BankAccount class
//        BankAccount myAccount = new BankAccount("1111111111");

//        // deposit of 1000 units
//        myAccount.Deposit(1000);

//        // Withdraw 500 units
//        myAccount.Withdraw(500);

//        // Print out the final balance
//        Console.WriteLine("Final Balance: " + myAccount.GetBalance());
//    }
//}

//Exercise 3

//using System;

//public class Rectangle
//{
//    private float length;
//    private float width;

//    // Constructor
//    public Rectangle(float length, float width)
//    {
//        this.length = length;
//        this.width = width;
//    }

//    public float Area()
//    {
//        return length * width;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // instance of the Rectangle class
//        Rectangle myRectangle = new Rectangle(5.5f, 2.9f);

//        //  print out the area
//        float area = myRectangle.Area();
//        Console.WriteLine("Area of Rectangle is: " + area);
//    }
//}

//Exercise 4

//using System;

//public class Shape
//{
//    public virtual float CalculateArea()
//    {
//        return 0;
//    }
//}

//public class Circle : Shape
//{
//    private float radius;

//    public Circle(float radius)
//    {
//        this.radius = radius;
//    }

//    public override float CalculateArea()
//    {
//        return (float)(Math.PI * Math.Pow(radius, 8));
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Circle Circle = new Circle(9);
//        float area = Circle.CalculateArea();
//        Console.WriteLine("Area of the circle: " + area);
//    }
//}

//Exercise 5

//using System;

//public class Student
//{
//    private string name;
//    private int age;
//    private string major;

//    public Student(string name, int age, string major)
//    {
//        this.name = name;
//        this.age = age;
//        this.major = major;
//    }

//    public void Introduce()
//    {
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("Age: " + age);
//        Console.WriteLine("Major: " + major);
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Student myStudent = new Student("Anil Tajpuriya", 22, "Computing");
//        myStudent.Introduce();
//    }
//}

// Exercise 6

//using System;
//using System.Collections.Generic;

//public class Stack<T>
//{
//    private List<T> items;

//    public Stack()
//    {
//        items = new List<T>();
//    }

//    public void Push(T item)
//    {
//        items.Add(item);
//    }

//    public T Pop()
//    {
//        if (IsEmpty())
//        {
//            throw new InvalidOperationException("Stack is empty");
//        }

//        int lastIndex = items.Count - 1;
//        T item = items[lastIndex];
//        items.RemoveAt(lastIndex);
//        return item;
//    }

//    public T Peek()
//    {
//        if (IsEmpty())
//        {
//            throw new InvalidOperationException("Stack is empty");
//        }

//        return items[items.Count - 1];
//    }

//    public bool IsEmpty()
//    {
//        return items.Count == 0;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Stack<int> myStack = new Stack<int>();

//        myStack.Push(1);
//        myStack.Push(2);
//        myStack.Push(3);

//        Console.WriteLine("Peek: " + myStack.Peek());

//        Console.WriteLine("Popped item: " + myStack.Pop());

//        Console.WriteLine("Peek: " + myStack.Peek());

//        Console.WriteLine("Popped item: " + myStack.Pop());

//        Console.WriteLine("Peek: " + myStack.Peek());

//        Console.WriteLine("Popped item: " + myStack.Pop());

//        Console.WriteLine("Is stack empty? " + myStack.IsEmpty());
//    }
//}

//Exercise 7

//using System;

//public class Calendar
//{
//    public enum DaysOfWeek
//    {
//        Monday,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }

//    public void PrintWeekdays()
//    {
//        for (int i = (int)DaysOfWeek.Monday; i <= (int)DaysOfWeek.Friday; i++)
//        {
//            Console.WriteLine((DaysOfWeek)i);
//        }
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Calendar myCalendar = new Calendar();
//        myCalendar.PrintWeekdays();
//    }
//}

//Exercise 8 

//using System;

//public struct Point2D
//{
//    public float x;
//    public float y;
//}

//public class Calculation
//{
//    public static float CalculateDistance(Point2D point1, Point2D point2)
//    {
//        float xDiff = point2.x - point1.x;
//        float yDiff = point2.y - point1.y;
//        return (float)Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Point2D point1 = new Point2D { x = 9, y = 6 };
//        Point2D point2 = new Point2D { x = 7, y = 9 };

//        float distance = Calculation.CalculateDistance(point1, point2);
//        Console.WriteLine("Distance: " + distance);
//    }
//}