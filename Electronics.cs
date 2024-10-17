
/*შექმენით შვილობილი კლასი სახელწოდებით "Electronics", რომელიც ასევე
მემკვიდრეობით იღებს “Item"-ს შემდეგით: private int field "_quantity” 
და private double field "_oneUnitPrice” მათი შესაბამისი property. 
გადატვირთეთ "CalculateTotalPrice()" მეთოდი "Electronics" 
კლასში ვერსიით, რომელიც იღებს ერთეულის ფასის და რაოდენობის
პარამეტრსდა შესაბამისად ითვლის საბოლოო ფასს.
*/
class Electronics : Item
{
    private int _quantity;
    private double _oneUnitPrice;

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public double OneUnitPrice
    {
        get { return _oneUnitPrice; }
        set { _oneUnitPrice = value; }
    }

    public Electronics(double price) : base(price) { }

    public double CalculateTotalPrice(int quantity, double unitPrice)
    {
        return quantity * unitPrice;
    }
}