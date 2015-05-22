using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace linqpadvisualizer
{
    static class AppConfig
    {
        public static int MaxDepth
        {
            get
            {
                var maxDepth = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LinqpadVisualizer", "MaxDepth", 5) ?? 5;
                return (int)maxDepth;
            }
            set
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\LinqpadVisualizer", "MaxDepth", value); 
            }
        }
    }
}
