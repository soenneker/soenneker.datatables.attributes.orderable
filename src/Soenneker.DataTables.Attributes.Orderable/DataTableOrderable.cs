using System;

namespace Soenneker.DataTables.Attributes.Orderable;

/// <summary>
/// Indicates that a property should be used for search operations in DataTables.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class DataTableOrderableAttribute : Attribute;