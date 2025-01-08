public class Order
{
    public int id {get; set;}
    public string status {get; set;} = string.Empty;
    public string paymentMethod {get; set;} = string.Empty;
    public int recruiterId {get; set;}
    public int divisionId {get; set;}
    public int companyId {get; set;}
    public bool validated {get; set;}
    public string created {get; set;} = string.Empty;
    public string completed {get; set;} = string.Empty;
    public List<Items> items {get; set;} = new List<Items>(); 
}

public class Items
{

    public int id {get; set;}
    public int siteId {get; set;}
    public int productId {get; set;}
    public string currency {get; set;} = string.Empty;
    public string paymentMethod {get; set;} = string.Empty;
    public int retailCost {get; set;}
    public int accountDiscount {get; set;}
    public int netCost {get; set;}
    public JobData jobData {get; set;} = new JobData();
}

public class JobData
{
    public int jobId {get; set;}
    public int postingId {get; set;}
    
}