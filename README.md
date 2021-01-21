# gitignore-fetch
A small utility to fetch gitignore templates written in C#.

## Building

### Windows

You can use csc.exe to build it:

```csc gitignore-fetch.cs```

NOTE: Ensure that you have csc.exe in your path.

And then:

```gitignore-fetch```

### MacOS

You need to have .NET installed in order to build.

Run ```dotnet new console```

Then go in the directory and replace Program.cs with gitignore-fetch.cs, and then rename it to Program.cs.
Finally, run ```dotnet run```.

### Linux

You need to install mono from https://www.mono-project.com/.

Run ```csc gitignore-fetch.cs``` or ```mcs gitignore-fetch.cs```.
Then run the exe using ```mono gitignore-fetch.exe```.

https://www.mono-project.com/docs/getting-started/mono-basics/

## Usage
After running gitignore-fetch.exe, supply the language, ide, or framework. E.G.

```gitignore-fetch
Android
```

Will print the gitignore into the console.

To create a gitignore file:

```gitignore-fetch Android```

Will create a .gitignore file in the folder in which the console is that contains the android gitignore template.

### THIS PROGRAM USES THE GITHUB GITIGNORES TEMPLATE REPOSITORY LOCATED AT: https://www.github.com/github/gitignore.
