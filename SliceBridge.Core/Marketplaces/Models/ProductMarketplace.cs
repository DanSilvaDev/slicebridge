using System;

namespace SliceBridge.Core.Marketplaces.Models;

public class ProductMarketplace
{
    public required string MarketplaceId { get; set; }
    public required Guid ProductId { get; set; }
    public string? MarketplaceName { get; set; }
}