namespace CarShop.Code.CarShopObjects;

public class WorkOrder
{
    public Car Car { get; }
    public List<Services> Request { get; }

    public WorkOrder(Car car, List<Services> request)
    {
        Car = car;
        Request = request;
    }
}