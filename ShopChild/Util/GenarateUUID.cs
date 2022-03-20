using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopChild.Util
{
    public class GenarateUUID
    {
        public static string Create()
        {
            return Guid.NewGuid().ToString();
        }
    }
}