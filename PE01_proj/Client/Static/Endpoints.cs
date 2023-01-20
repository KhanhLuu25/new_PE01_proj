using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE01_proj.Client.Static
{
    public static class Endpoints

    {
        private static readonly string Prefix = "api";
        public static readonly string DevicesEndpoint = $"{Prefix}/devices";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string OrderItemsEndpoint = $"{Prefix}/orderitems";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
        public static readonly string PaynentsEndpoint = $"{Prefix}/payments";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string TradesEndpoint = $"{Prefix}/trades";
        public static readonly string TradeDevsEndpoint = $"{Prefix}/tradeDevs";
    }
}
