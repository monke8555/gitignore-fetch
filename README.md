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

NOTE: You can use .NET Core for Linux like MacOS: https://docs.microsoft.com/en-us/dotnet/core/install/linux?irgwc=1&OCID=AID2000142_aff_7593_1243925&tduid=%28ir__zfolgr2epwkfq3sbkk0sohz3wv2xpzbjtk2vevqc00%29%287593%29%281243925%29%28a1LgFw09t88-jHF9UMXRiQDmpzeU5RUaYg%29%28%29&irclickid=_zfolgr2epwkfq3sbkk0sohz3wv2xpzbjtk2vevqc00#:~:text=Install%20on%20Linux-,.,available%20on%20different%20Linux%20distributions.?ranMID=24542&ranEAID=a1LgFw09t88&ranSiteID=a1LgFw09t88-jHF9UMXRiQDmpzeU5RUaYg&epi=a1LgFw09t88-jHF9UMXRiQDmpzeU5RUaYg

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
