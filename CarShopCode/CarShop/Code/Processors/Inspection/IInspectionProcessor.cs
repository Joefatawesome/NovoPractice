using CarShop.Code.CarShopObjects;

namespace CarShop.Code.Processors.Inspection;

public interface IInspectionProcessor
{
    public InspectionResult Inspect(WorkOrder workOrder);
}