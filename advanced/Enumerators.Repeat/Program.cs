// See https://aka.ms/new-console-template for more information

List<string> MyMessages = Enumerable.Repeat("Keep coding!", 15).ToList();
MyMessages.ForEach(Console.WriteLine);