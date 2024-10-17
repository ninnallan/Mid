using System;
using System.Collections.Generic;
/*შექმენით Generic კლასი "MyCollection<T>". ის უნდა შეიცავდეს შემდეგ მეთოდებს:
მეთოდი "AddItem", რომელიც ამატებს List-ში T ტიპის ელემენტს. მეთოდი "GetItem",
რომელიც აბრუნებს ელემენტს List-დან გადაცემული ინდექსის მიხედვით. 
შექმენით "MyCollection"-ის ობიექტი string  ტიპის Generic-ით და დაამატეთ 
რამდენიმე ელემენტი სიაში. გამოიყენეთ მეთოდი "GetItem", რათა ამოიღოთ და 
ამობეჭდოთ ელემენტი სიიდან მოცემული ინდექსის საფუძველზე.*/
class MyCollection<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public T GetItem(int index)
    {
        return items[index];
    }
}

// Usage
class Program
{
    static void Main()
    {
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
