
internal class Program
{
  private static void Main(string[] args)
  {
    // ここではクラスについて学習します。
    // クラスとはオブジェクト指向の中心的な考え方で、データとそれに対する処理をひとまとめにしたものです。
    // クラスが保有するデータをプロパティと呼び、
    // クラスが保有する処理をメソッドと呼びます。
    // また、両者を合わせてメンバと呼びます。

    // クラスの定義は以下のように行います。
    // class クラス名
    // {
    //   プロパティ
    //   メソッド
    // }

    // では、クラスを定義してみましょう♪
    // 今回は、名前と年齢と住所を保持するクラスを定義します。
    // 下に「Person」という名前のクラスを定義しました。

    // 次にクラスからインスタンスを生成してみましょう♪

    // 以下のようにクラスをインスタンス化することができます。
    // var インスタンス名 = new クラス名();

    // クラスのインスタンスを生成することをインスタンス化と呼びます。
    // インスタンス化したクラスのインスタンスをオブジェクトと呼びます。
    // クラスのインスタンスを生成することをオブジェクトの生成と呼びます。

    // クラスのインスタンスを生成するには、new演算子を使用します。
    // new演算子の後にクラス名を記述し、
    // クラスのコンストラクタを呼び出します。
    // コンストラクタはクラスのインスタンスを生成する際に呼び出されるメソッドです。
    // コンストラクタはクラス名と同じ名前を持ち、
    // 戻り値を持ちません。

    // 定義したPersonクラスのインスタンスを生成しましょう♪
    Person osawa = new Person("Osawa", 23, "Soka");

    // また、オブジェクトとそれを格納するデータ型が等しい場合にはクラス名を省略できます。
    Person usukura = new("Usukura", 23, "Kawaguchi");

    // 生成したインスタンスのプロパティにアクセスしてみましょう。
    Console.WriteLine($"Osawa's name is {osawa.Name} and he is {osawa.Age} years old.");
    Console.WriteLine($"Usukura's name is {usukura.Name} and he is {usukura.Age} years old.");

    // 生成したインスタンスのメソッドにアクセスしてみましょう。
    osawa.Greet();
    usukura.Greet();

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // 次にクラスの継承を行います。

    // 下に「Person」クラスを継承した「Student」クラスを定義しました。


  }
}


// Personクラスを定義
internal class Person
{
  internal string Name { get; set; }
  internal int Age
  {
    get
    {
      // プロパティを取得する場合にはそのまま。
      return Age;
    }
    set
    {
      // プロパティを設定する場合には、
      // プロパティの値が正しいかどうかをチェックします。
      if (value < 0)
      {
        throw new ArgumentException("年齢は0以上である必要があります。");
      }
      Age = value;
    }
  }
  internal string Address { get; set; }

  internal Person(string name, int age, string address)
  {
    Name = name;
    Age = age;
    Address = address;
  }

  internal void Greet()
  {
    Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.\nI live in {Address}.");
  }

  internal void SayHi()
  {
    Console.WriteLine("Hi, I am a Person.");
  }
}

// Personクラスを継承したStudentクラスを定義
internal class Student : Person
{
  internal string School { get; set; }

  // コンストラクタ引数を追加します。

  internal Student(string name, int age, string address, string school) : base(name, age, address)
  {
    School = school;
  }

  internal new void Greet()
  {
    Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.\nI live in {Address} and I go to {School}.");
  }

  internal new void SayHi()
  {
    base.SayHi();
    Console.WriteLine("Hi, I'm a student!");
  }
  
  internal void Study()
  {
    Console.WriteLine("I'm studying!");
  }

}


