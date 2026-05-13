using System.Threading.Tasks;

namespace SliceBridge.Core.Application.Printers.Services.Interfaces;

public interface IPrinterManagementService
{
    public Task CreatePrinterFarm();
    public Task CreatePrinter();
    public Task UpdatePrinter();
    public Task DeletePrinter();
    public Task GetPrinterStatus();
    public Task GetPrinterConfiguration();
    public Task GetAllPrinters();
}