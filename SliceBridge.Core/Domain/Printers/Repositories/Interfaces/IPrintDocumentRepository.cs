using System;
using System.IO;
using System.Threading.Tasks;
using SliceBridge.Core.Domain.Printers.Models;

namespace SliceBridge.Core.Domain.Printers.Repositories.Interfaces;

public interface IPrintDocumentRepository
{
    public Task<PrintDocument> GetDocumentAsync(Guid documentId);
    public Task<Stream> GetDocumentContentAsync(Guid documentId);
    public Task<Stream> GetDocumentContentAsync(string documentPath);
    public Task<Guid> UploadDocumentAsync(Stream document);
    public Task DeleteDocumentAsync(Guid documentId);
}