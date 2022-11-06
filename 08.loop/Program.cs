// ここでは反復処理について学習します。
// 反復処理を実現するための技術として、for文、while文、do-while文、foreach文があります。
// for文は、反復回数が決まっている場合に使用します。
// while文は、反復回数が決まっていない場合に使用します。
// do-while文は、反復回数が決まっていない場合に使用します。
// foreach文は、配列やコレクションを反復処理する場合に使用します。
// それぞれの反復処理の特徴を学び、実際にプログラムを書いてみましょう。

// for文
for (int i = 0; i < 10; i++)
{
  Console.WriteLine($"for loop -> {i}");
}

// while文
int j = 0;
while (j < 10)
{
  Console.WriteLine($"while loop -> {j}");
  j++;
}

// do-while文
int k = 0;
do
{
  Console.WriteLine($"do-while loop -> {k}");
  k++;
} while (k < 10);

// foreach文
int[] array = { 1, 2, 3, 4, 5 };
foreach (int l in array)
{
  Console.WriteLine($"foreach loop -> {l}");
}

// コレクションについては後ほど説明しますが、複数のデータをまとめて管理するデータ型だと認識してください。
