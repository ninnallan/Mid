/*შექმენით “Item"-ის  შვილობილი კლასი სახელწოდებით "Fruit", 
შემდეგით: ორი private field "_weightInKg"და "_priceOfOneKg" და 
მათი სახელის შესაბამისი property-ები. გადატვირთეთ (Method Overloading)
მეთოდი "CalculateTotalPrice()" კლასში "Fruit" ვერსიით, 
რომელიც იღებს წონისა და ერთი კილოგრამის ფასის ("_priceOfOneKg")
პარამეტრებს და შესაბამისად ითვლის საბოლოო ფასს. 
*/
class Fruit : Item
{
    private double _weightInKg;
    private double _priceOfOneKg;

    public double WeightInKg
    {
        get { return _weightInKg; }
        set { _weightInKg = value; }
    }

    public double PriceOfOneKg
    {
        get { return _priceOfOneKg; }
        set { _priceOfOneKg = value; }
    }

    public Fruit(double price) : base(price) { }

    public double CalculateTotalPrice(double weight, double priceOfOneKg)
    {
        return weight * priceOfOneKg;
    }
}