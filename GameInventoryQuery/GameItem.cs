using System;
using System.Collections.Generic;
using System.Text;

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
