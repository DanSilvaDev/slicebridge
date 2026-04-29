using System;
using System.Threading.Tasks;
using SliceBridge.Core.Domain.Printers.Models;

namespace SliceBridge.Core.Domain.Printers.Components.Interfaces;

public interface IPrinterManagementComponent
{
    public Task AddPrinterFarmAsync(PrinterFarm printerFarm);
    public Task RemovePrinterFarmAsync(PrinterFarm printerFarm);
    public Task AddPrinterAsync(Printer printer, Guid printerFarmId);
    public Task RemovePrinterAsync(Printer printer, Guid printerFarmId);
}