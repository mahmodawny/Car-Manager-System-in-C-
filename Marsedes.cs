using System;
using System.IO;

public class Marsedes : Cars
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }

    public void Add_Data()
    {
        File.AppendAllText("Marsedes.txt", "The Name : " + this.Name + " The Id: " + this.Id + " The Colour : " + this.Color + " The Price : " + this.Price + "//");
    }

    public string[] Show_Data()
    {
        string data = File.ReadAllText("Marsedes.txt");
        return data.Split(new string[] { "//" }, StringSplitOptions.None);
    }
}