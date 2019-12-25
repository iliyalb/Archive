// dotnet tool install -g dotnet-script
// dotnet script hello.csx

using System;
using System.IO;

var today = DateTime.Now.ToString();
var message = $"Hello world!, The time is {today}";

Console.WriteLine(message);