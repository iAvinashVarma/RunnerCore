# RunnerCore

RunnerCore is .NET Core Console / Web / WebAPI project with various real time scenarios and useful process.

![apm](https://img.shields.io/apm/l/vim-mode.svg)
[![Twitter URL](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/iAvinashVarma) [![Twitter Follow](https://img.shields.io/twitter/follow/iAvinashVarma.svg?style=social&label=Follow)](https://twitter.com/iAvinashVarma)
![GitHub followers](https://img.shields.io/github/followers/iAvinashVarma.svg?style=flat-square&label=Follow)
[![Build status](https://avvarma.visualstudio.com/ProgLan/_apis/build/status/RunnerCore?branchName=master)](https://avvarma.visualstudio.com/ProgLan/_build/latest?definitionId=6)
[![Feature Requests](https://img.shields.io/github/issues/iAvinashVarma/RunnerCore/feature-request.svg)](https://github.com/iAvinashVarma/RunnerCore/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bugs](https://img.shields.io/github/issues/iAvinashVarma/RunnerCore/bug.svg)](https://github.com/iAvinashVarma/RunnerCore/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)


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