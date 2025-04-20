using System.ComponentModel.DataAnnotations;

namespace Application.Domain;

public class Item
{
    [Key]
    public int Id { get; protected set; }
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Quantity { get; protected set; }

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }
}