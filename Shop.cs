using System;
using System.Text;
using static System.Console;

namespace HW_OperatorOverloading
{
    public class Shop
    {
        public string? Name { get; set; }
        public string? Year { get; set; }
        public string? Description { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int? Area { get; set; }
        public Shop()
        {
            this.Name = null;
            this.Year = null;
            this.Description = null;
            this.PhoneNumber = null;
            this.Email = null;
            this.Area = null;
        }

        public Shop(string? name, string? year, string? description, string? phoneNumber, string? email, int? area)
        {
            this.Name = name;
            this.Year = year;
            this.Description = description;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Area = area;
        }

        public void EnterInfo()
        {
            WriteLine("Enter data: ");
            Write("Name -> "); Name = ReadLine();
            Write("Year -> "); Year = ReadLine();
            Write("Description -> "); Description = ReadLine();
            Write("Phone number -> "); PhoneNumber = ReadLine();
            Write("Email -> "); Email = ReadLine();
            Write("Area -> "); Area = Convert.ToInt32(ReadLine());
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Info:\n" +
                $" Name -> {Name}\n" +
                $" Year -> {Year}\n" +
                $" Description -> {Description}\n" +
                $" Phone number -> {PhoneNumber}\n" +
                $" Email -> {Email}\n"+
                $" Area -> {Area}");
        }

        public static int operator +(Shop sh, int num)
        {
            return ((int)(sh.Area += num));
        }
        public static int operator -(Shop sh, int num)
        {
            return ((int)(sh.Area -= num));
        }
        public static bool operator ==(Shop sh1, Shop sh2)
        {
            return sh1.Equals(sh2);
        }

        public static bool operator !=(Shop sh1, Shop sh2)
        {
            return !(sh1 == sh2);
        }

        public static bool operator <(Shop sh1, Shop sh2)
        {
            return (sh1.Area < sh2.Area);
        }
        public static bool operator >(Shop sh1, Shop sh2)
        {
            return (sh1.Area > sh2.Area);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

    }
}
