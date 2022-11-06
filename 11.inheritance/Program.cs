
internal class Program
{
  private static void Main(string[] args)
  {
    // ここではクラスの継承について学習します。
    // 継承とは、既存のクラスを元に新しいクラスを定義することです。
    // 既存のクラスを親クラス、新しいクラスを子クラスと呼びます。
    // 子クラスは親クラスのメンバを継承することができます。
    // また、子クラスは親クラスのメンバをオーバーライドすることができます。
    // オーバーライドとは、親クラスのメンバを子クラスで再定義することです。
    // オーバーライドすることで、親クラスのメンバを子クラスの独自の処理に変更することができます。
    // また、オーバーライドすることで、親クラスのメンバを子クラスの独自の処理に変更することができます。

    // 継承は以下のように行います。
    // class クラス名 : 親クラス名
    // {
    //   // メンバの定義
    // }

    // 下では、「Person」クラスを継承した「Student」クラスを定義しています。
    // 「Student」クラスは「Person」クラスのメンバを継承しています。
    // したがって、「Person」クラスが有しているName・Age・Addressプロパティが自動で実装されます。
    // また、「Person」クラスが有している「Greet」「SayHello」メソッドも自動で実装されます。

    Student osawa_at_school = new("Osawa", 23, "Soka", "Meiji Univ");
    osawa_at_school.Greet();
    osawa_at_school.SayHi();

    // >>> Hello, I'm Osawa.
    // >>> Hi, I'm Osawa.

    // また、「Student」クラスが新たに定義した「School」プロパティを使用することができます。
    Console.WriteLine($"osawa_at_scool is a student of {osawa_at_school.School}.");

    // >>> osawa_at_scool is a student of Meiji Univ.

    // 当然に、「Student」クラスが新たに定義した「Study」メソッドを使用することができます。
    osawa_at_school.Study();

    // >>> I'm studying!

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // リスコフの置換原則についても少し説明します。
    // リスコフの置換原則とは、
    // 「S型のオブジェクトo1の各々に、T型のオブジェクトo2が1つ存在し、
    //  Tに対して定義されたすべてのプログラムPが、
    //  Sに対して定義されたプログラムPと同じ結果を返すならば、
    //  SはTの派生型である」という原則です。
    // これは、継承を行う際に、
    // 子クラスのオブジェクトを親クラスのオブジェクトとして扱えるようにするための原則です。
    // つまり、親クラスのオブジェクトを子クラスのオブジェクトとして扱えるようにするための原則です。

    // 原則としてオブジェクトと、それを格納するデータ型は一致します。
    // 以下のようなケースです。
    Person osawa_person = new Person("Osawa", 23, "Soka");

    // このコードは、Person型のオブジェクトをPerson型のオブジェクトとして扱っています。
    // したがって、リスコフの置換原則に従っています。

    // もしくは、以下のようなコードもリスコフの置換原則に従っています。
    Person osawa_student = new Student("Osawa", 23, "Soka", "Meiji Univ");

    // これはPersonクラスから派生したStudentクラスをPesonクラスとして扱っているためです。

    // しかし、以下のようなコードはリスコフの置換原則に従っていません。
    // Student osawa_paeron_bad = new Person("Osawa", 23, "Soka"); // エラー

    // これは、Person型のオブジェクトをStudent型のオブジェクトとして扱っています。
    // したがって、リスコフの置換原則に従っていません。


  }
}


// Personクラスを定義
internal class Person
{
  internal string Name { get; set; }
  internal int Age { get; set; }
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


