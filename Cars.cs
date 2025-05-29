public interface Cars{
  public string Name { get; set; }
  public int Id { get; set; }
  public string Color { get; set; }
  public double Price { get; set; }
 public void Add_Data();
  string [] Show_Data();
}