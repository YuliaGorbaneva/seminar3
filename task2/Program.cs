// string number (int count)
// {
//     Console.Wtite()
// }

// int ReadInt(string argument)
// {
// 	Console.Write($"Input {argument}: ");

// 	int i;

// 	while (!int.TryParse(Console.ReadLine(), out i))
// 	{
// 		Console.WriteLine("It's not a number");
// 	}

// 	return i;
// }

//int Find (int count)
//{
//
//}



// while (true)
// {
//     Console.Write("Введите цифру от 1 до 4: ");
//     string text = Console.ReadLine();
//     if (int.TryParse(text, out int number))
//     {
//         if(number == 1) {
//             Console.WriteLine($"от 1 до плюс бесконечности");
//         }
//         else if (number == 2) {
//             Console.WriteLine($"от минус 1 до плюс бесконечности");
//         }
//         else if (number == 3) {
//             Console.WriteLine($"от минус 1 до минус бесконечност");
//         } 
//         else if (number == 4) {
//             Console.WriteLine($"от минус 1 до минус бесконечност");
//         }  
//         else{
//             Console.Write("Упс!");
//         } 
        
               
//     }
//     else { 
//         Console.WriteLine("Не удалось распознать цифру.");
        
//     }
// }





Console.WriteLine("Введите номер четверти (1, 2, 3 или 4):");     
       int Chetv = int.Parse(Console.ReadLine());

       if (Chetv < 1 || Chetv > 4)
       {
        System.Console.WriteLine("Некоректный номер четверти. Введите число от 1 до 4");
        return;
       }

       string xA, yA;

        if (Chetv == 1)
       {
        xA = "(0, +∞)";
        yA = "(0, +∞)";
       }
       else if (Chetv == 2)
       {
        xA = "(-∞, 0)";
        yA = "(0, +∞)";
       }
       else if (Chetv == 3)
       {
        xA = "(-∞, 0)";
        yA = "(-∞, 0)";
       }
       else // Chetv == 4
       {
        xA = "(0, +∞)";
        yA = "(-∞, 0)";
       }
       System.Console.WriteLine($"Диапозон координат точек в {Chetv} четверти: ");
       System.Console.WriteLine($"x: {xA}");
       System.Console.WriteLine($"y: {yA}");