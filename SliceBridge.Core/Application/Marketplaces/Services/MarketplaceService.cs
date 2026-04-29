using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SliceBridge.Core.Application.Marketplaces.Dtos.Requests;
using SliceBridge.Core.Application.Marketplaces.Services.Interfaces;
using SliceBridge.Core.Domain.Marketplaces.Components.Interfaces;
using SliceBridge.Core.Domain.Printers.Components.Interfaces;

namespace SliceBridge.Core.Application.Marketplaces.Services;

public class MarketplaceService : IMarketplaceService
{
    private readonly ILogger<MarketplaceService> _logger;
    private readonly IPrinterComponent _printerComponent;
    private readonly IMarketplaceComponent _marketplaceComponent;
    private readonly IPrinterManagementComponent _printerManagementComponent;
    
    public MarketplaceService()
    {
        
    }
    
    public async Task HandleOrderCreatedAsync(OrderRequest request)
    {
        // identify products and quantities
        var products = await _marketplaceComponent.GetRelatedProductsAsync(
            request.Products,
            request.MarketPlaceName);
        
        // create order
        var order = await _marketplaceComponent.CreateOrderAsync(products, request.OrderId, request.MarketPlaceName);
        // create print orders and send print orders to printer
        var printOrder = await _printerManagementComponent.SendOrdersToPrinters(order);
    }
}