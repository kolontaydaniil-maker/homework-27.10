//Задание 1
//using System;

//class Website
//{
//    private string name;
//    private string path;
//    private string description;
//    private string address;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public string Path
//    {
//        get { return path; }
//        set { path = value; }
//    }

//    public string Description
//    {
//        get { return description; }
//        set { description = value; }
//    }

//    public string Address
//    {
//        get { return address; }
//        set { address = value; }
//    }

//    public void Input()
//    {
//        Console.Write("Enter name: ");
//        name = Console.ReadLine();

//        Console.Write("Enter path: ");
//        path = Console.ReadLine();

//        Console.Write("Enter description: ");
//        description = Console.ReadLine();

//        Console.Write("Enter address: ");
//        address = Console.ReadLine();
//    }

//    public override string ToString()
//    {
//        return "Name: " + name +
//               "\nPath: " + path +
//               "\nDescription: " + description +
//               "\nAddress: " + address;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Website website = new Website();
//        website.Input();
//        Console.WriteLine(website);
//    }
//}

//Задание 2
//using System;

//class Magazine
//{
//    private string name;
//    private int year;
//    private string description;
//    private string phone;
//    private string email;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Year
//    {
//        get { return year; }
//        set { year = value; }
//    }

//    public string Description
//    {
//        get { return description; }
//        set { description = value; }
//    }

//    public string Phone
//    {
//        get { return phone; }
//        set { phone = value; }
//    }

//    public string Email
//    {
//        get { return email; }
//        set { email = value; }
//    }

//    public void Input()
//    {
//        Console.Write("Enter name: ");
//        name = Console.ReadLine();

//        Console.Write("Enter foundation year: ");
//        year = int.Parse(Console.ReadLine());

//        Console.Write("Enter description: ");
//        description = Console.ReadLine();

//        Console.Write("Enter phone: ");
//        phone = Console.ReadLine();

//        Console.Write("Enter email: ");
//        email = Console.ReadLine();
//    }

//    public override string ToString()
//    {
//        return "Name: " + name +
//               "\nYear: " + year +
//               "\nDescription: " + description +
//               "\nPhone: " + phone +
//               "\nEmail: " + email;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Magazine magazine = new Magazine();
//        magazine.Input();
//        Console.WriteLine(magazine);
//    }
//}

//Задание 3

using System;

class Shop
{
    private string name;
    private string address;
    private string description;
    private string phone;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public void Input()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();

        Console.Write("Enter address: ");
        address = Console.ReadLine();

        Console.Write("Enter description: ");
        description = Console.ReadLine();

        Console.Write("Enter phone: ");
        phone = Console.ReadLine();

        Console.Write("Enter email: ");
        email = Console.ReadLine();
    }

    public override string ToString()
    {
        return "Name: " + name +
               "\nAddress: " + address +
               "\nDescription: " + description +
               "\nPhone: " + phone +
               "\nEmail: " + email;
    }
}

class Program
{
    static void Main()
    {
        Shop shop = new Shop();
        shop.Input();
        Console.WriteLine(shop);
    }
}