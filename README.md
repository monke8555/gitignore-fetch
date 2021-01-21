# gitignore-fetch
A small utility to fetch gitignore templates written in C#.

## Building

For all Linux, Windows, MacOS, run ```dotnet publish -c Release --self-contained true -r <runtime>``` where runtime is one of the [.NET Core RIDs](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog).
Basic RIDs:

osx-x64
linux-x64
win-x32
win-x64

## Usage
After running gitignore-fetch, supply the language, ide, or framework. E.G.

```gitignore-fetch
Android
```

Will print the gitignore into the console.

To create a gitignore file:

```gitignore-fetch Android```

Will create a .gitignore file in the folder in which the console is that contains the android gitignore template.

### THIS PROGRAM USES THE GITHUB GITIGNORES TEMPLATE REPOSITORY LOCATED AT: https://www.github.com/github/gitignore.
