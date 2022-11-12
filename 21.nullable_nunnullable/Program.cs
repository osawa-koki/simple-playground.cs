
// I call it my billion-dollar mistake.
// It was the invention of the null reference in 1965.
// At that time,
// I was designing the first comprehensive type system for references in an object oriented language (ALGOL W).
// My goal was to ensure that all use of references should be absolutely safe,
// with checking performed automatically by the compiler.
// But I couldn't resist the temptation to put in a null reference,
// simply because it was so easy to implement.
// This has led to innumerable errors, vulnerabilities, and system crashes,
// which have probably caused a billion dollars of pain and damage in the last forty years.
//
// ref : https://en.wikipedia.org/wiki/Tony_Hoare
// ref : https://www.infoq.com/presentations/Null-References-The-Billion-Dollar-Mistake-Tony-Hoare/

{
  // 「Null Pointer Reference Exception」
  // プログラマなら、一度は経験する例外だと思います。
  // C#などの静的型付け言語は、コンパイル時に型チェックが行われるため、
  // 型の不一致による例外は発生しません。
  // しかし、Null参照による例外は、コンパイル時には検出できません。
  // そのため、Null参照による例外は、実行時に発生します。
  // この例外は、プログラマが意図しない場所で発生するため、
  // デバッグが難しくなります。
  // また、Null参照による例外は、プログラムの挙動を変えるため、
  // プログラムの挙動が予測できなくなります。
  // そのため、Null参照による例外は、プログラムの品質を低下させます。
  // Null参照による例外を防ぐために、
  // Null参照を許容しない型を使用することが推奨されています。

  // この例では、Null参照による例外を発生させています。
  // この例外は、実行時に発生します。

  var s = default(string);
  // Console.WriteLine(s.Length); // System.NullReferenceException: 'Object reference not set to an instance of an object.'

  // ===== ===== ===== ==== =====

  // では、null許容型とnull非許容型について学習しましょう♪

  // ===== ===== ===== ==== =====

  // null許容型

  // null許容型は、nullを許容する型です。
  // null許容型は、nullを許容するため、
  // null許容型の変数には、nullを代入することができます。
  // null許容型の変数には、null以外の値を代入することもできます。

  // null許容型の変数には、nullを代入することができます。
  string? s1 = null;

  // null許容型の変数には、null以外の値を代入することもできます。
  string? s2 = "abc";

  // null許容型の値を検査することなく、使用するとNull参照による例外が発生します。
  // そのため、null許容型の値を使用する前に、null許容型の値がnullでないことを検査する必要があります。

  // null許容型の値がnullでないことを検査するには、
  // null許容型の値に対して、null許容型の値がnullでないことを検査するメソッドを使用します。

  if (s1 != null)
  {
    // null許容型の値がnullでないことを検査した後に、
    // null許容型の値を使用することができます。
    Console.WriteLine(s1.Length);
  }

  // 検査することなく、null許容型の値を使用すると、警告が出力されます。

  // o nsole.WriteLine(s1.Length); // warning CS8602: Dereference of a possibly null reference.

  // ===== ===== ===== ==== =====

  // null非許容型

  // null非許容型は、nullを許容しない型です。

  // null非許容型の変数には、nullを代入することはできません。
  // string s3 = null; // error CS8716: There is no target type for the default literal.

  string s4 = "abc";
}
{
  // null判断演算子

  // nullのチェックにif文を使用するのは面倒ですよね、、、
  // そこで、null判断演算子を使用することができます。

  // null判断演算子は、null許容型の値がnullでないことを検査し、
  // null許容型の値がnullでない場合は、null許容型の値を返し、
  // null許容型の値がnullの場合は、null非許容型の値を返す演算子です。

  string? nullale = null;
  string nonNullable = "abc";

  // 上で、文字列型の変数をそれぞれ、null許容型とnull非許容型に代入しました。
  // これらの文字列の長さを出力してみましょう♪

  Console.WriteLine($"nullable.Length: {nullale?.Length}");
  Console.WriteLine($"nonNullable.Length: {nonNullable.Length}");

  // 「?」を使用することで、null許容型の値がnullでないことを検査し、
  // null許容型の値がnullでない場合は、null許容型の値を返すようになります。
  // したがって、その結果をさらに使用する場合には、もう一度「?」を使用する必要があります。
}
{
  // null合体演算子

  // null合体演算子は、null許容型の値がnullでないことを検査し、
  // null許容型の値がnullでない場合は、null許容型の値を返し、
  // null許容型の値がnullの場合は、null非許容型の値を返す演算子です。

  string? nullale = null;
  string nonNullable = "abc";

  // 上で、文字列型の変数をそれぞれ、null許容型とnull非許容型に代入しました。
  // これらの文字列の長さを出力してみましょう♪

  Console.WriteLine($"nullable.Length: {nullale ?? nonNullable}");
  Console.WriteLine($"nonNullable.Length: {nonNullable.Length}");

  // >>> 実行結果
  // nullable.Length: abc
  // nonNullable.Length: 3

  // 一般的にはnullの場合のデフォルト値を設定する際に使用されます。

  Console.WriteLine($"nullable.Length: {nullale?.Length ?? -99}");
  Console.WriteLine($"nonNullable.Length: {nonNullable.Length}");

  // >>> 実行結果
  // nullable.Length: -99
  // nonNullable.Length: 3
}
