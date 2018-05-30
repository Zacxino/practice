using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Other.Data;

namespace Unity
{
    public static class DataExtension
    {
        public static IUnityContainer AddFCMSData(this IUnityContainer container)
        {
            container.RegisterType<OtherDbContext, OtherDbContext>();
            return container;
        }
    }
}
