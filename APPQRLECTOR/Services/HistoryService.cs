using System;
using System.Collections.Generic;
using System.Text;
using APPQRLECTOR.Models;

namespace APPQRLECTOR.Services
{
    internal class HistoryService
    {
        public static List<ScanRecord> Records { get; } = new();
    }
}
