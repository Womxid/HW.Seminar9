int NumEnter(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

System.Console.WriteLine("Небольшой тест по астрономии");
Console.ReadLine();
int points = 0;
Console.Clear();
System.Console.WriteLine("1)Самая крупная планета солнечной системы?");
System.Console.WriteLine();
System.Console.WriteLine("1. Солнце");
System.Console.WriteLine("2. Марс");
System.Console.WriteLine("3. Юпитер");
System.Console.WriteLine("4. Земля");
System.Console.WriteLine();
int NumTask1 = NumEnter("Ваш ответ?");

switch (NumTask1)
{
    case 3: System.Console.WriteLine("Ответ верный"); points++; break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();
Console.Clear();
System.Console.WriteLine("2)Путь по которому движется небесное тело?");
System.Console.WriteLine();
System.Console.WriteLine("1. Орбита");
System.Console.WriteLine("2. Радиус");
System.Console.WriteLine("3. Окружность");
System.Console.WriteLine("4. Хвост");
System.Console.WriteLine();
int NumTask2 = NumEnter("Ваш ответ?");

switch (NumTask2)
{
    case 1: System.Console.WriteLine("Ответ верный"); points++; break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");

Console.ReadLine();
Console.Clear();
System.Console.WriteLine("3)Количество планет в солнечной системе?");
System.Console.WriteLine();
System.Console.WriteLine("1. Девять");
System.Console.WriteLine("2. Семь");
System.Console.WriteLine("3. Десять");
System.Console.WriteLine("4. Восемь");
System.Console.WriteLine();
int NumTask3 = NumEnter("Ваш ответ?");

switch (NumTask3)
{
    case 4: System.Console.WriteLine("Ответ верный"); points++; break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();


Console.Clear();
System.Console.WriteLine("4)Самая близкая к Земле звезда?");
System.Console.WriteLine();
System.Console.WriteLine("1. Ригель");
System.Console.WriteLine("2. Солнце");
System.Console.WriteLine("3. Сириус");
System.Console.WriteLine("4. Проксима Центавра");
System.Console.WriteLine();
int NumTask4 = NumEnter("Ваш ответ?");

switch (NumTask4)
{
    case 2: System.Console.WriteLine("Ответ верный"); points++; break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("5)Самая близкая к звезда Солнцу?");
System.Console.WriteLine();
System.Console.WriteLine("1. Ригель");
System.Console.WriteLine("2. Солнце");
System.Console.WriteLine("3. Сириус");
System.Console.WriteLine("4. Проксима Центавра");
System.Console.WriteLine();
int NumTask5 = NumEnter("Ваш ответ?");

switch (NumTask5)
{
    case 4: System.Console.WriteLine("Ответ верный"); points++; break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("6)Название галактики в которой находится звездная система?");
System.Console.WriteLine();
System.Console.WriteLine("1. Туманность Андромеды");
System.Console.WriteLine("2. Скопление Кассиопеи");
System.Console.WriteLine("3. Млечный путь");
System.Console.WriteLine("4. Галактика М52");
System.Console.WriteLine();
int NumTask6 = NumEnter("Ваш ответ?");

switch (NumTask6)
{
    case 3: System.Console.WriteLine("Ответ верный"); points++; break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("7)Как называется сверхмассивная черная дыра расположенная в центре нашей галактики?");
System.Console.WriteLine();
System.Console.WriteLine("1. Темный шар");
System.Console.WriteLine("2. Стрелец А");
System.Console.WriteLine("3. Козерог В");
System.Console.WriteLine("4. Очень большая медведица");
System.Console.WriteLine();
int NumTask7 = NumEnter("Ваш ответ?");

switch (NumTask7)
{
    case 2: System.Console.WriteLine("Ответ верный"); points++; break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("8)Кто первым доказал что Земля вращается вокруг Солнца?");
System.Console.WriteLine();
System.Console.WriteLine("1. Г. Галилей");
System.Console.WriteLine("2. Дж. Бруно");
System.Console.WriteLine("3. Н. Коперник");
System.Console.WriteLine("4. Х. Колумб");
System.Console.WriteLine();
int NumTask8 = NumEnter("Ваш ответ?");

switch (NumTask8)
{
    case 3: System.Console.WriteLine("Ответ верный"); points++; break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("9)Сколько длится год на плутоне?");
System.Console.WriteLine();
System.Console.WriteLine("1. 248 земных лет");
System.Console.WriteLine("2. 573 земных года");
System.Console.WriteLine("3. 20 земных часов");
System.Console.WriteLine("4. 35 земных лет");
System.Console.WriteLine();
int NumTask9 = NumEnter("Ваш ответ?");

switch (NumTask9)
{
    case 1: System.Console.WriteLine("Ответ верный"); points++; break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("10)Чему равно расстояние, которое приято обозначать как одна астрономическая единица?");
System.Console.WriteLine();
System.Console.WriteLine("1. Диаметр Солнца");
System.Console.WriteLine("2. Расстояние от Солнца до центра Млечного пути");
System.Console.WriteLine("3. Диаметр Земли");
System.Console.WriteLine("4. Расстояние от Земли до Солнца");
System.Console.WriteLine();
int NumTask10 = NumEnter("Ваш ответ?");

switch (NumTask10)
{
    case 4: System.Console.WriteLine("Ответ верный"); points++; break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("11)Кто изобрел первый телескоп?");
System.Console.WriteLine();
System.Console.WriteLine("1. Г. Галилей");
System.Console.WriteLine("2. Х. Янсен");
System.Console.WriteLine("3. Э. Хаббл");
System.Console.WriteLine("4. З. Янсен");
System.Console.WriteLine();
int NumTask11 = NumEnter("Ваш ответ?");

switch (NumTask11)
{
    case 1: System.Console.WriteLine("Ответ верный"); points++; break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("12)Что такое экзопланета?");
System.Console.WriteLine();
System.Console.WriteLine("1. Планета на которой есть жизнь");
System.Console.WriteLine("2. Синоним карликовой планеты");
System.Console.WriteLine("3. Планета за пределами солнечной системы");
System.Console.WriteLine("4. Сверхмассивная планета");
System.Console.WriteLine();
int NumTask12 = NumEnter("Ваш ответ?");

switch (NumTask12)
{
    case 3: System.Console.WriteLine("Ответ верный"); points++; break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("13)Самая яркая звезда на земном небе?");
System.Console.WriteLine();
System.Console.WriteLine("1. Ригель");
System.Console.WriteLine("2. Солнце");
System.Console.WriteLine("3. Сириус");
System.Console.WriteLine("4. Проксима Центавра");
System.Console.WriteLine();
int NumTask13 = NumEnter("Ваш ответ?");

switch (NumTask13)
{
    case 3: System.Console.WriteLine("Ответ верный"); points++; break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("14)Какого астронома инквизиция сожгла на костре?");
System.Console.WriteLine();
System.Console.WriteLine("1. Г. Галилей");
System.Console.WriteLine("2. Дж. Бруно");
System.Console.WriteLine("3. Н. Коперник");
System.Console.WriteLine("4. Э. Хаббл");
System.Console.WriteLine();
int NumTask14 = NumEnter("Ваш ответ?");

switch (NumTask14)
{
    case 2: System.Console.WriteLine("Ответ верный"); points++; break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 3: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Количество правильных ответов {points} из 15");
Console.ReadLine();

Console.Clear();
System.Console.WriteLine("15)Самая большая звезда из изветстных на данный момент, чей радиус в раз больше 2000 радиуса Солнца?");
System.Console.WriteLine();
System.Console.WriteLine("1. UY Щита");
System.Console.WriteLine("2. Бетельгейзе");
System.Console.WriteLine("3. Stephenson 2-18");
System.Console.WriteLine("4. PZ Кассиопеи");
System.Console.WriteLine();
int NumTask15 = NumEnter("Ваш ответ?");

switch (NumTask15)
{
    case 3: System.Console.WriteLine("Ответ верный"); points++; break;
    case 4: System.Console.WriteLine("Ответ неверный"); break;
    case 2: System.Console.WriteLine("Ответ неверный"); break;
    case 1: System.Console.WriteLine("Ответ неверный"); break;

}
System.Console.WriteLine($"Тест завершен. Вы набрали {points} из 15.");