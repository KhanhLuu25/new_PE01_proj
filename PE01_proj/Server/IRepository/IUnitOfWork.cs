using PE01_proj.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Syncfusion.Blazor.Gantt.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE01_proj.Server.IRepository;

namespace PE01_proj.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Customer> Customers{ get; }
        IGenericRepository<Device> Devices { get; }
        IGenericRepository<OrderItem> OrderItems { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Trade> Trades { get; }
        IGenericRepository<TradeDev> TradeDevs { get; }
    }
}