using System;

namespace SliceBridge.Core.Domain.Marketplaces.Models;

public class ProductMarketplace
{
    public required string MarketplaceId { get; set; }
    public required Guid ProductId { get; set; }
    public string? MarketplaceName { get; set; }
}