

internal class Program
{
  private static void Main(string[] args)
  {
    // ここでは列挙型について説明します。
    // 列挙型とは、名前の通り、取りうる値を列挙したものです。
    // 例えば、曜日を表す列挙型を作るとすると、
    // 以下のように書くことができます。
    // enum DayOfWeek
    // {
    //   Sunday,
    //   Monday,
    //   Tuesday,
    //   Wednesday,
    //   Thursday,
    //   Friday,
    //   Saturday
    // }
    // このように書くと、DayOfWeek型の変数には、
    // Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturdayのいずれかの値を代入することができます。

    // 真偽値の進化バージョンです。
    // 「はい」か「いいえ」で答えなさい。っていう謎の指示をしてくる人に対して、
    // いや、すべての質問に対して「はい」か「いいえ」で答えられるわけじゃないんで、、、
    // って思いますよね♪
    // その時に役立ちます。
    // しかしながら、その場合の答えってなんでもOKなわけでなく、
    // だいたい、以下の内容になります。
    // ・ はい
    // ・ いいえ
    // ・ 多分
    // ・ これだけだと何とも、、、
    // このようにある程度列挙しておくことで、データを扱いやすくします。

    // これをint型とかで管理すると、よくわからない不整合とか生じちゃいますからね、、、

    // では、さっそく列挙型を使ってみましょう。

    MyAnswer myAnswer = MyAnswer.Yes;
    Console.WriteLine(myAnswer);

    // >>> Yes

    // 列挙型は当然取りうる値が事前に列挙されているため、
    // これ以外の値をとる危険性がありません。
    // したがって、以下のコードはエラーとなります。

    // MyAnswer myAnswer = MyAnswer.if_you_think_so;

    // 列挙型はswitchやこの後学習する辞書型のデータと非常に相性がいいです。

    MyAnswer yourAnswer = MyAnswer.Maybe;

    switch (yourAnswer)
    {
      case MyAnswer.Yes:
        Console.WriteLine("OK じゃあ、そのまま進めてね♪");
        break;
      case MyAnswer.No:
        Console.WriteLine("う～～ん、あとで少し話したいから、会議の予定入れといて!!!");
        break;
      case MyAnswer.Maybe:
        Console.WriteLine("何が不安なの???");
        break;
      case MyAnswer.Cannot_Judge_ForNow:
        Console.WriteLine("何が分かれば判断できる???");
        break;
      default:
        // ここには来ないはず
        break;
    }

    // 値を限定列挙したい場合には原則として列挙型を使用してください。

    // ごくまれに、整数を割り振って管理しているケースがありますが、
    // 思わぬバグ防止の観点からオススメできません。
    // ・ 現金支払い -> 1
    // ・ クレジットカード -> 2
    // ・ ポイント -> 3
    // というように、整数を割り振って管理しているケースがありますが、
    // これは、「4」という数字を間違って指定できてしまうなど、
    // 思わぬバグを生みやすいです。
    // 原則避けて、列挙型を使用しましょう。

  }
}


internal enum MyAnswer
{
  Yes,
  No,
  Maybe,
  Cannot_Judge_ForNow,
}

