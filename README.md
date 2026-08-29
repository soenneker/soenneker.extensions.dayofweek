[![](https://img.shields.io/nuget/v/soenneker.extensions.dayofweek.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.dayofweek/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.dayofweek/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.dayofweek/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.dayofweek.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.dayofweek/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.dayofweek/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.dayofweek/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.DayOfWeek
A collection of helpful DayOfWeek enum extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.DayOfWeek
```

## Quick start

```csharp
using Soenneker.Extensions.DayOfWeek;

// Given an existing DayOfWeekType? named day:
var result = day.ToChar();
```

## Common operations

- `ToChar()` - Converts the specified nullable day of week value to its corresponding single-character representation. If the provided value does not correspond to a recognized day of the week, the method returns the null character ('\0').
- `ToLetter()` - Returns the single-letter abbreviation corresponding to the specified day of the week.
