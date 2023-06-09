﻿using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.Concrete;
using BoschBootcamp.BusinessLayer.Response;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetOrders() {

            var orders = orderService.GetOrders();
            if (orders.Count() == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(orders);
            }
        }

        [HttpGet("newOrderId")]
        public IActionResult NewId()
        {
            int count = orderService.GetOrders().Count + 1;
            return Ok(count);
        }

        [HttpPost("newOrder")]
        public IActionResult CreateOrder(int newId)
        {
            BusinessResponse status = orderService.AddOrder(new Order{ OrderID = newId, OrderDate = DateTime.Now});

            return status.Success ? Ok(status) : BadRequest(status);
        }
    }
}
