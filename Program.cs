// Program.cs
using MediatR_CRUD.Commands;
using System;

class Program
{
    static void Main()
    {
        // Example: Create a new person
        var createCommand = new CreatePersonCommand { Name = "John Doe", Age = 30 };
        var createHandler = new CreatePersonCommandHandler();
        var createdPersonId = createHandler.Handle(createCommand);

        Console.WriteLine($"New person created with ID: {createdPersonId}");

        // Other CRUD operations...

        Console.ReadLine();
    }
}
