using System;
using System.Collections.Generic;

namespace SliceBridge.Core.Domain.Marketplaces.Models;

public class Order
{
    public Guid Id { get; set; }
    public required string MarketPlaceOrderId { get; set; }
    public required string MarketplaceName { get; set; }
    public List<ProductOrder>? Products { get; set; }
    public DateTime? ToBeDeliveredAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}

public class ProductOrder
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}