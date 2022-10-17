// See https://aka.ms/new-console-template for more information

using JustForTesting.Implementation;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello again!");

var messageService = new MessageToMyFriend();
messageService.Write("Hello my friend, Alexander!");