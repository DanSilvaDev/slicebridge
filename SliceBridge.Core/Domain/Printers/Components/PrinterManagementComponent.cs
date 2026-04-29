using System;
using System.Threading.Tasks;
using SliceBridge.Core.Domain.Marketplaces.Models;
using SliceBridge.Core.Domain.Printers.Components.Interfaces;
using SliceBridge.Core.Domain.Printers.Models;
using SliceBridge.Core.Domain.Printers.Models.Enums;
using SliceBridge.Core.Domain.Printers.Repositories.Interfaces;

namespace SliceBridge.Core.Domain.Printers.Components;

internal class PrinterManagementComponent : IPrinterManagementComponent
{
    private readonly IPrinterRepository _printerRepository;
    
    public PrinterManagementComponent(IPrinterRepository printerRepository)
    {
        _printerRepository = printerRepository;
    }
    
    public async Task<PrintOrder> SendOrdersToPrinters(Order order)
    {
        if(order.Products == null || order.Products.Count == 0)
            throw new ArgumentException("Order must have at least one product");
            
        var printOrder = new PrintOrder()
        {
            Id = Guid.NewGuid(),
            OrderId = order.Id,
            CreatedAt = DateTime.UtcNow,
            Status = PrintOrderStatusEnum.NotStarted
        };
        
        // Build print order logic
        foreach (var orderProduct in order.Products)
        {
            for (int i = 0; i < orderProduct.Quantity; i++)
            {
                printOrder.ProductQueueId.Add(orderProduct.ProductId);
            }
        }
        printOrder = await _printerRepository.AddPrintOrderAsync(printOrder);
        
        // once stored, send to printers
        await QueuePrintOrderToPrinters(printOrder);
        
        return printOrder;
    }

    public Task QueuePrintOrderToPrinters(PrintOrder printOrder)
    {
        throw new System.NotImplementedException();
    }
}