using System;
using System.Threading.Tasks;
using SliceBridge.Core.Domain.Printers.Models;

namespace SliceBridge.Core.Domain.Printers.Components.Interfaces;

public interface IPrinterComponent
{
    public Task UploadDocumentToPrinterAsync(Guid printerId, Guid documentId);
    public Task SendToPrintQueueAsync(Guid printerId, Guid documentId);
    public Task<PrinterStatus> ReadPrinterStatusAsync(Guid printerId);
    public Task AddPrinterAsync(Printer printer, Guid printerFarmId);
    public Task RemovePrinterAsync(Printer printer, Guid printerFarmId);
}