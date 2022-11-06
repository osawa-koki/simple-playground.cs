
internal class Program
{
  private static void Main(string[] args)
  {
    // クラス初期化時に、クラスプロパティを初期化することもできます。
    // この場合には「{...}」内で初期値を指定します。

    var osawa = new Person()
    {
      Name = "osawa",
      Age = 23
    };
    osawa.SayHello();
    
    // >>> Hello, my name is osawa. I'm 23 years old.

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    


  }
}




internal class Person
{
  public string Name;
  public int Age;

  public void SayHello()
  {
    Console.WriteLine($"Hello my name is {Name} and I am {Age} years old.");
  }
}

