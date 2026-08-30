[![](https://img.shields.io/nuget/v/soenneker.datatables.attributes.orderable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.orderable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.orderable/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.orderable/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.attributes.orderable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.orderable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.orderable/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.orderable/actions/workflows/codeql.yml)

# Soenneker.DataTables.Attributes.Orderable

`DataTableOrderableAttribute` marks model properties that a server-side DataTables query layer may use for sorting.

## Installation

```bash
dotnet add package Soenneker.DataTables.Attributes.Orderable
```

## Usage

```csharp
using Soenneker.DataTables.Attributes.Orderable;

public sealed class CustomerRow
{
    [DataTableOrderable]
    public required string Name { get; init; }

    [DataTableOrderable]
    public DateTimeOffset CreatedAt { get; init; }

    public string? InternalNote { get; init; }
}
```

A request-processing layer can inspect the requested column, find its corresponding property, and allow ordering only when that property has `DataTableOrderableAttribute`:

```csharp
using System.Reflection;

PropertyInfo property = typeof(CustomerRow).GetProperty(nameof(CustomerRow.CreatedAt))!;
bool mayOrder = property.IsDefined(typeof(DataTableOrderableAttribute));
```

This package supplies the marker attribute only. It does not parse DataTables requests or apply `OrderBy`. Treat requested column names as untrusted input and map them to known properties instead of inserting them into a query string.
