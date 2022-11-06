
internal class MyClass
{
  internal static void Main()
  {
    // ここでは、構造体について説明します。
    // 構造体は、クラスと似ていますが、クラスとは異なり、
    // 値型として扱われます。
    // これは、構造体のインスタンスを変数に代入した場合、
    // その変数には、構造体の値がコピーされるということです。
    // したがって、関数間で構造体のインスタンスを渡した場合、
    // 新しく構造体が生成されるため、不要なメモリの浪費につながります。
    // したがって、関数間で構造体のインスタンスを渡す場合、
    // 参照型として扱うために、refやoutを使用するか、代わりにクラスを使用します。
    // また、構造体はオブジェクト指向をサポートしていないため、
    // クラスのように継承することはできません。
    //
    // 構造体は、小さなデータを扱う場合に使用します。

    // 構造体のインスタンスの生成はクラスと同じです。
    // ただし、new演算子を使用する必要はありません。

    LessonStruct lessonStruct = new()
    {
      Name = "C#",
      Price = 100,
    };

    // 構造体は値型であるため、
    // 構造体のインスタンスを関数の引数に渡した場合、
    // 構造体の値がコピーされます。

    Console.WriteLine($"lessonStruct.Name = {lessonStruct.Name}, lessonStruct.Price = {lessonStruct.Price}");

    // >>> lessonStruct.Name = C#, lessonStruct.Price = 100

    Inflation(lessonStruct);

    Console.WriteLine($"lessonStruct.Name = {lessonStruct.Name}, lessonStruct.Price = {lessonStruct.Price}");

    // >>> lessonStruct.Name = C#, lessonStruct.Price = 100

    // 構造体は、値型であることが確認できます。

    // refを使用して、参照型にすることは可能ですが、
    // クラスを使用したほうが簡単です。

    Inflation(ref lessonStruct);

    Console.WriteLine($"lessonStruct.Name = {lessonStruct.Name}, lessonStruct.Price = {lessonStruct.Price}");

    // >>> lessonStruct.Name = C#, lessonStruct.Price = 120

    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
    // ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
    // ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

    // 構造体は、値型であるため、
    // Equalメソッドを使用してメンバの値の等価性を判断することができます。

    LessonStruct lessonStruct1 = new()
    {
      Name = "C#",
      Price = 100,
    };

    LessonStruct lessonStruct2 = new()
    {
      Name = "C#",
      Price = 100,
    };

    Console.WriteLine($"lessonStruct1 == lessonStruct2 : {lessonStruct1.Equals(lessonStruct2)}");

    // >>> lessonStruct1 == lessonStruct2 : True

    // これは参照型であるクラスではひとつひとつ値を比較する必要があります。

    LessonClass lessonClass1 = new()
    {
      Name = "C#",
      Price = 100,
    };

    LessonClass lessonClass2 = new()
    {
      Name = "C#",
      Price = 100,
    };

    Console.WriteLine($"lessonClass1 == lessonClass2 : {lessonClass1.Equals(lessonClass2)}");

    // >>> lessonClass1 == lessonClass2 : False

  }

  internal static void Inflation(LessonStruct lessonStruct)
  {
    // 構造体の値がコピーされるため、
    // lessonStructの値は変更されません。
    lessonStruct.Price *= 1.2;
  }

  internal static void Inflation(ref LessonStruct lessonStruct)
  {
    lessonStruct.Price *= 1.2;
  }

}

struct LessonStruct
{
  public string Name;
  public double Price;
}

class LessonClass
{
  public string Name;
  public double Price;
}
