using System;
using SliceBridge.Core.Printers.Models.Enums;

namespace SliceBridge.Core.Printers.Models;

public class PrinterStatus
{
    public Guid PrinterId { get; set; }
    public PrinterStateEnum State { get; set; }
    public DateTime LastUpdate { get; set; }
    public PrinterQueueStatus? QueueStatus { get; set; }
}