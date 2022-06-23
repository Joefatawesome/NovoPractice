using CarShop.Code.CarShopObjects;
using CarShop.Code.Processors.RequestCreation;
using NUnit.Framework;

namespace CarShop.Test.RequestCreationTest;

public class ServiceRequestCreatorShould
{
    private ServiceRequestCreator serviceRequestCreator;

    [SetUp]
    public void Init()
    {
        serviceRequestCreator = new ServiceRequestCreator();
    }

    [Test]
    public void CreateAWorkOrder_WhenGivenDesiredInput()
    {
        //Setup
        string testId = "testId";
        string testModel = "areo";
        string testMake = "suzuki";
        List<Services> desiredServices = new List<Services>
        {
            Services.Acceleration
        };

        //Execution
        WorkOrder workOrder = serviceRequestCreator.CreateRequest(testId, testModel, testMake, desiredServices);

        //Validation
        Assert.NotNull(workOrder);
        Assert.NotNull(workOrder.Car);
        Assert.AreEqual(workOrder.Car.Id, testId);
        Assert.AreEqual(workOrder.Car.Model, testModel);
        Assert.AreEqual(workOrder.Car.Make, testMake);
        Assert.NotNull(workOrder.Request);
        Assert.AreEqual(workOrder.Request.Count, 1);
        Assert.True(workOrder.Request.Contains(Services.Acceleration));
    }

    [Test]
    public void CreateAWorkOrder_WhenGivenTwoServices()
    {
        //Setup
        string testId = "testId";
        string testModel = "areo";
        string testMake = "suzuki";
        List<Services> desiredServices = new List<Services>
        {
            Services.Acceleration,
            Services.Deceleration
        };

        //Execution
        WorkOrder workOrder = serviceRequestCreator.CreateRequest(testId, testModel, testMake, desiredServices);

        //Validation
        Assert.NotNull(workOrder);
        Assert.NotNull(workOrder.Car);
        Assert.AreEqual(workOrder.Car.Id, testId);
        Assert.AreEqual(workOrder.Car.Model, testModel);
        Assert.AreEqual(workOrder.Car.Make, testMake);
        Assert.NotNull(workOrder.Request);
        Assert.AreEqual(workOrder.Request.Count, 2);
        Assert.True(workOrder.Request.Contains(Services.Acceleration));
        Assert.True(workOrder.Request.Contains(Services.Deceleration));
    }

    [Test]
    public void Fail_WhenIDIsMissing()
    {
        //Setup
        string testModel = "areo";
        string testMake = "suzuki";
        List<Services> desiredServices = new List<Services>
        {
            Services.Acceleration
        };

        //Validation
        Assert.Throws<ArgumentNullException>(() => serviceRequestCreator.CreateRequest(null, testModel, testMake, desiredServices));
    }

    [Test]
    public void Fail_WhenIDIsEmpty()
    {
        //Setup
        string testModel = "areo";
        string testMake = "suzuki";
        List<Services> desiredServices = new List<Services>
        {
            Services.Acceleration
        };

        //Validation
        Assert.Throws<ArgumentNullException>(() => serviceRequestCreator.CreateRequest("", testModel, testMake, desiredServices));
    }

    [Test]
    public void Fail_WhenModelIsMissing()
    {
        //Setup
        string testId = "testId";
        string testMake = "suzuki";
        List<Services> desiredServices = new List<Services>
        {
            Services.Acceleration
        };

        //Validation
        Assert.Throws<ArgumentNullException>(() => serviceRequestCreator.CreateRequest(testId, null, testMake, desiredServices));
    }

    [Test]
    public void Fail_WhenModelIsEmpty()
    {
        //Setup
        string testId = "testId";
        string testMake = "suzuki";
        List<Services> desiredServices = new List<Services>
        {
            Services.Acceleration
        };

        //Validation
        Assert.Throws<ArgumentNullException>(() => serviceRequestCreator.CreateRequest(testId, "", testMake, desiredServices));
    }

    [Test]
    public void Fail_WhenMakeIsMissing()
    {
        //Setup
        string testId = "testId";
        string testModel = "areo";
        List<Services> desiredServices = new List<Services>
        {
            Services.Acceleration
        };

        //Validation
        Assert.Throws<ArgumentNullException>(() => serviceRequestCreator.CreateRequest(testId, testModel, null, desiredServices));
    }

    [Test]
    public void Fail_WhenMakeIsEmpty()
    {
        //Setup
        string testId = "testId";
        string testModel = "areo";
        List<Services> desiredServices = new List<Services>
        {
            Services.Acceleration
        };

        //Validation
        Assert.Throws<ArgumentNullException>(() => serviceRequestCreator.CreateRequest(testId, testModel, "", desiredServices));
    }

    [Test]
    public void Fail_WhenRequestIsNull()
    {
        //Setup
        string testId = "testId";
        string testModel = "areo";
        string testMake = "suzuki";

        //Validation
        Assert.Throws<ArgumentNullException>(() => serviceRequestCreator.CreateRequest(testId, testModel, testMake, null));
    }

    [Test]
    public void Fail_WhenRequestIsEmpty()
    {
        //Setup
        string testId = "testId";
        string testModel = "areo";
        List<Services> desiredServices = new List<Services>();

        //Validation
        Assert.Throws<ArgumentNullException>(() => serviceRequestCreator.CreateRequest(testId, testModel, "", desiredServices));
    }
}