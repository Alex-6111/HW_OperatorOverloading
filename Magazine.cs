
using System;
using System.Text;
using static System.Console;

namespace HW_OperatorOverloading
{
    public class Magazine
    {
        public string? Name { get; set; }
        public string? Year { get; set; }
        public string? Description { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int? QuantityEmployees { get; set; }
        public Magazine()
        {
            this.Name = null;
            this.Year = null;
            this.Description = null;
            this.PhoneNumber = null;
            this.Email = null;
            this.QuantityEmployees = null;
        }

        public Magazine(string? name, string? year, string? description, string? phoneNumber, string? email, int? quantityEmployees) : this()
        {
            Name = name;
            Year = year;
            Description = description;
            PhoneNumber = phoneNumber;
            Email = email;
            QuantityEmployees = quantityEmployees;
        }

        public void EnterInfo()
        {
            WriteLine("Enter data: ");
            Write("Name -> "); Name = ReadLine();
            Write("Year -> "); Year = ReadLine();
            Write("Description -> "); Description = ReadLine();
            Write("Phone number -> "); PhoneNumber = ReadLine();
            Write("Email -> "); Email = ReadLine();
            Write("Quantity employees -> "); QuantityEmployees = Convert.ToInt32(ReadLine());
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Info:\n" +
                $" Name -> {Name}\n" +
                $" Year -> {Year}\n" +
                $" Description -> {Description},\n " +
                $" Phone number -> {PhoneNumber} \n" +
                $" Email -> {Email}\n" +
                $" Quantity employees -> {QuantityEmployees}");
        }
        public static int operator +(Magazine mgz, int num)
        {
            return ((int)(mgz.QuantityEmployees += num));
        }
        public static int operator -(Magazine mgz, int num)
        {
            return ((int)(mgz.QuantityEmployees -= num));
        }
        public static bool operator ==(Magazine mgz1, Magazine mgz2)
        {
            return mgz1.Equals(mgz2);
        }

        public static bool operator != (Magazine mgz1, Magazine mgz2)
        {
            return !(mgz1 == mgz2);
        }
        
        public static bool operator < (Magazine mgz1, Magazine mgz2)
        {
            return (mgz1.QuantityEmployees < mgz2.QuantityEmployees);
        }
        public static bool operator > (Magazine mgz1, Magazine mgz2)
        {
            return (mgz1.QuantityEmployees > mgz2.QuantityEmployees);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}

