
internal class Program
{
  private static void Main(string[] args)
  {
    // ここでは関数(メソッド)について学習します。
    // まずは、関数の定義から始めます。
    // 関数の定義は、戻り値の型、関数名、引数の型、引数の名前を指定します。
    // 戻り値の型は、関数の戻り値の型を指定します。
    // 関数名は、関数の名前を指定します。
    // 引数の型は、関数に渡す値の型を指定します。
    // 引数の名前は、関数に渡す値の名前を指定します。
    // 引数の型と引数の名前は、カンマで区切って複数指定できます。
    // 例えば、以下の関数は、int型の引数を2つ受け取り、int型の値を返す関数です。
    // int Add(int a, int b)
    // {
    //     return a + b;
    // }
    //
    // 関数の定義は、以下のように記述します。
    // 戻り値の型 関数名(引数の型 引数の名前, 引数の型 引数の名前, ...)
    // {
    //     // 関数の処理
    //     return 戻り値;
    // }
    //
    // 以下の関数は、int型の引数を2つ受け取り、int型の値を返す関数です。
    // int Add(int a, int b)
    // {
    //   return a + b;
    // }
    // この関数を呼び出すには、以下のように記述します。
    // int c = Add(1, 2);
    // この関数を呼び出すと、1と2が足された値がcに代入されます。
    // このように、関数を呼び出すことを関数の呼び出しといいます。
    // 関数の呼び出しは、以下のように記述します。
    // 戻り値の型 変数名 = 関数名(引数の値, 引数の値, ...);
    //
    // 関数は一般的に他の関数から呼び出すことが多いため、ここでもメインモジュールとは別のスコープで関数を定義します。
    // したがって、トップレベルステートメントを使用せずに、Main関数を定義します。

    // Add関数の呼び出し
    Console.WriteLine(Add(1, 2));

    // >>> 実行結果
    // 3

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // 次にデフォルト引数について説明します。
    // デフォルト引数は、関数の引数に指定した値を省略した場合に、指定した値が使用される引数です。
    // 例えば、以下の関数は、第一引数と第二引数が省略された場合に、指定されたデフォルトの値が使用されます。
    // int Add(int a = 1, int b = 2)
    // {
    //     return a + b;
    // }
    //
    // では、この引数を引数を省略して呼び出してみましょう♪
    // int c = Add();
    // この関数を呼び出すと、1と2が足された値がcに代入されます。

    // AddDefault関数の呼び出し
    Console.WriteLine(AddDefault());

    // >>> 実行結果
    // 3

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // 名前付き引数を
    // 次に名前付き引数について説明します。
    // 名前付き引数は、関数の引数に指定した名前を指定して、引数の値を渡す引数です。
    // 例えば、以下の関数は、第一引数と第二引数に名前を指定しています。
    // int Substract(int a, int b)
    // {
    //     return a - b;
    // }
    //
    // では、この引数を名前付き引数で呼び出してみましょう♪
    // int c = Substract(b: 2, a: 1);
    // この関数を呼び出すと、1から2が引かれた値がcに代入されます。
    // これは以下の呼び出しと同じです。
    // int c = Substract(1, 2);
    // もしくは冗長に以下のように書くこともできます。
    // int c = Substract(a: 1, b: 2);

    // Substract関数の呼び出し
    Console.WriteLine(Substract(b: 2, a: 1));
    Console.WriteLine(Substract(1, 2));
    Console.WriteLine(Substract(a: 1, b: 2));

    // >>> 実行結果
    // -1
    // -1
    // -1

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // 次に可変長引数について説明します。
    // 可変長引数は、関数の引数に指定した型の引数を複数指定できる引数です。
    // 例えば、以下の関数は、第一引数と第二引数にint型の引数を複数指定できます。
    // int Sum(params int[] values)
    // {
    //     int sum = 0;
    //     foreach (int value in values)
    //     {
    //         sum += value;
    //     }
    //     return sum;
    // }
    //
    // では、この引数を可変長引数で呼び出してみましょう♪
    // int c = Sum(1, 2, 3, 4, 5);
    // この関数を呼び出すと、1から5までの合計がcに代入されます。

    // Sum関数の呼び出し
    Console.WriteLine(Sum(1, 2, 3, 4, 5));
    Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
    Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15));

    // >>> 実行結果
    // 15
    // 55
    // 120

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // 次にオーバーロードについて説明します。
    // オーバーロードとは、同じ名前の関数を複数定義することです。
    // 例えば、以下の関数は、第一引数と第二引数にint型の引数を複数指定できます。
    // int SumOverload(params int[] values)
    // {
    //     int sum = 0;
    //     foreach (int value in values)
    //     {
    //         sum += value;
    //     }
    //     return sum;
    // }
    //
    // また、以下の関数は、第一引数と第二引数にdouble型の引数を複数指定できます。
    // double SumOverload(params double[] values)
    // {
    //     double sum = 0;
    //     foreach (double value in values)
    //     {
    //         sum += value;
    //     }
    //     return sum;
    // }
    //

    // では、この引数をオーバーロードで呼び出してみましょう♪

    // SumOverload関数の呼び出し
    Console.WriteLine(SumOverload(1, 2, 3, 4, 5));
    Console.WriteLine(SumOverload(1.0, 2.0, 3.0, 4.0, 5.0));

    // >>> 実行結果
    // overload I am int.
    // 15
    // overload I am double.
    // 15

    // オーバーロードが発生するためには、以下の条件を満たす必要があります。
    // 1. 同じ名前の関数を複数定義する。
    // 2. 引数の型、引数の数、引数の順番が異なる。
    // 3. 戻り値の型が異なる。

    // 呼びだされる関数は、その呼び出し元の環境にあったものになります。

  }

  // Add関数の定義
  // 第一引数: a (int型)
  // 第二引数: b (int型)
  // 戻り値: int型
  private static int Add(int a, int b)
  {
    return a + b;
  }

  // デフォルト引数の定義
  // 第一引数: a (int型)
  // 第二引数: b (int型)
  // 戻り値: int型
  private static int AddDefault(int a = 1, int b = 2)
  {
    return a + b;
  }

  // 名前付き引数の定義
  // 第一引数: a (int型)
  // 第二引数: b (int型)
  // 戻り値: int型
  private static int Substract(int a, int b)
  {
    return a - b;
  }

  // 可変長引数の定義
  // 第一引数: values (int型の配列)
  // 戻り値: int型
  private static int Sum(params int[] values)
  {
    int sum = 0;
    foreach (int value in values)
    {
      sum += value;
    }
    return sum;
  }

  // オーバーロードの定義
  // 第一引数: values (int型の配列)
  // 戻り値: int型
  private static int SumOverload(params int[] values)
  {
    Console.WriteLine("overload I am int.");
    int sum = 0;
    foreach (int value in values)
    {
      sum += value;
    }
    return sum;
  }

  // オーバーロードの定義
  // 第一引数: values (double型の配列)
  // 戻り値: double型
  private static double SumOverload(params double[] values)
  {
    Console.WriteLine("overload I am double.");
    double sum = 0;
    foreach (double value in values)
    {
      sum += value;
    }
    return sum;
  }

}

