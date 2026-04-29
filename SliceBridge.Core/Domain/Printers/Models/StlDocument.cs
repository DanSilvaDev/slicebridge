using System;
using System.Collections.Generic;
using SliceBridge.Core.Domain.Printers.Models.Enums;

namespace SliceBridge.Core.Domain.Printers.Models;

public sealed class StlDocument
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required List<string> FilePaths { get; set; }
    public bool HasMultipleFiles => FilePaths.Count > 1;
    public QueueBehaviorEnum QueueBehavior { get; set; } = QueueBehaviorEnum.OnlyOnePrinter;
    public FilamentTypeEnum? FilamentType { get; set; }
    public ColorTypeEnum ColorType { get; set; }
    public string? ColorPreferences { get; set; }
    public string? FilamentPreferences { get; set; }
    public decimal? AverageFilamentConsumptionGrams { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdatedAt { get; set; }
}