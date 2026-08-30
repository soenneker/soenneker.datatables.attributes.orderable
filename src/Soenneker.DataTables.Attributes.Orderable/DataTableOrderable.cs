using System;

namespace Soenneker.DataTables.Attributes.Orderable;

/// <summary>
/// Indicates that a property may be used for ordering in DataTables server-side requests.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class DataTableOrderableAttribute : Attribute;
