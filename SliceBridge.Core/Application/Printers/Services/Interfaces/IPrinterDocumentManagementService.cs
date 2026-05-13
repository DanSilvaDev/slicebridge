using System.Threading.Tasks;

namespace SliceBridge.Core.Application.Printers.Services.Interfaces;

public interface IPrinterDocumentManagementService
{
    public Task SendDocumentToPrinter();
    public Task UploadDocumentToPrinter();
}