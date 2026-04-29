using System.Threading.Tasks;

namespace SliceBridge.Core.Domain.Marketplaces.Components.Interfaces;

public interface IMarketplaceComponent
{
    public Task HandleOrderCreatedAsync();
}