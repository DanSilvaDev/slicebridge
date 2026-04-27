using System.Threading.Tasks;

namespace SliceBridge.Core.Marketplaces.Components.Interfaces;

public interface IMarketplaceComponent
{
    public Task HandleOrderCreatedAsync();
}