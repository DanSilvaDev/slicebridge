using System.Threading.Tasks;
using SliceBridge.Core.Domain.Marketplaces.Components.Interfaces;

namespace SliceBridge.Core.Domain.Marketplaces.Components;

internal class MarketplaceComponent : IMarketplaceComponent
{
    public Task HandleOrderCreatedAsync()
    {
        throw new System.NotImplementedException();
    }
}