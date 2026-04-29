using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SliceBridge.Core.Application.Marketplaces.Dtos.Requests;
using SliceBridge.Core.Domain.Marketplaces.Models;

namespace SliceBridge.Core.Domain.Marketplaces.Components.Interfaces;

public interface IMarketplaceComponent
{
    public Task<Order> CreateOrderAsync(List<ProductOrder> products, string marketPlaceOrderId, string marketPlaceName,
        DateTime? toBeDeliveredAt = null);

    public Task<List<ProductOrder>> GetRelatedProductsAsync(List<ProductIdQuantity> marketPlaceProductIds,
        string marketPlaceName);
}