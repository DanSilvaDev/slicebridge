using System;
using System.Collections.Generic;

namespace SliceBridge.Core.Domain.Printers.Models;

public class PrinterQueueStatus
{
    public Guid PrinterId { get; set; }
    public List<Guid>? NextDocumentsQueue { get; set; }
    public Guid? CurrentDocumentId { get; set; }
    public int? Progress { get; set; }
}