// Handlers/CreatePersonCommandHandler.cs
using System;
using System.Collections.Generic;
using System.Threading;
using MediatR;
using MediatR_CRUD.Commands;
using MediatR_CRUD.Model;

public class CreatePersonCommandHandler
{
    private static List<Person> _persons = new List<Person>();
    private static int _idCounter = 1;

    public int Handle(CreatePersonCommand command)
    {
        var person = new Person
        {
            Id = _idCounter++,
            Name = command.Name,
            Age = command.Age
        };

        _persons.Add(person);
        return person.Id;
    }
}