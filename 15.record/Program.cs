
using System.Xml.Linq;

internal class Program
{
  internal static void Main()
  {
    // ここではrecord型について説明します。
    // record型は構造体に非常に似ていますが、
    // 構造体よりも簡単に複数のデータを格納します。

    // MS公式ドキュメントではrecord型の特徴として以下の点を挙げています。
    // ・ 不変プロパティを持つ参照型を作成するための簡潔な構文
    // ・ データ中心の参照型に役立つ組み込みの動作
    // ・ 継承階層のサポート
    // ref: https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-9#record-types

    // 少し難しいですが、構造体をもっと簡単にしたものだと認識してください。

    // record型を定義するには以下のように書きます。
    // record Person(string FirstName, string LastName);

    // これでPerson型が定義できました。
    // この型は以下のように使います。
    // var person = new Person("koki", "osawa");

    // では、さっそく使用してみましょう♪

    Person osawa = new Person("koki", "osawa");

    // このように、record型は構造体と同じように使えます。
    // また、以下のようにプロパティを取得することもできます。
    Console.WriteLine(osawa.FirstName); // koki
    Console.WriteLine(osawa.LastName); // osawa

    // また、record型は「==」を使用して値の等価性を判断することができます。

    Person osawa_at_home = new Person("koki", "osawa");
    Person osawa_at_work = new Person("koki", "osawa");

    Console.WriteLine(osawa_at_home == osawa_at_work); // True

    // 構造体と同じようにEqualを使用して値の等価性を判断することもできます。
    
    Console.WriteLine(osawa_at_home.Equals(osawa_at_work)); // True

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // また、C#10からはrecord型の派生系として以下の2つが登場しました。
    // ・ record struct
    // ・ record class
    // ref: https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-10#record-structs-and-record-classes

    // これらはrecord型と同じように使えますが、
    // record structは構造体と同じように扱われます。
    // record classはクラスと同じように扱われます。

    // これらの型を使うことで、
    // record型の特徴を構造体やクラスにも適用することができます。

    // 以下のように書くことで、record structを定義できます。
    // record struct Person(string FirstName, string LastName);

    // また、以下のように書くことで、record classを定義できます。
    // record class Person(string FirstName, string LastName);

    // record structとrecord classの使い分けは、
    // 以下のように考えることができます。
    // ・ record structは構造体と同じように扱われるので、
    //   データを格納するために使用します。
    // ・ record classはクラスと同じように扱われるので、
    //   データを格納するだけでなく、
    //   データを操作するために使用します。

    // record struct

    Lesson csharp = new Lesson("C#", 1, 1200);
    Console.WriteLine(csharp.ToString());

    // >>> Lesson { name = C#, id = 1, price = 1200 }

    // record class

    Ramen ramen = new Ramen(500, 1200);

    Console.WriteLine(ramen.ToString());

    // >>> Ramen { name = ラーメン, katasa = 500, price = 1200 }

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // with式を使用して、データの一部を変更したコピーを作成することができます。

    // では、先ほど作成した塩ラーメンを醤油ラーメンに変更しましょう♪

    Ramen shoyu_ramen = ramen with { name = "醤油ラーメン" };

    Console.WriteLine(shoyu_ramen.ToString());

    // >>> Ramen { name = 醤油ラーメン, katasa = 500, price = 1200 }

    // せっかくですので、僕が大好きな濃厚魚介つけ麺も作りましょう♪
    // 値段の880円とお手軽です♪

    Ramen fish_ramen = ramen with { name = "濃厚魚介つけ麺", price = 880 };

    Console.WriteLine(fish_ramen.ToString());

    // >>> Ramen { name = 濃厚魚介つけ麺, katasa = 500, price = 880 }

  }

  // 単純なrecord型を定義
  internal record Person(string FirstName, string LastName);

  // record structを定義
  internal record struct Lesson(string name, int id, double price);

  // record classを定義
  internal record class Food(string name);

  // Foodクラスを継承
  internal record class Ramen(int katasa, double price) : Food("ラーメン");

}

