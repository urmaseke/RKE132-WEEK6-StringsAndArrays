

string hello = "hello, world!";
    int stringLength= hello.Length;

hello = hello.Trim();

char firstletter  = hello[0];
Console.WriteLine(firstletter);
hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstletter = hello[0];
Console.WriteLine(firstletter);

Console.WriteLine(hello);