namespace Clean.Domain;

public class Item
{
    public int ItemId {get; set;}
    public string Name {get; set;} = string.Empty;
    public CategoryList Category {get; set;} = CategoryList.Books;
    public int amount {get; set;}
    public string Description {get; set;} = string.Empty;
    public double Prise {get; set;}
    public Workflow Availability {get; set;} = Workflow.Available;
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