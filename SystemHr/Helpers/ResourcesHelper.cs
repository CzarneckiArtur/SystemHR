using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHr.UserInterface.Helpers
{
    public static class ResourcesHelper
    {
        public static string CloseButtonName = "5657.close.png";
         public static string ResourcesFilePath = Path.Combine(System.IO.Path.GetFullPath( @"..\..\"), "Resources");
    }
}
