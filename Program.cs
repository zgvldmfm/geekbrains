Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

void check (int dayWeek) {
  if (dayWeek == 6 || dayWeek == 7) {
  Console.WriteLine("Вы выбрали выходной день");
  }
  else if (dayWeek < 1 || dayWeek > 7) {
    Console.WriteLine("Вы не выбрали день недели");
  }
  else Console.WriteLine("Вы выбрали рабочий день");
}

check(dayWeek);