using CarShop.Code.CarShopObjects;

namespace CarShop.Code.Processors.RequestCreation;

public class ServiceRequestCreator : IServiceRequestCreator
{
    public WorkOrder CreateRequest(String Id, String model, String make, List<Services> servicesList)
    {
        throw new NotImplementedException();
    }
}