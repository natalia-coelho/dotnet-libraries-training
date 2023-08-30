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


---

### Generic Classes
[Generic Classes Documentation](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/generics/generic-classes)

Accepts any object format 

**PDB Files**

    *PDB is an abbreviation for Program-Debug Data Base. As the name suggests, it is a repository (persistent storage such as databases) to maintain information required to run your program in debug mode. It contains several vital information required for code debugging e.g. at what points you have put break points where you expect the debugger to break in Visual Studio (VS).*


### Class Documentation Style

```
    /// <summary>
    /// write smth here!
    /// </summary>
```
---
### Turning my DLLs into nuget packages
- Access nuget.org and login with your microsoft account
- It's possible to define some properties as "Name", "Company", "Title", "Description", "PackageTags" and so on at the csproj xml file (if none is defined, the default value will be your project's Assembly Name). Defining those properties will easy other developers to find your package through nuget. [See Microsoft Documentation for more information](https://learn.microsoft.com/en-us/nuget/create-packages/creating-a-package-dotnet-cli) =) 
- Run dotnet cli command `dotnet pack` inside the project. This will generate a nupkg with the defined properties.