
{
  // 日付型の作成

  DateTime dt_1 = new(1998, 10, 25);
  Console.WriteLine($"new DateTime(1998, 10, 25) -> {dt_1}");

  // >>> コンソール
  // new DateTime(1998, 10, 25) -> 1998/10/25 0:00:00

  DateTime dt_2 = new(1998, 10, 25, 12, 34, 56);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56) -> {dt_2}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56) -> 1998/10/25 12:34:56

  DateTime dt_3 = new(1998, 10, 25, 12, 34, 56, 789);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56, 789) -> {dt_3}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56, 789) -> 1998/10/25 12:34:56.789

  DateTime dt_4 = new(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Local);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Local) -> {dt_4}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Local) -> 1998/10/25 12:34:56.789

  DateTime dt_5 = new(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Utc);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Utc) -> {dt_5}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Utc) -> 1998/10/25 12:34:56.789

  DateTime dt_6 = new(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Unspecified);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Unspecified) -> {dt_6}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Unspecified) -> 1998/10/25 12:34:56.789
}
