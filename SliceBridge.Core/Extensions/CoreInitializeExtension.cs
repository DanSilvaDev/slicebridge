using Microsoft.Extensions.DependencyInjection;
using SliceBridge.Core.Domain.Marketplaces.Components;
using SliceBridge.Core.Domain.Marketplaces.Components.Interfaces;

namespace SliceBridge.Core.Extensions;

public static class CoreInitializeExtension
{
    public static void InitializeCoreServices(this IServiceCollection services)
    {
        services.AddScoped<IMarketplaceComponent, MarketplaceComponent>();
    }
}