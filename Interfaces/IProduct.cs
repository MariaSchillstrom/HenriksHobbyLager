
public interface IProduct //Skapade denna för enklare implemetering i framtiden av eventuellt nya klasser med samma properties
{
    string Category { get; set; }
    DateTime Created { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    decimal Price { get; set; }
    int Stock { get; set; }
    DateTime Updated { get; set; }
}