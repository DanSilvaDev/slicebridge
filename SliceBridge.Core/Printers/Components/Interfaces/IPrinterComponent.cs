using System;
using System.Threading.Tasks;
using SliceBridge.Core.Printers.Models;

namespace SliceBridge.Core.Printers.Components.Interfaces;

public interface IPrinterComponent
{
    public Task UploadSTlToPrinterAsync(Guid printerId, Guid stlDocumentId);
    public Task SendToPrintQueueAsync(Guid printerId, Guid stlDocumentId);
    public Task<PrinterStatus> ReadPrinterStatusAsync(Guid printerId);
}