string name;
string age;
string person;
string place;

Console.WriteLine("What's your name?");
name = Console.ReadLine ();

Console.WriteLine("What's your age");
age = Console.ReadLine ();

Console.WriteLine("What's your least liked person?");
person = Console.ReadLine ();

Console.WriteLine("What is your favorit place to be in?");
place = Console.ReadLine ();

Console.WriteLine($"Today {name} died in {place} at the age of {age} by the hands of {person}. They will not be missed.");
Console.ReadLine ();