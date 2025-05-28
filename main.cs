    using System;
    using System.IO;
    public interface Cars{
      public string Name { get; set; }
      public int Id { get; set; }
      public string Color { get; set; }
      public double Price { get; set; }
     public void Add_Data();
      string [] Show_Data();
    }
    public class Marsedes : Cars
    {
      public string Name { get; set; }
      public int Id { get; set; }
      public string Color { get; set; }
      public double Price { get; set; }
     public void Add_Data(){
        File.AppendAllText("Marsedes.txt","The Name : "+this.Name + " The Id: " + this.Id + " The Colour : " + this.Color + " The Price : " + this.Price + "//");
      }
      public string [] Show_Data(){
        string data = File.ReadAllText("Marsedes.txt");
        return data.Split(new string[] { "//" }, StringSplitOptions.None);
      }
      }
    public class Benz : Cars
      {
        public string Name { get; set; }
          public int Id { get; set; }
          public string Color { get; set; }
          public double Price { get; set; }
         public void Add_Data(){
           File.AppendAllText("Benz.txt","The Name : "+this.Name + " The Id: " + this.Id + " The Colour : " + this.Color + " The Price : " + this.Price + "//");
      }
        public string [] Show_Data(){
          string data = File.ReadAllText("Benz.txt");
          return data.Split(new string[] { "//" }, StringSplitOptions.None);
        }
    }
    public class Audi : Cars
        {
          public string Name { get; set; }
            public int Id { get; set; }
            public string Color { get; set; }
            public double Price { get; set; }
           public void Add_Data(){
             File.AppendAllText("Audi.txt","The Name : "+this.Name + " The Id: " + this.Id + " The Colour : " + this.Color + " The Price : " + this.Price + "//");
        }
          public string [] Show_Data(){
            string data = File.ReadAllText("Audi.txt");
            return data.Split(new string[] { "//" }, StringSplitOptions.None);
          }
    }
    class Program {
      public static void Main (string[] args) 
      {
        string answer;
        do{
          Console.Clear();
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("*******  Menu Of Cars  *******"+
          "\n 1-Marsedes"+
          "\n 2-Benz"+
          "\n 3-Audi"+
          "\n 4- Show Data Form Marsedes"+
          "\n 5- Show Data Form Benz"+
          "\n 6- Show Data Form Audi"+
          "\n 7- Search About Car By ID");
        Console.WriteLine("Enter Your Choise :");
          int Choise = int.Parse(Console.ReadLine());
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
          string name ="", color ="";
          int id = 0;
          double price =0 ;
          if(Choise == 1 || Choise == 2 || Choise == 3){
        Console.WriteLine("Enter The Name Of Car :");
         name = Console.ReadLine();
        Console.WriteLine("Enter The ID Of Car :");
         id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter The Color Of Car :");
         color = Console.ReadLine();
        Console.WriteLine("Enter The Price Of Car :");
         price = double.Parse(Console.ReadLine());
            Console.WriteLine("Data Added Successfully");
            }
        switch (Choise){
          case 1:
          Marsedes m = new Marsedes();
          m.Name = name;
          m.Id = id;
          m.Color = color;
          m.Price = price;
          m.Add_Data();
          break;
          case 2:
          Benz b = new Benz();
          b.Name = name;
          b.Id = id;
          b.Color = color;
          b.Price = price;
          b.Add_Data();
          break;
          case 3:
          Audi a = new Audi();
          a.Name = name;
          a.Id = id;
          a.Color = color;
          a.Price = price;
          a.Add_Data();
          break;
          case 4:
          Marsedes m1 = new Marsedes();
          string [] data = m1.Show_Data();
          for(int i = 0 ; i < data.Length ; i++){
            Console.WriteLine(data[i]);           
          }
          break;
          case 5:
          Benz b1 = new Benz();
          string [] data1 = b1.Show_Data();
          for(int i = 0 ; i < data1.Length ; i++){
            Console.WriteLine(data1[i]);
          }
          break;
          case 6:
            Audi a1 = new Audi();
            string [] data2 = a1.Show_Data();
            for(int i = 0 ; i < data2.Length ; i++){
              Console.WriteLine(data2[i]);
            }
          break;
          case 7:
          Console.WriteLine("Enter The ID Of Car :");
          int id1 = int.Parse(Console.ReadLine());
          Marsedes m2 = new Marsedes();
          string [] data3 = m2.Show_Data();
          for(int i = 0 ; i < data3.Length ; i++){
            if(data3[i].Contains(id1.ToString())){
              Console.WriteLine(data3[i]);
              break;
            }
          }
          Benz b2 = new Benz();
          string [] data4 = b2.Show_Data();
          for(int i = 0 ; i < data4.Length ; i++){
            if(data4[i].Contains(id1.ToString())){              
              Console.WriteLine(data4[i]);              
              break;
            }
          }
          Audi a2 = new Audi();
          string [] data5 = a2.Show_Data();
          for(int i = 0 ; i < data5.Length ; i++){
            if(data5[i].Contains(id1.ToString()))
            {
              Console.WriteLine(data5[i]);
              break;
            }
          }
          break;
          default:
          Console.WriteLine("Error");
          break;
          }
        Console.WriteLine("Do You Want To Add Another Car ? (Y/N)");
          answer = Console.ReadLine();
        }while (answer == "Y" || answer == "y");
        if(answer == "N" || answer == "n"){
          Console.WriteLine("Thank You For Using Our Program");
        }
          }}