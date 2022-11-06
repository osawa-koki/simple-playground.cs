
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

    // 次にオブジェクトを関数の引数として渡した時の動作について確認します。
    // 既に説明したとおり、オブジェクトは原則として参照渡しがされます。
    // そのため、オブジェクトを関数の引数として渡した時に、
    // オブジェクトのプロパティを変更すると、
    // オブジェクトの参照先の値が変更されます。

    var osawa_in_september = new Person()
    {
      Name = "osawa",
      Age = 23
    };
    osawa_in_september.SayHello();

    // >>> Hello, my name is osawa. I'm 23 years old.

    // 10月になって、osawaさんは1歳年上になりました。

    BirthDayComing(osawa_in_september);

    osawa_in_september.SayHello();

    // >>> Hello, my name is osawa. I'm 24 years old.

    // オブジェクトが参照渡しであることが確認できました。

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // オブジェクトの比較

    // 次にオブジェクトの比較を行います。
    // オブジェクトの比較は、参照渡しであるため、
    // オブジェクトの参照先の値が同じであるかどうかで判断されます。

    var osawa_in_october = new Person()
    {
      Name = "osawa",
      Age = 24
    };
    var osawa_in_november = new Person()
    {
      Name = "osawa",
      Age = 24
    };

    // 10月と11月のosawaさんは同じ人ですが、
    // インスタンスは別ですので、異なるオブジェクトとなります。

    Console.WriteLine($"osawa_in_october == osawa_in_november -> {osawa_in_october == osawa_in_november}");

    // >>> osawa_in_october == osawa_in_november -> False

    // Equalというメソッドを使用しても値の等価性は判断しません。
    
    Console.WriteLine($"osawa_in_october.Equals(osawa_in_november) -> {osawa_in_october.Equals(osawa_in_november)}");

    // >>> osawa_in_october.Equals(osawa_in_november) -> False


    // ちなみに、
    // オブジェクトのプロパティの等価性を判断するには構造体を使用します。
    // 構造体はクラスと異なり、値型のデータであるため、
    // 値の等価性を判断することができます。

    // 構造体については後ほど詳しく説明しますので、
    // ここでは、構造体の動作の概要だけを紹介します。
    // 構造体に搭載されている、Equalsメソッドで判定できます。

    var osawa_struct_in_october = new PersonStruct()
    {
      Name = "osawa",
      Age = 24
    };
    var osawa_struct_in_november = new PersonStruct()
    {
      Name = "osawa",
      Age = 24
    };

    Console.WriteLine($"osawa_struct_in_october == osawa_struct_in_november -> {osawa_struct_in_october.Equals(osawa_struct_in_november)}");

    // >>> 実行結果
    // osawa_in_october == osawa_in_november -> True

  }


  internal static void BirthDayComing(Person person)
  {
    person.Age++;
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

internal struct PersonStruct
{
  public string Name;
  public int Age;

  public void SayHello()
  {
    Console.WriteLine($"Hello my name is {Name} and I am {Age} years old.");
  }
}

