using System;

class Apartment
{
    public string Name { get; set; }
    public static explicit operator House(Apartment a)
    {
        return new House() { Name = a.Name };
    }
}

class House
{
    public string Name { get; set; }
    public static explicit operator Apartment(House h)
    {
        return new Apartment() { Name = h.Name };
    }
}

class Program
{
    static void Main()
    {
        House h = new House();
        h.Name = "Broadway";

        // Cast a House to an Apartment.
        Apartment a = (Apartment)h;

        // Apartment was converted from House.
        Console.WriteLine(a.Name);
    }
}
