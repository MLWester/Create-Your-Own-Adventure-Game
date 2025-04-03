# Naboo's Choose Your Own Adventure (CYOA) Game

## Setup: 
Only one person needs to run the following command to setup the Dotnet console app, which sets up a Program.cs file, .sln Solutions file, and .csproj Project file. Ask AI what those files do to learn more. 
```
dotnet new console
```

## Run the App: 
To run the application, run the following, which runs Program.cs. If needed this command first builds and compiles the program before running it. 
```
dotnet run
```

## Build the App: 
This command is optional becuase dotnet run will also build the app prior to running the app. But to build the application without running the application, type this command in the terminal. Building the app let's the compiler compile and find any bugs or problems.
```
dotnet build
```

Some developers like to run these two commands together. 
```
dotnet build
dotnet run
```

## Where to put your .cs files? 
Put your .cs files in the root folder, which is the same folder as Program.cs. This is a simple program with only a few .cs file so we do not need complex folder organizations. 


## Useful Git Commands
```
git add -A  
git commit -m "explanation of your changes" 
git push
git status   
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
Warning: This operation is destructive and cannot be undone. Make sure you are okay with losing any uncommitted changes before running it. 

If you already pushed your changes to GitHub, then you need  different way to revert the committed changes. 


## What are the /bin/ and /obj/ folders? Can I delete the /bin/ and /obj/ folders? What is a .gitignore file? 
Great questions. Ask AI those questions and learn. 