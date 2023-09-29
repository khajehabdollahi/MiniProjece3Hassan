// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;
using System.Reflection;

Console.WriteLine("Hi! \n Here is my third mini project \n I want to share somthing now: \n The base need to be a good programmer is high concentration that \n " +
    "that I am not verey good at it. But I have a verey good news for myself.\n Today morning I watched a scientific documentary about the \n" +
    "the human what I learnt is man is able to train the brain. \n Now I want to start brain excercises for more concentration\n Let's start");

// Defining the number each sold ones.
int soldItemNumbers = 0;
int soldComputerNumbers =0;
int soldMobileNumber =0;


// here three lists are being created: sold Items, computers and mobile

List<Items> items = new List<Items>
{
    new Computer("Computer", "Samsung", "SD", Convert.ToDateTime("2019-10-11"), "Spain", 1000),
    new Mobile("Mobile", "IPhone", "12", Convert.ToDateTime("2018-11-11"), "Sweden", 100),
    new Computer("Computer", "Levond", "SD", Convert.ToDateTime("2002-10-10"), "Spain", 1000),
    new Computer("Mobile", "HP", "SD", Convert.ToDateTime("2023-03-10"), "England", 700),
    new Computer("Computer", "Macbook", "SD", Convert.ToDateTime("2023-08-10"), "Sweden", 300),
    new Computer("Computer", "Asus", "SD", Convert.ToDateTime("2019-10-10"), "Sweden", 800),
    new Computer("Mobile", "Moterolla", "SD", Convert.ToDateTime("2023-07-10"), "Spain", 120),
    new Computer("Mobile", "Moterolla", "SD", Convert.ToDateTime("2023-07-09"), "England", 400),
    new Computer("Computer", "Samsung", "SD", Convert.ToDateTime("2022-11-05"), "Spain", 1500),
    new Computer("MObile", "Samsung", "SD", Convert.ToDateTime("2021-11-07"), "Finland", 1000),
    new Computer("MObile", "Iphone", "SD", Convert.ToDateTime("2023-09-22"), "Brasil", 1000),
    new Computer("Computer", "Samsung", "SD", Convert.ToDateTime("2023-08-23"), "Taiwan", 1000),
    new Computer("MObile", "Samsung", "SD", Convert.ToDateTime("2020-12-10"), "USA", 1000),
};
    

//Computer c1 = new Computer("Computer", "Samsung", "SD", Convert.ToDateTime("2020-10-10"), "Spain", 1000);
//Mobile m1 = new Mobile("Mobile", "IPhone", "12", Convert.ToDateTime("2021-11-11"), "Sweden", 100);

//items.Add(c1);
//items.Add(m1);

Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "PurchaseDate".PadRight(15) + "Office".PadRight(15) + "Price");

foreach (var item in items) 
{
    
    Console.WriteLine(item.Type.PadRight(15) + item.Brand.PadRight(15) + item.Model.PadRight(15) + item.Date.ToString("yyyy-MM-dd").PadRight(15) + item.Office.PadRight(15) + item.Price);
}


/*
Items

    
repeat;
Console.WriteLine("Hi! Welcome to your office DataBase\n you can decide to enter information  or show informations\n " +
    "To enter information about computer press 1  \n To enter information about mobile press 2 " +
    "\n To show the all sold list press 3\n To quit press any key"); 

int chooseKey= Convert.ToInt32(Console.ReadLine());

if(chooseKey==1)
{
    


    Console.WriteLine("Information will be added to Computers");
    goto repeat;
}if(chooseKey==2)
{
    Console.WriteLine("Informcomation will be added to Mobiles");
    goto repeat;
}
if(chooseKey==3)
{
    Console.WriteLine("Information will be added to Computers");
    goto repeat;
}
else
{
    Console.WriteLine("You quit now");
}
*/

Console.ReadLine(); 

// here I create a parent class
class Items
{    
    public string Type{ get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateTime Date { get; set; }
    public string Office { get; set; }
    public int Price { get; set; }
    
    
}
// Two cildren classes are being created for computer and mobile with Items parent

class Computer : Items
{
    public Computer(string type, string brand, string model, DateTime date, string office, int price)
    {
        Type = type;
        Brand = brand;
        Model = model;
        Date = date;
        Office = office;
        Price = price;
    }
}

class Mobile : Items
{
    public Mobile(string type, string brand, string model, DateTime date, string office, int price)
    {
        Type = type;
        Brand = brand;
        Model = model;
        Date = date;
        Office = office;
        Price = price;
    }
}