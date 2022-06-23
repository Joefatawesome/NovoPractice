using CarShop.Code.CarShopObjects;

namespace CarShop.Code.Processors.RequestCreation;

public interface IServiceRequestCreator
{
    public WorkOrder CreateRequest(String id, String model, String make, List<Services> servicesList);
}