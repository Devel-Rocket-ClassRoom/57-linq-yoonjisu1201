using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading;
List<Product> products = new List<Product>
{
    new Product("Laptop", "Electronics", 1200),
    new Product("Mouse", "Electronics", 25),
    new Product("Keyboard", "Electronics", 75),
    new Product("Shirt", "Clothing", 50),
    new Product("Pants", "Clothing", 100),
    new Product("Desk", "Furniture", 250),
    new Product("Chair", "Furniture", 150),
    new Product("Monitor", "Electronics", 300)
};

var ProductNamesOver100 = products.Where(n => n.Price >= 100).Select(n => n.Name); //1번 쿼리
var ElectronicProducts = products.Where(n => n.Category == "Electronics"); //2번 쿼리
var AlphabetizedNames = products.OrderBy(n => n.Name).Select(n => n.Name); //3번 쿼리
double All_AveragePrice = 0;
if (products.Any())
{
    All_AveragePrice = products.Average(n => n.Price); // 4번 쿼리
}
var CheapestProduct = products.Where(n => n.Price == products.Min(n => n.Price)); //5번 쿼리
var ExpensiveProduct = products.Where(n => n.Price == products.Max(n => n.Price)); //6번 쿼리

var ElectronicsAverage = products
    .Where(n => n.Category == "Electronics")
    .Average(n => n.Price); //7번 쿼리

var ProductsWithO = products
    .Where(n => n.Name.Contains("o"))
    .Select(n => n.Name.ToUpper()); // 8번 쿼리

var ReverseClothingList = products
    .Where(n => n.Category == "Clothing")
    .OrderByDescending(n => n.Name)
    .Select(n => n.Name); // 9번 쿼리

var PriceFilteredProducts = products
    .Where(n => n.Price >= 50 && n.Price <= 300)
    .OrderBy(n => n.Price)
    .ThenBy(p => p.Name); // 10번 쿼리

Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
foreach (var item in ProductNamesOver100)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n=== 문제 2: Electronics 카테고리 ===");
foreach (var item in ElectronicProducts)
{
    Console.WriteLine($"{item.Name} - {item.Category} - {item.Price}원");
}

Console.WriteLine("\n=== 문제 3: 이름순 정렬 ===");
foreach (var item in AlphabetizedNames)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n=== 문제 4: 평균 가격 ===");
Console.WriteLine($"{All_AveragePrice}원");


Console.WriteLine("\n=== 문제 5: 가장 저렴한 상품 ===");
foreach (var item in CheapestProduct)
{
    Console.WriteLine($"{item.Name} - {item.Price}원");
}

Console.WriteLine("\n=== 문제 6: 가장 비싼 상품 ===");
foreach (var item in ExpensiveProduct)
{
    Console.WriteLine($"{item.Name} - {item.Price}원");
}

Console.WriteLine("\n=== 문제 7: Electronics 평균 가격 ===");
Console.WriteLine($"{ElectronicsAverage}원");

Console.WriteLine("\n=== 문제 8: 'o' 포함 상품 (대문자) ===");
foreach (var item in ProductsWithO)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n=== 문제 9: Clothing 역순 ===");
foreach (var item in ReverseClothingList)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n=== 문제 10: 가격 50~300, 복합 정렬 ===");
foreach (var item in PriceFilteredProducts)
{
    Console.WriteLine($"{item.Name} - {item.Price}원");
}
