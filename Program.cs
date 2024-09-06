Console.WriteLine("Hello, World!");

var sale = new Sale(15.0f);

Console.WriteLine(sale.GetInfo());

var saleWithTax = new SaleWithTax(20.0f, 1.15f);

Console.WriteLine(saleWithTax.GetInfo());

saleWithTax.Tax = 1.23f;
Console.WriteLine(saleWithTax.GetInfo("Francia"));

class Sale { 
    public float Price {  get; private set; }

    public Sale(float price) {
        Price = price;
    }

    public virtual string GetInfo()
    {
        return "El precio es: " + Price;
    }
}

class SaleWithTax: Sale
{
    public float Tax { get; set; }

    public SaleWithTax(float price, float tax): base(price)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return "El precio es: " + this.Price * Tax;
    }

    public string GetInfo(string tienda)
    {
        return "El precio en la tienda: " + tienda + " es: " + this.Price * Tax;
    }
}