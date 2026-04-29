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
    //Todo: considering the creation of an object called PrintOrder
    // so it can make the relationship between order and all products printed
    public Guid? OrderId { get; set; }
}

public enum PrintedProductStatusEnum
{
    Waiting,
    Accepted,
    Rejected,
    AcceptedWithErrors,
}