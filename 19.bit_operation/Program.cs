
// ここでは使わなそうで、よく意外と使う、ビット演算子を紹介します。

{
  // ビット演算子には以下の種類があります。
  // &  : 論理積
  // |  : 論理和
  // ^  : 排他的論理和
  // ~  : 否定
  // << : 左シフト
  // >> : 右シフト
  
  const int a = 31;
  const int b = 15;
  
  Console.WriteLine(a & b); // 15
  Console.WriteLine(a | b); // 31
  Console.WriteLine(a ^ b); // 16
  Console.WriteLine(~a); // -32
  Console.WriteLine(a << 1); // 62
  Console.WriteLine(a >> 1); // 15
}

