using System;

namespace SliceBridge.Core.Domain.Printers.Models;

public record PrintedProduct
{
    public Guid ProductId { get; set; }
    public Guid PrinterId { get; set; }
    public Guid StlDocumentId { get; set; }
    public DateTime PrintedAt { get; set; }
    public TimeSpan? ElapsedTime { get; set; }
    public string? PicturePath { get; set; }
    public PrintedProductStatusEnum StatusEnum { get; set; }
    public string? Justification { get; set; }
    public PrintOrder? OrderId { get; set; }
}

public enum PrintedProductStatusEnum
{
    Waiting,
    Accepted,
    Rejected,
    AcceptedWithErrors,
}