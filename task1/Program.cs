//координаты точки

//int x = ReadInt("X");
//int y = ReadInt("Y");
//
//if (IsCoordinatesCorrect(x, y))
//	Console.WriteLine(GetQuarter(x, y));
//else
//	Console.WriteLine("Ooops");
//
//
//int ReadInt(string argument)
//{
//   Console.Write($"Input{argument}: ");
//
//    int i;
//
//    while(!int.TryParse(Console.ReadLine(), out i))
//    {
//        Console.WriteLine("It's not a number");
//    }
//}
//
//int GetQuarter(int x, int y)
//{
//    if (x > 0 && y > 0)
 //   {
   //     return 1;
  //  }
  //  else if (x < 0 && y > 0)
  //  {
    //    return 2;
    //}
    //else if (x < 0 && y < 0)
    //{
      //  return 3;
   // }
    //else
    //{
      //  return 4;
    //}
//}


int x = ReadInt("X");
int y = ReadInt("Y");

if (IsCoordinatesCorrect(x, y))
	Console.WriteLine(GetQuarter(x, y));
else
	Console.WriteLine("Ooops");


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");

	int i;

	while (!int.TryParse(Console.ReadLine(), out i))
	{
		Console.WriteLine("It's not a number");
	}

	return i;
}

int GetQuarter(int x, int y)
{
	if (x > 0 && y > 0)
	{
		return 1;
	}
	else if (x < 0 && y > 0)
	{
		return 2;
	}
	else if (x < 0 && y < 0)
	{
		return 3;
	}
	else
	{
		return 4;
	}
}

bool IsCoordinatesCorrect(int x, int y)
{
	if (x == 0 || y == 0)
	{
		return false;
	}

	return true;
}