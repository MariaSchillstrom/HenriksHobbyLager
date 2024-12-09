
public interface IProduct
{
    string Category { get; set; }
    DateTime Created { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    decimal Price { get; set; }
    int Stock { get; set; }
    DateTime Updated { get; set; }
}