using System;
using System.Collections.Generic;
using System.Linq;

List<GameItem> items = new List<GameItem>
{
    new GameItem("나무 검", "무기", "일반", 100, 3 ),
    new GameItem("강철 대검", "무기", "희귀", 800, 1 ),
    new GameItem("용의 검", "무기", "전설", 5000, 1 ),
    new GameItem("가죽 갑옷", "방어구", "일반", 200, 2 ),
    new GameItem("미스릴 갑옷", "방어구", "희귀", 1200, 1 ),
    new GameItem("드래곤 갑옷", "방어구", "전설", 8000, 0 ),
    new GameItem("체력 물약", "소비", "일반", 50, 10 ),
    new GameItem("마나 물약", "소비", "일반", 80, 5 ),
    new GameItem("고급 물약", "소비", "희귀", 500, 0 ),
    new GameItem("엘릭서", "소비", "전설", 3000, 2 ),
};

var price_descending = items.Where(n => n.Price >= 500).OrderByDescending(n => n.Price); //1
var grade_order = from n in items
                  let grade = n.Grade == "일반" ? 1 : (n.Grade == "희귀" ? 2 : 3)
                  where n.Type == "무기"
                  orderby grade
                  select n;

var totalCount = from n in items   //3
                 let total = n.Price * n.Quantity
                 where total >= 1000
                 select n;
var quantity_zero = items.Where(n => n.Quantity == 0).OrderBy(n => n.Name); //4
var grade_legend = items.Where(n => n.Grade == "전설").Select(n => new { name = n.Name, price = n.Price }); //5

Console.WriteLine("=== 쿼리 1: 가격 500 이상 (가격 내림차순) ===");
foreach (var item in price_descending)
{
    Console.WriteLine($"{item.Name} - {item.Type} - {item.Price}원");
}

Console.WriteLine("\n=== 쿼리 2: 무기 타입 (등급순) ===");
foreach (var item in grade_order)
{
    Console.WriteLine($"{item.Name} - {item.Grade} - {item.Price}원");
}

Console.WriteLine("\n=== 쿼리 3: 총 가치 1000 이상 ===");
foreach (var item in totalCount)
{
    Console.WriteLine($"{item.Name} - 총 가치: {item.Price * item.Quantity}");
}

Console.WriteLine("\n=== 쿼리 4: 품절 아이템 (이름순) ===");
foreach (var item in quantity_zero)
{
    Console.WriteLine($"{item.Name}");
}

Console.WriteLine("\n=== 쿼리 5: 전설 등급 (이름과 가격) ===");
foreach (var item in grade_legend)
{
    Console.WriteLine($"{item.name} - {item.price}원");
}
class GameItem
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Grade { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public GameItem(string n, string t, string g, int p, int q)
    {
        Name = n; Type = t; Grade = g; Price = p; Quantity = q;
    }
}