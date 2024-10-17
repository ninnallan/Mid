using System;
/*განსაზღვრეთ int ცვლადი სახელწოდებით "quantity" და მოახდინეთ 
ინიციალიზაცია (e.g., 7). განსაზღვრეთ string ცვლადი სახელად "itemName" 
და მოახდინეთ ინიციალიზაცია რაიმე პროდუქტის სახელის მიხედვით
 (e.g., "Widget"). დაწერეთ ციკლი, რომელიც აკეთებს იტერაციას 1-დან 5-ის 
 ჩათვლით და ციკლის შიგნით დაბეჭდეთ შეტყობინება, რომელიც შეიცავს 
 პროდუქტის სახელს და მიმდინარე ციკლის ინდექსს.
*/
class Program
{
    static void Main()
    {
        int quantity = 7;
        string itemName = "Widget";

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Product: {itemName}, Index: {i}");
        }
/*Usage of Employee*/        
    Employee emp = new Employee("John Doe", "50000");
        Console.WriteLine(emp.DisplayInfo());

/*Usage of Item*/

/*შექმენით "Fruit" და "Electronics" კლასების ობიექტები, გამოთვალეთ 
და დაბეჭდეთ როგორც ხილის, ასევე ელექტრონული ნივთის ჯამური ფასები 
გადატვირთული "CalculateTotalPrice()" მეთოდების გამოყენებით.
*/
        Fruit fruit = new Fruit(0);
        fruit.WeightInKg = 2;
        fruit.PriceOfOneKg = 5;
        Console.WriteLine($"Total price of fruit: {fruit.CalculateTotalPrice(fruit.WeightInKg, fruit.PriceOfOneKg)}");

        Electronics electronics = new Electronics(0);
        electronics.Quantity = 3;
        electronics.OneUnitPrice = 100;
        Console.WriteLine($"Total price of electronics: {electronics.CalculateTotalPrice(electronics.Quantity, electronics.OneUnitPrice)}");

/*Usage of Bird*/
/*შექმენით "Sparrow" და "Pigeon"" კლასების ობიექტები და
 გამოიძახეთ მათი "MakeSound()" მეთოდი.*/
        Bird sparrow = new Sparrow();
        Bird pigeon = new Pigeon();
        
        Console.WriteLine(sparrow.MakeSound());
        Console.WriteLine(pigeon.MakeSound());

/*Usage of Mycollection*/
/*შექმენით "MyCollection"-ის ობიექტი string  ტიპის Generic-ით და დაამატეთ 
რამდენიმე ელემენტი სიაში. გამოიყენეთ მეთოდი "GetItem", რათა ამოიღოთ და 
ამობეჭდოთ ელემენტი სიიდან მოცემული ინდექსის საფუძველზე.*/
        MyCollection<string> myStringCollection = new MyCollection<string>();
        myStringCollection.AddItem("Apple");
        myStringCollection.AddItem("Banana");
        
        Console.WriteLine(myStringCollection.GetItem(0)); // Output: Apple
        Console.WriteLine(myStringCollection.GetItem(1)); // Output: Banana
    }
}
