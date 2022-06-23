using CarShop.Code.CarShopObjects;

namespace CarShop.Code.Processors.RequestCreation;

public class ServiceRequestCreator : IServiceRequestCreator
{
    public WorkOrder CreateRequest(String id, String model, String make, List<Services> servicesList)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentNullException("Id is null or empty.");
        }
        if (string.IsNullOrEmpty(model))
        {
            throw new ArgumentNullException("model is null or empty.");
        }
        if (string.IsNullOrEmpty(make))
        {
            throw new ArgumentNullException("make is null or empty.");
        }

        if (servicesList == null || servicesList.Count == 0)
        {
            throw new ArgumentNullException("servicesList is null or empty.");
        }

        Car car = new Car(id, make, model);
        return new WorkOrder(car, servicesList);
    }
}