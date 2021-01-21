# gitignore-fetch
A small utility to fetch gitignore templates written in C#.

## Building
You can use csc.exe to build it:

```csc gitignore-fetch.cs```

NOTE: Ensure that you have csc.exe in your path.

And then:

```gitignore-fetch```

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
