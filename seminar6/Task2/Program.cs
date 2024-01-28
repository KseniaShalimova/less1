string str = "Hello";
char[] chars = new char[str.Length];
for (int i=0; i<str.Length; i++)
{
    chars[i]=str[i];
}

foreach (char e in chars)
{
    Console.WriteLine(e);
}