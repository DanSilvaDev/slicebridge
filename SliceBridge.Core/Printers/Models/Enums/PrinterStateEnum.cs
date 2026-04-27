namespace SliceBridge.Core.Printers.Models.Enums;

public enum PrinterStateEnum
{
    Idle,
    Printing,
    Paused,
    Stopped,
    Completed,
    Error,
    SelfTesting,
    Offline,
    Unknown
}