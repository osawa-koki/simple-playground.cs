// ここでは条件分岐について説明します。
// 条件分岐は、if文とswitch文があります。
// if文は、条件式の結果がtrueの場合に処理を実行します。
// switch文は、条件式の結果に応じて処理を実行します。
//
// 以下のように、if文を記述します。
// if (条件式) {
//     条件式がtrueの場合に実行される処理
// }
//
// 以下のように、if文を記述します。
// if (条件式) {
//     条件式がtrueの場合に実行される処理
// } else {
//     条件式がfalseの場合に実行される処理
// }
//
// 以下のように、if文を記述します。
// if (条件式1) {
//     条件式1がtrueの場合に実行される処理
// } else if (条件式2) {
//     条件式1がfalseで条件式2がtrueの場合に実行される処理
// } else {
//     条件式1と条件式2がfalseの場合に実行される処理
// }
//
// 以下のように、switch文を記述します。
// switch (条件式) {
//     case 条件1:
//         条件式の結果が条件1の場合に実行される処理
//         break;
//     case 条件2:
//         条件式の結果が条件2の場合に実行される処理
//         break;
//     default:
//         条件式の結果が条件1と条件2以外の場合に実行される処理
//         break;
// }
//

// では、if文を使用したプログラムを書いてみましょう♪

if (true)
{
  Console.WriteLine("条件式がtrueの場合に実行される処理");
} else
{
  Console.WriteLine("条件式がfalseの場合に実行される処理");
}

// では、条件分岐を複雑にしてみましょう♪

if (true)
{
  Console.WriteLine("条件式1がtrueの場合に実行される処理");
}
else if (true)
{
  Console.WriteLine("条件式1がfalseで条件式2がtrueの場合に実行される処理");
}
else
{
  Console.WriteLine("条件式1と条件式2がfalseの場合に実行される処理");
}

// では、switch文を使用したプログラムを書いてみましょう♪

switch (1)
{
  case 1:
    Console.WriteLine("条件式の結果が条件1の場合に実行される処理");
    break;
  case 2:
    Console.WriteLine("条件式の結果が条件2の場合に実行される処理");
    break;
  default:
    Console.WriteLine("条件式の結果が条件1と条件2以外の場合に実行される処理");
    break;
}

// 以上で、条件分岐について説明しました。
