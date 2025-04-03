Press CTRL-Shift-V to preview .MD files. 
# Choose Your Own Adventure (CYOA) Game

## Setup: 
Only one developer needs to run the following command to setup the Dotnet console app and then push to GitHub. This command creates a Program.cs file, .sln Solutions file, and .csproj Project file. Dr. Humpherys did this for you. Ask AI what those files do to learn more. 
```
dotnet new console
```

## Run the App: 
To run the application, type the following into the terminal, which looks for and runs Program.cs. If needed, dotnet run first builds and compiles the program before running it. 
```
dotnet run
```

## Build the App: 
This command is optional becuase dotnet run will also build the app prior to running the app if needed. But to build the application without running the application, type this command in the terminal. Building the app let's the compiler compile and warn you of any compile errors or problems.
```
dotnet build
```

Some developers like to run these two commands together. 
```
dotnet build
dotnet run
```

## Where to put your .cs files? 
Put your .cs files in the root folder, which is the same folder where Program.cs is located. This app is a simple program with only a few .cs file so we do not need complex folder organizations. 

## Use a common namespace in each .cs file
A namespace lets the .cs files find and use eachother's Class methods. Each .cs file should have the following code just after the using directives (e.g., using System;) Ask AI to learn more about namespaces and best practices. 

```
using System;

namespace NabooGame

```
## Useful Git Commands
```
git add -A  
git commit -m "explanation of your changes" 
git push
git status   
```

### Checkout a branch
```
git checkout {branchname}
```

See a list of all branchs. 
```
git pull
git branch -a
```

### Undo uncommitted changes and revert back to main: 
Oh No! I have royally messed up my local branch and want to revert it back to the latest committed state. Use this only if you made a lot of changes (but not yet pushed to GitHub yet), messed up things and want to revert back to the most current files on your remote branch. This command will discard all uncommitted changes in your working directory and staging area.
```
git fetch {branchName}
git reset --hard origin/{branchName}
```
or if you want to revert back to the current files in main: 
```
git fetch origin
git reset --hard origin/main
```
Warning: This operation is destructive and cannot be undone. Make sure you are okay with losing any uncommitted changes before running it. Ask AI if you want to know more. 

If you already pushed your changes to GitHub, then you need  different way to revert the committed changes. 


### What are the /bin/ and /obj/ folders? Can I delete the /bin/ and /obj/ folders? What is a .gitignore file? 
Great questions. Ask AI those questions and learn. 

## Homework Instructions: 
https://docs.google.com/document/d/1f-YFPrVFI4oKv7H9p0zZgL-5OgdwJsOYUYoUnc-r1Y8/edit?tab=t.0#heading=h.4jkzdf4ipmah  

## Reference book by Mr. Kareem Dana from CIDM3312. 
While we are not using Razor pages, Mr. Dana's ebook still has several helpful chapters on dotnet new console, top level statements, classes, lists, GitHub commands and merge conflicts, etc. 
https://danacidm.gitbook.io/cidm-3312  

