using JustForTesting.Contracts;

namespace JustForTesting.Implementation;

public class MessageToMyFriend : IWriteMessage
{
    public void Write(string content)
    {
        Console.WriteLine("You send a message: {cont}", content);
    }
}