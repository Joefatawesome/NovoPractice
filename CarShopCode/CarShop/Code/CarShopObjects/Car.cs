namespace CarShop.Code.CarShopObjects;

public class Car
{
    public Car(string id, string make, string model)
    {
        Id = id;
        Make = make;
        Model = model;
    }
    public string Id { get; }
    public string Make { get; }
    public string Model { get; }
}