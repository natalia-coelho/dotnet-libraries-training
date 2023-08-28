# dotnet-libraries-training

*A training for Libraries Creation & Deployment with .Net*

## Creating and Referencing Libraries

To create a library of classes, follow these steps:

1. Create a class library project named "modelos".
2. Add the "modelos" project as a reference in your main project.

You can view these references in your code by clicking on the `.csproj` file in Visual Studio.

Using these libraries, we can build our project like assembling LEGO pieces. Each library serves a specific function. For instance, one library might generate files, another could connect to a database, and yet another might handle the graphical interface.

## Utilizing Third-Party Libraries

To make use of third-party libraries:

### NuGet Package Manager

- You can search for packages that provide the functionality you need.
- An example library is **NewtonSoft JSON**, which can serialize objects into JSON format.

## Visibility of Classes

### Internal Classes

- These are accessible only within their own assemblies (DLL or exe).
- This visibility mode is common in library development and component projects.
- For more information, refer to the [official documentation](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/internal).

### Protected Internal

- This visibility mode combines aspects of both "protected" and "internal".
- To learn more, check the [official documentation](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/private-protected).

Feel free to reach out if you need any further clarifications or additional organization!
