using System.Threading.Tasks;
using SliceBridge.Core.Domain.Printers.Models;

namespace SliceBridge.Core.Domain.Printers.Repositories.Interfaces;

public interface IPrinterRepository
{
    public Task<PrintOrder> AddPrintOrderAsync(PrintOrder printOrder);   
}