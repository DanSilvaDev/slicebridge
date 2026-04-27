using System;
using System.Collections.Generic;
using SliceBridge.Core.Printers.Models.Enums;

namespace SliceBridge.Core.Printers.Models;

public class Printer
{
    public Guid Id { get; set; }
    public Guid FarmId { get; set; }
    public string Name { get; set; }
    public string Factory { get; set; }
    public string Model { get; set; }
    public string? SerialNumber { get; set; }
    public string? IpAddress { get; set; }
    public string? Port { get; set; }
    public string? User { get; set; }
    public string? Password { get; set; }
    public List<FilamentTypeEnum>? SupportedFilamentTypes { get; set; }
    public List<ColorTypeEnum>? SupportedColorTypes { get; set; }
    public PrinterStatus? Status { get; set; }
    public bool Enabled { get; set; }
    public DateTime? LastUpdatedAt { get; set; }
}