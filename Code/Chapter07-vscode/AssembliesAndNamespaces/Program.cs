using static System.Console;
using System.Xml.Linq;
using System;

XDocument doc = new XDocument();

string s1 = "Hello";
String s2 = "World";

WriteLine($"{s1} {s2}");

WriteLine($"int.MaxValue = {int.MaxValue:N0}");
WriteLine($"nint.MaxValue = {nint.MaxValue:N0}");