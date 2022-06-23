using CarShop.Code.CarShopObjects;

namespace CarShop.Code.Processors.Repair;

public interface IRepairProcessor
{
    public IRepairVehicle Repair(WorkOrder workOrder);
}