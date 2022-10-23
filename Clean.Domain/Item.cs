namespace Clean.Domain;

public class Item
{
    public int ItemId {get; set;}
    public string? Name {get; set;}
    public CategoryList Category {get; set;}
    public int amount {get; set;}
    public string? Description {get; set;}
    public double Prise {get; set;}
    public Workflow Availability {get; set;}
}

public enum CategoryList
{
    Kitchen,
    Cosmetic,
    Hair,
    Clothing,
    Excersice,
    Books,
    Shoes
}
public enum Workflow {
    Booked,
    SoldOut,
    Available
}