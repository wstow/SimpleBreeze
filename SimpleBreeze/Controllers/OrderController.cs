using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breeze.AspNetCore;
using Microsoft.AspNetCore.Http; 
using Microsoft.AspNetCore.Mvc;
using SimpleBreeze.Data;
using SimpleBreeze.Managers;

namespace SimpleBreeze.Controllers
{
    [Route("api/[controller]/[action]")]
    [BreezeQueryFilter]
    public class OrderController : Controller
    {
        private OrderContext _context;

        private OrderManager PersistenceManager;

        public OrderController(OrderContext context)
        {
            this._context = context;
            PersistenceManager = new OrderManager(context);

            if (_context.ReqStatus.Count() == 0) {
                _context.ReqStatus.Add(new ReqStatus {Status = "It's not working!"});
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IActionResult Metadata()
        {
            return Ok(PersistenceManager.Metadata());
        }

        [HttpGet]
        public IQueryable<ReqStatus> Status()
        {
            return PersistenceManager.Context.ReqStatus;
        }

    }
}