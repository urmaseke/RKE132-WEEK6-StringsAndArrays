string[] snacks = { "pelmeenid", "pitsa", "kartulid" };
Random rnd=new Random();
int randomindex=rnd.Next(snacks.Length);
Console.WriteLine($"Today we are eating: {snacks[randomindex]}");
