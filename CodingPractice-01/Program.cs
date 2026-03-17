using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.
/*
//1.
int[] numbers = { 1, 2, 3, 4, 5 };

IEnumerable<int> result = numbers.Where(n => n > 3);

foreach (var item in result)
{
    Console.WriteLine(item);
}

//2.
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

var filtered = names.Where(n => n.Contains("a"));

foreach (var item in filtered)
{
    Console.WriteLine(item);
}

//3.
string[] names = { "Tom", "Dick", "Harry" };

var uppercased = names.Select(n =>  n.ToUpper());

foreach (var item in uppercased)
{
    Console.WriteLine(item);
}

//4.
string[] colores = { "Red", "Green", "Blue" };

var sorted = colores.OrderBy(c => c);

foreach (var item in sorted)
{
    Console.WriteLine(item);
}

//5.
int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };

var descending = numbers.OrderByDescending(n => n);

foreach (var item in descending)
{
    Console.Write(item + " ");
}

//6.
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

var query = names
    .Where(n => n.Contains("a"))
    .OrderBy(n => n.Length)
    .Select(n => n.ToUpper());

foreach (var item in query)
{
    Console.WriteLine(item);
}

//7.
int[] numbers = { 1, 2, 3, 4, 5 };

var query = from n in numbers
            where n % 2 == 0
            select n;

foreach (var item in query)
{
    Console.WriteLine(item);
}

//8.
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

var query = from n in names
            where n.Contains("a")
            orderby n.Length
            select n.ToUpper();

foreach (var item in query)
{
    Console.WriteLine(item);
}
*/
//9.
int[] numbers = { 3, 2, 1, 4, 5 };

var methodResult = numbers
    .Where(n => n % 2 == 1)
    .OrderBy(n => n);

var queryResult = from n in numbers
                  where n % 2 == 1
                  orderby n
                  select n;

Console.WriteLine("메서드 구문:");
foreach (var n in methodResult)
{
    Console.Write(n + " ");   
}
Console.WriteLine("\n쿼리 구문:");
foreach (var n in queryResult)
{
    Console.Write(n + " ");
}