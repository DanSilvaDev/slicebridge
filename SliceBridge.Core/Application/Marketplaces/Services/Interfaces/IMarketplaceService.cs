using System.Threading.Tasks;
using SliceBridge.Core.Application.Marketplaces.Dtos.Requests;

namespace SliceBridge.Core.Application.Marketplaces.Services.Interfaces;

public interface IMarketplaceService
{
    Task HandleOrderCreatedAsync(OrderRequest request);
}