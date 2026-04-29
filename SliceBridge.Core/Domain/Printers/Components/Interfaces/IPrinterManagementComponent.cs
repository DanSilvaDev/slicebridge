using System.Threading.Tasks;
using SliceBridge.Core.Domain.Marketplaces.Models;
using SliceBridge.Core.Domain.Printers.Models;

namespace SliceBridge.Core.Domain.Printers.Components.Interfaces;

public interface IPrinterManagementComponent
{
    public Task<PrintOrder> SendOrdersToPrinters(Order order);
    
    public Task QueuePrintOrderToPrinters(PrintOrder printOrder);
}