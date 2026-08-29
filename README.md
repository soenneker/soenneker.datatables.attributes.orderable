[![](https://img.shields.io/nuget/v/soenneker.datatables.attributes.orderable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.orderable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.orderable/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.orderable/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.attributes.orderable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.orderable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.orderable/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.orderable/actions/workflows/codeql.yml)

# Soenneker.DataTables.Attributes.Orderable

Indicates that a property should be used for search operations in DataTables.

## Install

```bash
dotnet add package Soenneker.DataTables.Attributes.Orderable
```

## Quick start

```csharp
using Soenneker.DataTables.Attributes.Orderable;

public sealed class Request
{
    [DataTableOrderable]
    public string? Value { get; init; }
}
```

Indicates that a property should be used for search operations in DataTables.

## What you get

- `DataTableOrderableAttribute` — Indicates that a property should be used for search operations in DataTables.
