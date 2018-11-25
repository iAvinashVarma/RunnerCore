# RunnerCore

RunnerCore is .NET Core Console / Web / WebAPI project with various real time scenarios and useful process.

---

## IDE

Visual Studio Code OR Visual Studio 2017

---

## Instructions to create console, class libraries and adding the references

```cmd
C:\AV.Client.CLI.Runner> dotnet new console
C:\AV.Middle.Common.Comparer> dotnet new classlib
C:\RunnerCore>dotnet add AV.Middle.Common.Model\AV.Middle.Common.Model.csproj reference AV.Middle.Common.Model\AV.Middle.Common.Model.csproj
C:\RunnerCore> dotnet add Client\CLI\AV.Client.CLI.Runner\AV.Client.CLI.Runner.csproj reference Middle\Common\AV.Middle.Common.Configure\AV.Middle.Common.Configure.csproj
C:\RunnerCore> dotnet list reference
```

---

## Instructions to create WebApi, class libraries and adding the references

```cmd
C:\AV.Service.WebAPI.Runner> dotnet new webapi
C:\AV.Service.WebAPI.Runner> dotnet add package Microsoft.EntityFrameworkCore
```

---

## Instructions to install a Nuget Package in a project

```cmd
C:\RunnerCore\Middle\Common\AV.Middle.Common.DAL> dotnet add package System.Data.Common
C:\AV.Middle.Common.Configure> dotnet add package log4net
```

---

## Extensions

```cmd
C:\RunnerCore> code --install-extensions
C:\RunnerCore> code --install-extensions jmrog.vscode-nuget-package-manager
```

---

## Run WebAPI and WebApp

```cmd
C:\AV.Service.WebAPI.Runner> dotnet run
C:\AV.Client.Web.Runner> dotnet run
```

---

## Run entire project

```cmd
C:\RunnerCore> dotnet run
```

---