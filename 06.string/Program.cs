// ここでは、論理値(真偽値)について学習します。
// 論理値とはyes or noのような値のことです。
// C#では、論理値はbool型で表現されます。
// bool型はtrueとfalseの2つの値を持ちます。

// 以下のように、bool型の変数を宣言します。
bool isTrue = true;
bool isFalse = false;

// 論理値には以下の演算か可能です。
// 論理積(AND)：&&
// 論理和(OR)：||
// 否定(NOT)：!

// 論理積は、両方の値がtrueのときにtrueを返します。
Console.WriteLine(true && true); // true
Console.WriteLine(true && false); // false
Console.WriteLine(false && true); // false
Console.WriteLine(false && false); // false

// 論理和は、どちらかの値がtrueのときにtrueを返します。
Console.WriteLine(true || true); // true
Console.WriteLine(true || false); // true
Console.WriteLine(false || true); // true
Console.WriteLine(false || false); // false

// 否定は、値がtrueのときにfalseを、falseのときにtrueを返します。
Console.WriteLine(!true); // false
Console.WriteLine(!false); // true
