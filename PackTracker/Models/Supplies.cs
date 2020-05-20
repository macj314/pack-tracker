namespace PackTracker.Models
{
  public class Supplies
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int ID { get; set; }
    public Supplies(string name, string description, int price, int id)
    {
      Name = name;
      Description = description;
      Price = price;
      ID = id;
    }
  }
}