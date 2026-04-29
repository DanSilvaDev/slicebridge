using System;
using System.Collections.Generic;

namespace SliceBridge.Core.Domain.Printers.Models;

public class PrinterFarm
{
    public Guid Id { get; set; }
    public List<Printer> PrintersList { get; set; }
}