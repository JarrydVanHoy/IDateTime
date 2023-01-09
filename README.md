# IDateTime

[![NuGet Status](https://img.shields.io/nuget/v/IDateTime.svg)](https://www.nuget.org/packages/IDateTime)
[![NuGet](https://img.shields.io/nuget/dt/IDateTime.svg)](https://www.nuget.org/packages/IDateTime)

Inject IDateTime to remove the hard dependency against the DateTime class. This makes it easier to decouple and test your code by making your use of DateTime mockable or providing your own implementation.

## NuGet Installation

Install the [IDateTime NuGet package](https://nuget.org/packages/IDateTime):

```.NET CLI
dotnet add package IDateTime
```

## Usage

First, add it to your IoC container:
```C#
services.AddIDateTime();
```

Inject `IDateTime` into your class:
```C#
public class ExampleService
{
    private readonly IDateTime _dateTime;
    
    public ExampleService(IDateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public DateTime WhenWasYesterday()
    {
        return _dateTime.UtcNow().AddDays(-1);
    }
}
```

Ping me if you want any new features added to the library ❤️
