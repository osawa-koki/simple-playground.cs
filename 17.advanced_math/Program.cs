
// ここでは数学系の処理を学習します。
// プログラミングといえばやっぱり数的処理ですよね♪

{
  // インクリメントとデクリメント

  // インクリメントとは、変数の値を1増やすことです。
  // デクリメントとは、変数の値を1減らすことです。

  // インクリメントは、変数の後ろに++を付けることで行います。
  // デクリメントは、変数の後ろに--を付けることで行います。

  // 例えば、変数aの値を1増やしたい場合は、a++と書きます。
  // また、変数bの値を1減らしたい場合は、b--と書きます。

  // 以下のコードを実行してみましょう。

  int a = 0;
  int b = 0;

  a++;
  b--;

  Console.WriteLine(a);
  Console.WriteLine(b);

  // >>> 1
  // >>> -1

  // これらはそれぞれ以下の処理と同じです。
  // a = a + 1
  // b = b - 1
}
{
  // Mathクラスには数学系の処理を行うメソッドが用意されています。
  // 擬態的には具体的には以下のメソッドがあります。
  // Math.Abs()   : 絶対値を求める
  // Math.Max()   : 最大値を求める
  // Math.Min()   : 最小値を求める
  // Math.Pow()   : べき乗を求める
  // Math.Sqrt()  : 平方根を求める
  // Math.Sin()   : 正弦を求める
  // Math.Cos()   : 余弦を求める
  // Math.Tan()   : 正接を求める
  // Math.Asin()  : アークサインを求める
  // Math.Acos()  : アークコサインを求める
  // Math.Atan()  : アークタンジェントを求める
  // Math.Atan2() : アークタンジェントを求める
  // Math.Log()   : 自然対数を求める
  // Math.Log10() : 10進数対数を求める
  // Math.Exp()   : eのべき乗を求める
  // Math.Floor() : 小数点以下を切り捨てる
  // Math.Ceiling(): 小数点以下を切り上げる
  // Math.Round() : 四捨五入する

  // 以下のコードを実行してみましょう。

  Console.WriteLine($"Math.Abs(-10): {Math.Abs(-10)}"); // 10
  Console.WriteLine($"Math.Max(10, 20): {Math.Max(10, 20)}"); // 20
  Console.WriteLine($"Math.Min(10, 20): {Math.Min(10, 20)}"); // 10
  Console.WriteLine($"Math.Pow(2, 3): {Math.Pow(2, 3)}"); // 8
  Console.WriteLine($"Math.Sqrt(9): {Math.Sqrt(9)}"); // 3
  Console.WriteLine($"Math.Sin(0): {Math.Sin(0)}"); // 0
  Console.WriteLine($"Math.Cos(0): {Math.Cos(0)}"); // 1
  Console.WriteLine($"Math.Tan(0): {Math.Tan(0)}"); // 0
  Console.WriteLine($"Math.Asin(0): {Math.Asin(0)}"); // 0
  Console.WriteLine($"Math.Acos(1): {Math.Acos(1)}"); // 0
  Console.WriteLine($"Math.Atan(0): {Math.Atan(0)}"); // 0
  Console.WriteLine($"Math.Atan2(0, 1): {Math.Atan2(0, 1)}"); // 0
  Console.WriteLine($"Math.Log(1): {Math.Log(1)}"); // 0
  Console.WriteLine($"Math.Log10(1): {Math.Log10(1)}"); // 0
  Console.WriteLine($"Math.Exp(0): {Math.Exp(0)}"); // 1
  Console.WriteLine($"Math.Floor(1.5): {Math.Floor(1.5)}"); // 1
  Console.WriteLine($"Math.Ceiling(1.5): {Math.Ceiling(1.5)}"); // 2
  Console.WriteLine($"Math.Round(1.5): {Math.Round(1.5)}"); // 2
}
{
  // 次に乱数を生成しましょう♪
  // 乱数の生成には、Randomクラスを使用します。
  // Randomクラスには以下のメソッドが用意されています。
  // Random.Next() : 乱数を生成する
  // Random.NextDouble() : 乱数を生成する
  // Random.NextBytes() : 乱数を生成する
  // それぞれ、生成される乱数の範囲が異なります。
  //
  // Random.Next()は、引数を指定しない場合は0以上1未満の乱数を生成します。
  // 引数を1つ指定した場合は、0以上引数未満の乱数を生成します。
  // 引数を2つ指定した場合は、引数1以上引数2未満の乱数を生成します。
  //
  // Random.NextDouble()は、0以上1未満の乱数を生成します。
  //
  // Random.NextBytes()は、引数に指定した配列に乱数を格納します。
  // 乱数の範囲は0以上255未満の整数値です。

  // 以下のコードを実行してみましょう。

  var random = new Random();
  Console.WriteLine($"random.Next(): {random.Next()}"); // 0以上1未満の乱数
  Console.WriteLine($"random.Next(10): {random.Next(10)}"); // 0以上10未満の乱数
  Console.WriteLine($"random.Next(10, 20): {random.Next(10, 20)}"); // 10以上20未満の乱数
  Console.WriteLine($"random.NextDouble(): {random.NextDouble()}"); // 0以上1未満の乱数
  var bytes = new byte[10];
  random.NextBytes(bytes);
  Console.WriteLine($"random.NextBytes(): {string.Join(", ", bytes)}"); // 0以上255未満の乱数
}
{
  // 次にオーバーフローについて説明します。
  // オーバーフローとは、変数の値が最大値を超えた場合に発生します。

  // まず、最大値と最小値の取得方法を説明します。
  // 最大値はint.MaxValue、long.MaxValue、double.MaxValueなどで取得できます。
  // 最小値はint.MinValue、long.MinValue、double.MinValueなどで取得できます。

  Console.WriteLine($"int.MaxValue: {int.MaxValue}"); // 2147483647
  Console.WriteLine($"int.MinValue: {int.MinValue}"); // -2147483648
  Console.WriteLine($"long.MaxValue: {long.MaxValue}"); // 9223372036854775807
  Console.WriteLine($"long.MinValue: {long.MinValue}"); // -9223372036854775808
  Console.WriteLine($"double.MaxValue: {double.MaxValue}"); // 1.79769313486232E+308
  Console.WriteLine($"double.MinValue: {double.MinValue}"); // -1.79769313486232E+308

  // int型の変数にint.MaxValue + 1を代入するとオーバーフローが発生します。
  // この場合、変数にはint.MinValueが代入されます。
  // これは、int型の変数にはint.MaxValueまでしか値を格納できないためです。
  // また、オーバーフローが発生した場合、変数の値が最小値を下回った場合にはアンダーフローが発生します。
  // これは、int型の変数にはint.MinValueまでしか値を格納できないためです。
  // 以下のコードを実行してみましょう。

  unchecked
  {
    var i = int.MaxValue;
    Console.WriteLine($"i: {i}"); // 2147483647
    i++;
    Console.WriteLine($"i: {i}"); // -2147483648
    i--;
    Console.WriteLine($"i: {i}"); // 2147483647
    i--;
    Console.WriteLine($"i: {i}"); // 2147483646

    var j = int.MinValue;
    Console.WriteLine($"j: {j}"); // -2147483648
    j--;
    Console.WriteLine($"j: {j}"); // 2147483647
  }

  // 「2147483647」に1を加算すると「-2147483648」になってしまうのは、なんだかいやですよね、、、
  // そこで、オーバーフローを防ぐために、checkedキーワードを使用します。
  // checkedキーワードを使用すると、オーバーフローが発生した場合に例外が発生します。
  // 以下のコードを実行してみましょう。
  // try-catchについては後ほど説明しますが、
  // 今は例外が発生した場合にcatchブロックが実行されることを覚えておいてください。

  // コンパイラの設定(/checked+)でデフォルトで例外を発生させることもできます。
  // このモードの場合に、部分的に例外を発生させないようにするためには、uncheckedを使用します。

  try
  {
    checked
    {
      var k = int.MaxValue;
      Console.WriteLine($"k: {k}"); // 2147483647
      k++;
      Console.WriteLine($"k: {k}"); // 例外が発生します。
    }
  }
  catch (Exception ex)
  {
    Console.WriteLine($"例外が発生しました。: {ex.Message}");
  }

  // または、checked()を使用することもできます。

  // try
  // {
  //   var k = checked(int.MaxValue);
  //   Console.WriteLine($"k: {k}"); // 2147483647
  //   k++;
  //   Console.WriteLine($"k: {k}"); // 例外が発生します。
  // }
  // catch (Exception ex)
  // {
  //   Console.WriteLine($"例外が発生しました。: {ex.Message}");
  // }
  //
  // C#プロジェクトファイルの設定で、上記コードが適切に動作するように設定していますが、
  // C#プロジェクトファイルが変更された場合のことを考えてコメントアウトしています。

}
{
  // 出力フォーマットの指定
  // ToStringメソッドの引数で文字列化時のフォーマットを指定できます。
  // フォーマット指定子には、以下のものがあります。
  // D: 10進数
  // X: 16進数
  // F: 浮動小数点数
  // E: 指数表記
  // N: 数値のグループ化
  // C: 貨幣
  // P: パーセント

  // 以下のコードを実行してみましょう。

  // ちなみに、「i:★★★」という記法は、「i.ToString("★★★")」と同じです。

  var i = 123;
  Console.WriteLine($"i: {i}"); // 123
  Console.WriteLine($"i: {i:D}"); // 123
  Console.WriteLine($"i: {i:X}"); // 7B
  Console.WriteLine($"i: {i:F}"); // 123.000000
  Console.WriteLine($"i: {i:E}"); // 1.230000E+002
  Console.WriteLine($"i: {i:N}"); // 123
  Console.WriteLine($"i: {i:C}"); // ¥123
  Console.WriteLine($"i: {i:P}"); // 12,300.00%

  // また、ToStringメソッドの引数には、カルチャーを指定することもできます。

  // 以下のコードを実行してみましょう。

  var j = 123;
  Console.WriteLine($"j: {j:D0}"); // 123
  Console.WriteLine($"j: {j:D3}"); // 123
  Console.WriteLine($"j: {j:D4}"); // 0123
  Console.WriteLine($"j: {j:D5}"); // 00123
  Console.WriteLine($"j: {j:D6}"); // 000123
  Console.WriteLine($"j: {j:D7}"); // 0000123
  Console.WriteLine($"j: {j:D8}"); // 00000123

  // また、カルチャーを指定することで、小数点以下の桁数を指定することもできます。

  // 以下のコードを実行してみましょう。

  var k = 123.456;
  Console.WriteLine($"k: {k:F0}"); // 123
  Console.WriteLine($"k: {k:F1}"); // 123.5
  Console.WriteLine($"k: {k:F2}"); // 123.46
  Console.WriteLine($"k: {k:F3}"); // 123.456
  Console.WriteLine($"k: {k:F4}"); // 123.4560
  Console.WriteLine($"k: {k:F5}"); // 123.45600
  Console.WriteLine($"k: {k:F6}"); // 123.456000
  Console.WriteLine($"k: {k:F7}"); // 123.4560000
  Console.WriteLine($"k: {k:F8}"); // 123.45600000
}
