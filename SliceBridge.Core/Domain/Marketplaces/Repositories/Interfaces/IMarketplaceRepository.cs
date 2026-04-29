using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SliceBridge.Core.Domain.Marketplaces.Models;

namespace SliceBridge.Core.Domain.Marketplaces.Repositories.Interfaces;

public interface IMarketplaceRepository
{
    Task<Product> GetRelatedProductAsync(string marketPlaceProductId, string marketPlaceName);
    Task<List<Product>> GetRelatedProductAsync(List<string> marketPlaceProductIds, string marketPlaceName);
    Task<List<ProductMarketplace> > GetRelatedProductMarketplacesAsync(List<string> marketPlaceProductIds, string marketPlaceName);
    Task<Product> AddProductAsync(Product product);
    Task<Product> UpdateProductAsync(Product product);
    Task<Product> RemoveProductAsync(Guid id);
    Task<List<Product>> GetAllProductsAsync();
    Task<List<Product>> GetProductsAsync(List<Guid> productIds);
    Task<List<Product>> GetOnlyActiveProductsAsync(List<Guid> productIds);
    Task<Order> GetOrderAsync(Guid orderId);
    Task<List<Order>> GetOrdersAsync(List<Guid> orderIds);
    Task<Order> AddOrderAsync(Order order);
}