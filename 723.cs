using System;
class Book{
  public string Name{get; set;}
  //构造函数
  public Book(string name){
    Name = name;
    Console.WriteLine("构造函数输出"+Name);
  }
  public void ShowInfo(){
    Console.WriteLine(Name);
  }
}

class Program1
{
    static void Main(string[] args)
    {
        Book bk = new Book("Alex");
        bk.ShowInfo();
    }
}