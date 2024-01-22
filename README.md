# PerfectResult .NET 8 Result Handling Library
___

A library for elegantly handling operation results, including success and failure scenarios, with support for both generic and non-generic types. Designed for ease of use and integration into .NET projects.

## Description

This library offers a standardized way to represent the outcomes of operations, whether successful or failed. It includes both generic and non-generic implementations, allowing for flexibility and robust error handling in your .NET applications.

## Getting Started

Dependencies

    .NET 8
    An IDE like Visual Studio or VS Code for .NET development

## Installing via NuGet

To install the library, use the following NuGet command:

```bash
Install-Package PerfectResult
```

Or via the .NET CLI:

```bash
dotnet add package PerfectResult
```

## Usage

### Creating a Success Result

```csharp
var success = IResult.SuccessResult("Operation successful");
// For generic type
var successGeneric = IResult.SuccessResult(100, "Operation successful");
```

### Creating a Failure Result

```csharp
var failure = IResult.FailureResult("Operation failed", new Exception("Error detail"));
// For generic type
var failureGeneric = IResult.FailureResult<int>("Operation failed", new Exception("Error detail"));
```

But the most important is to use as a object from method:

```csharp
public IResult<MyObject> GetMyObject()
{
    if (* something is wrong *)
    {
        return IResult.FailureResult("Operation failed", new Exception("MyObject Failed"));
    }
    
    MyObject objectToReturn = new();
    return IResult.SuccessResult(objectToReturn);
}
```

## Contributing

Contributions to enhance this library are welcome. Please adhere to the following steps:

    Fork the repository.
    Create a new branch for your feature (git checkout -b feature/AmazingFeature).
    Commit your changes (git commit -m 'Add some AmazingFeature').
    Push to the branch (git push origin feature/AmazingFeature).
    Open a pull request.

## Version History

    0.1
        Initial Release.

## Authors

    Josef Širůčka

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.
