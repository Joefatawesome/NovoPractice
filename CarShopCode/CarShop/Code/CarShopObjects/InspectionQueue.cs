namespace CarShop.Code.CarShopObjects;

public class InspectionQueue
{
    public List<WorkOrder> WorkOrders { get; }

    public void AddWorkOrder(WorkOrder workOrder)
    {
        WorkOrders.Add(workOrder);
    }
}