[![](https://img.shields.io/nuget/v/soenneker.extensions.dayofweek.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.dayofweek/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.dayofweek/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.dayofweek/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.dayofweek.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.dayofweek/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.dayofweek/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.dayofweek/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.DayOfWeek

Compact one-character representations for `DayOfWeekType` values.

## Installation

```bash
dotnet add package Soenneker.Extensions.DayOfWeek
```

## Usage

```csharp
using Soenneker.Enums.DayOfWeek;
using Soenneker.Extensions.DayOfWeek;

char monday = DayOfWeekType.Monday.ToChar();    // 'M'
string friday = DayOfWeekType.Friday.ToLetter(); // "F"

DayOfWeekType? missing = null;
char missingChar = missing.ToChar();       // '\0'
string missingLetter = missing.ToLetter(); // ""
```

The mapping is:

| Day | Result |
| --- | --- |
| Monday | `M` |
| Tuesday | `T` |
| Wednesday | `W` |
| Thursday | `T` |
| Friday | `F` |
| Saturday | `S` |
| Sunday | `S` |

`ToChar()` returns the null character for a null or unrecognized value. `ToLetter()` returns an empty string. The abbreviations are intentionally compact rather than unique: Tuesday and Thursday collide, as do Saturday and Sunday, so they should not be used as identifiers or for round-trip parsing.
