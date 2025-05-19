# DiamondKata test assignment

This repo contains the solution for the DiamondKata test assignment. The goal of this assignment is to implement a method that generates a diamond shape based on a given character.

Original task: https://github.com/NewDayTechnology/RecruitmentTests/tree/main/DiamondKata

## Application bootstrap

```bash
# Create solution and projects
mkdir DiamondKata && cd DiamondKata
dotnet new sln
dotnet new console -n DiamondKata
dotnet new xunit -n DiamondKata.Tests

# Link projects
dotnet sln add DiamondKata/DiamondKata.csproj
dotnet sln add DiamondKata.Tests/DiamondKata.Tests.csproj
dotnet add DiamondKata.Tests/DiamondKata.Tests.csproj reference DiamondKata/DiamondKata.csproj
```
