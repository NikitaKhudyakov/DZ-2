bool isWork = true;

while (isWork)
{
	Console.Write("Введите номер задания :");

int.TryParse(Console.ReadLine(), out int i);
	{
		switch (i)
		{
			case 1:
			{
				    Console.WriteLine ("Введите трехзначное число");
                    int a = int.Parse(Console.ReadLine());
                    int numb1 = a;

                    if ( numb1 < 999 )
                    {
                    numb1 = a / 10 % 10;
                    Console.WriteLine (numb1);
                    }
                    else Console.WriteLine ("Вы ввели неправильное значение");
			break;
			}
			case 2:
			{
				
                    Console.WriteLine ("Введите число больше 100");
                    string numb = Console.ReadLine().ToString();
                    int a = int.Parse(numb);
                    if (a < 99)
                    {
                    Console.WriteLine("Нет третьего числа");
                    }
                    else Console.WriteLine($"{numb[2]} - третье число");
            break;         
			}
				
            case 3:
			{
		
                    Console.WriteLine ("Введите число от 1 до 7");
                    int numb = int.Parse(Console.ReadLine());

                    if (numb == 1) Console.WriteLine ("Понедельник. Не выходной");
                    else if (numb == 2) Console.WriteLine ("Вторник. Не выходной");
                    else if (numb == 3) Console.WriteLine ("Среда. Не выходной");
                    else if (numb == 4) Console.WriteLine ("Четверг. Не выходной");
                    else if (numb == 5) Console.WriteLine ("Пятница. Не выходной");
                    else if (numb == 6) Console.WriteLine ("Суббота. Выходной");
                    else if (numb == 7) Console.WriteLine ("Воскресенье. Выходной");
                    else if (numb++ > 7 || numb == 0 ) Console.WriteLine ("Вы ввели не верное значение");
            break;
            }
            
			case -1: isWork = false; break;
		}

	}}
