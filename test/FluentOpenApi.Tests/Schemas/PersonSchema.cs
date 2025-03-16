﻿using FluentOpenApi.Extensions;
using FluentOpenApi.Test.Model;

namespace FluentOpenApi.Test.Schemas;
public class PersonSchema : ModelSchema<Person>
{
    public PersonSchema()
    {
        PropertyFor(x => x.Name)
            .Required()
            .RegularExpression(@"^[a-zA-Z\s]+$")
            .MinLength(2)
            .MaxLength(50)
            .WithDescription("Person's full name")
            .WithDefault("John Doe");

        PropertyFor(x => x.Age)
            .Range(0, 150);

        PropertyFor(x => x.Email)
            .Required()
            .WithDescription("Contact email");

        PropertyFor(x => x.Items)
            .ItemsRange(1, 5);
    }
}
