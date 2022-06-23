namespace CarShop.Code;

public class WorkOrder
{
    private List<Services> _request;

    public WorkOrder(List<Services> request)
    {
        _request = request;
    }
}