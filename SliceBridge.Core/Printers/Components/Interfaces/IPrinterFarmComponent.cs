using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SliceBridge.Core.Printers.Models;

namespace SliceBridge.Core.Printers.Components.Interfaces;

public interface IPrinterFarmComponent
{
    public Task<List<PrinterStatus>> ReadAllPrinterStatusAsync();
    public Task SendSTlToAnyAvailablePrinterAsync(Guid stlDocumentId);
}