using System;
using System.IO;
using System.Threading.Tasks;
using SliceBridge.Core.Printers.Models;

namespace SliceBridge.Core.Printers.Repositories.Interfaces;

public interface IStlRepository
{
    public Task<StlDocument> GetStlDocumentAsync(Guid stlDocumentId);
    public Task<Stream> GetStlFileContentAsync(Guid stlDocumentId);
    public Task<Stream> GetStlFileContentAsync(string stlFilePath);
    public Task<Guid> UploadStlFileAsync(Stream stlFile);
    public Task DeleteStlFileAsync(Guid stlDocumentId);
}