namespace CarShop.Code.CarShopObjects;

public class RepairQueue
{
    public List<WorkOrder> WorkOrders { get; }
    
    public void AddWorkOrder(WorkOrder workOrder)
    {
        WorkOrders.Add(workOrder);
    }
}