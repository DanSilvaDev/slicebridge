using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SliceBridge.Core.Application.Marketplaces.Dtos.Requests;
using SliceBridge.Core.Domain.Marketplaces.Components.Interfaces;
using SliceBridge.Core.Domain.Marketplaces.Models;
using SliceBridge.Core.Domain.Marketplaces.Repositories.Interfaces;

namespace SliceBridge.Core.Domain.Marketplaces.Components;

internal class MarketplaceComponent : IMarketplaceComponent
{
    private readonly IMarketplaceRepository _marketplaceRepository;

    public MarketplaceComponent(IMarketplaceRepository marketplaceRepository)
    {
        _marketplaceRepository = marketplaceRepository;
    }

    public async Task<Order> CreateOrderAsync(List<ProductOrder> products, string marketPlaceOrderId,
        string marketPlaceName,
        DateTime? toBeDeliveredAt = null)
    {
        if (products == null || products.Count == 0)
            throw new ArgumentException("Products cannot be null or empty", nameof(products));

        var validProducts =
            await _marketplaceRepository.GetOnlyActiveProductsAsync(products.ConvertAll(x => x.ProductId));

        if (validProducts.Count != products.Count)
        {
            throw new ArgumentException("There are Invalid products in the list", nameof(products));
        }

        var order = new Order
        {
            Id = Guid.NewGuid(),
            MarketPlaceOrderId = marketPlaceOrderId,
            MarketplaceName = marketPlaceName,
            Products = products,
            CreatedAt = DateTime.UtcNow,
            ToBeDeliveredAt = toBeDeliveredAt,
            UpdatedAt = DateTime.UtcNow
        };

        order = await _marketplaceRepository.AddOrderAsync(order);

        return order;
    }

    public async Task<List<ProductOrder>> GetRelatedProductsAsync(List<ProductIdQuantity> marketPlaceProductIds,
        string marketPlaceName)
    {
        if (marketPlaceProductIds.Count < 1)
            throw new ArgumentException("Marketplace product ids cannot be null or empty",
                nameof(marketPlaceProductIds));

        if (string.IsNullOrWhiteSpace(marketPlaceName))
            throw new ArgumentException("Marketplace name cannot be null or empty", nameof(marketPlaceName));


        var result = new List<ProductOrder>();

        var productList =
            await _marketplaceRepository.GetRelatedProductMarketplacesAsync(
                marketPlaceProductIds.ConvertAll(x => x.ProductId), marketPlaceName);


        foreach (var mktProduct in marketPlaceProductIds)
        {
            var product = productList.FirstOrDefault(x => x.MarketplaceId == mktProduct.ProductId);

            if (product == null)
                continue;

            result.Add(new ProductOrder()
            {
                ProductId = product.ProductId,
                Quantity = mktProduct.Quantity
            });
        }

        return result;
    }
}