using System;
using System.Collections.Generic;

namespace SliceBridge.Core.Marketplaces.Models;

public class Product
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public Guid? StlDocumentId { get; set; }
    public List<ProductMarketplace>? MarketplaceIds { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastUpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}