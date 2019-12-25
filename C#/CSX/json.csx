#r "nuger: Newtonsoft.Json, 12.0.3"

using System;
using Newtonsoft.Json;

class Product
{
    public Guid Id { get; set; };
    public string Name { get; set; };
    public bool Enabled { get; set; };
}

var productObj = new Product
{
    Id = Guid.NewGuid(),
    Name = "FooBar",
    Enabled = true
};

Console.WriteLine(JsonConvert.SerializeObject(productObj));