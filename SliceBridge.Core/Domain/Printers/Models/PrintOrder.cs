using System;
using System.Collections.Generic;
using SliceBridge.Core.Domain.Marketplaces.Models;
using SliceBridge.Core.Domain.Printers.Models.Enums;

namespace SliceBridge.Core.Domain.Printers.Models;

public class PrintOrder
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public List<Guid> ProductQueueId { get; set; } = new List<Guid>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? FinishedAt { get; set; }
    public List<string> Message { get; set; } = new List<string>();
    public PrintOrderStatusEnum Status { get; set; } = PrintOrderStatusEnum.NotStarted;
    public List<PrintedProduct> PrintedProducts { get; set; } = new List<PrintedProduct>();
}