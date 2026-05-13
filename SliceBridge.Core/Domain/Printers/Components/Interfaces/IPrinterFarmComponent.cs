using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SliceBridge.Core.Domain.Printers.Models;

namespace SliceBridge.Core.Domain.Printers.Components.Interfaces;

public interface IPrinterFarmComponent
{
    public Task<List<PrinterStatus>> ReadAllPrinterStatusAsync();
    public Task SendDocumentToAnyAvailablePrinterAsync(Guid documentId);
    public Task<PrinterFarm> GetPrinterFarmAsync(Guid printerFarmId);
    public Task AddPrinterFarmAsync(PrinterFarm printerFarm);
    public Task RemovePrinterFarmAsync(PrinterFarm printerFarm);
}