
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

    // >>> Osawa's name is Osawa and he is 23 years old.
    // >>> Usukura's name is Usukura and he is 23 years old.

    // 生成したインスタンスのメソッドにアクセスしてみましょう。

    osawa.Greet();
    // >>> Hello, my name is Mr. OSAWA and I am 23 years old.
    // >>> I live in Soka.

    usukura.Greet();
    // >>> Hello, my name is Mr. USUKURA and I am 23 years old.
    // >>> I live in Kawaguchi.

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // 次にgetterとsetterについて説明します。
    // getterとsetterはプロパティに対してアクセスする際に使用されるメソッドです。
    // getterはプロパティの値を取得する際に使用され、
    // setterはプロパティの値を設定する際に使用されます。
    // プロパティに対して直接アクセスすることもできますが、値のチェックを入れたい場合や、
    // プロパティの値を取得する際に何らかの処理を行いたい場合にはgetterとsetterを使用します。
    // また、オブジェクト指向の基本原則であるカプセル化のためにもgetterとsetterを使用することが推奨されています。

    // getterとsetterは以下のように書きます。
    // プロパティ名
    // {
    //   get
    //   {
    //     // getterの処理
    //   }
    //   set
    //   {
    //     // setterの処理
    //   }
    // }

    // getterとsetter内で対象のプロパティはvalueという変数でアクセスできます。

    // 例えば、入力時に値のチェックを行いたい場合には以下のように書きます。
    // 下の例では、年齢が負の値をとった際に例外を発生されています。
    // private int _age;
    // public int Age
    // {
    //   set
    //   {
    //     if (value < 0)
    //     {
    //       throw new ArgumentException("年齢は0以上である必要があります。");
    //     }
    //     _age = value;
    //   }
    // }

    // 上の例では、Ageを直接操作すると、プロパティにアクセス時にsetterメソッドが呼ばれ、
    // そのsetterメソッド内でAgeプロパティをセットするための、setterメソッドが呼ばれ、
    // さらに、そのsetterメソッド内でAgeプロパティをセットするための、setterメソッドが呼ばれ、
    // という無限ループになってしまいます。
    // したがって、別のデータを用意することでこれを回避します。
    // ここでは、_ageという変数を使用しています。
    // これは内部的に使用され、外部とのやり取りはAgeプロパティを介して行うことで、
    // このような無限ループを回避しています。
    // また、このようなデータをバッキングフィールドと呼びます。

    // また、データ取得時に処理を行う場合には以下のように書きます。
    // 下の例では、名前を取得する際に、名前の前に「Mr.」を付けて、名前を大文字に変換して返しています。
    // private string _name
    // public string Name
    // {
    //   get
    //   {
    //     return $"Mr. {_name.ToUpper()}";
    //   }
    // }

    // 特にsetterとgeetterでの処理が必要ない場合には、
    // 以下のように書くことで、getterとsetterを省略することができます。
    // public int Age { get; set; }

    // では、生まれる前のosawaインスタンスを生成してみましょう♪

    Person osawa_before_born = new Person("osawa", -1, "Soka");
    Console.WriteLine($"osawa_before_born: {osawa_before_born.Name}, {osawa_before_born.Age}, {osawa_before_born.Address}");

    // >>> osawa_before_born: Mr. OSAWA, 0, Soka

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // 最後にアクセス修飾子について説明します。
    // アクセス修飾子とは、クラスやメソッド、プロパティなどのアクセス権を制御するためのものです。
    // 以下のように、アクセス修飾子を指定することで、
    // そのクラスやメソッド、プロパティなどをどのようにアクセスできるかを制御することができます。

    // public: どこからでもアクセスできる
    // private: 同じクラス内からのみアクセスできる
    // protected: 同じクラス内、または継承したクラスからのみアクセスできる
    // internal: 同じアセンブリ内からのみアクセスできる
    // protected internal: 同じアセンブリ内、または継承したクラスからのみアクセスできる

    // ref: https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/access-modifiers

    // では、「AccessChecker」クラスにそれぞれのアクセス修飾子が付されたメンバを用意したので、
    // それぞれのアクセス修飾子がどのようにアクセスできるかを確認してみましょう。

    AccessChecker access_checker = new();

    // publicメンバにアクセス
    access_checker._public = "public_member";

    // privateメンバにアクセス
    // access_checker._private = "private_member"; // エラー

    // protectedメンバにアクセス
    // access_checker._protected = "protected_member"; // エラー

    // internalメンバにアクセス
    access_checker._internal = "internal_member";

    // protected internalメンバにアクセス
    access_checker._protected_internal = "protected_internal_member";

    // また、アクセス修飾子を指定しない場合は、
    // デフォルトで「private」が指定されます。
    
  }
}


// Personクラスを定義
internal class Person
{
  private string _name = "";
  internal string Name
  {
    get
    {
      return $"Mr. {_name.ToUpper()}";
    }
    set
    {
      _name = value;
    }
  }
  private int _age = 0;
  internal int Age
  {
    get
    {
      // プロパティを取得する場合にはそのまま。
      return _age;
    }
    set
    {
      // プロパティを設定する場合には、
      // プロパティの値が正しいかどうかをチェックします。
      if (value < 0)
      {
        // 例外が発生するとダルいのでここでは「0」に変換します。
        // throw new ArgumentException("年齢は0以上である必要があります。");
        _age = 0;
        return;
      }
      _age = value;
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


public class AccessChecker
{
  public string _public = "I am public";
  private string _private = "I am private";
  protected string _protected = "I am protected";
  internal string _internal = "I am internal";
  protected internal string _protected_internal = "I am protected internal";
}

