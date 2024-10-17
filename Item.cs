/*შექმენით კლასი სახელწოდებით "Item" შემდეგით: 
protected double property "Price". კონსტრუქტორი,
 რომელიც ახდენს "Price"-ის ინიციალიზაციას და ანიჭებს 0-ს. 
*/
class Item
{
    protected double Price { get; set; }

    public Item(double price)
    {
        Price = price;
    }
}
