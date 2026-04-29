using System;
using System.Collections.Generic;

namespace SliceBridge.Core.Application.Marketplaces.Dtos.Requests;

public class OrderRequest
{
    public required string OrderId { get; set; }
    public required string MarketPlaceName { get; set; }
    public required List<ProductIdQuantity> Products { get; set; }
    public DateTime? ToBeDeliveredAt { get; set; }
}

public class ProductIdQuantity
{
    public required string ProductId { get; set; }
    public int Quantity { get; set; }
}