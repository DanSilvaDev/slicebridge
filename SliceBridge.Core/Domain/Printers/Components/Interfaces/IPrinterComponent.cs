using System;
using System.Threading.Tasks;
using SliceBridge.Core.Domain.Printers.Models;

namespace SliceBridge.Core.Domain.Printers.Components.Interfaces;

public interface IPrinterComponent
{
    public Task UploadSTlToPrinterAsync(Guid printerId, Guid stlDocumentId);
    public Task SendToPrintQueueAsync(Guid printerId, Guid stlDocumentId);
    public Task<PrinterStatus> ReadPrinterStatusAsync(Guid printerId);
    public Task AddPrinterAsync(Printer printer, Guid printerFarmId);
    public Task RemovePrinterAsync(Printer printer, Guid printerFarmId);
}