using LearnWebApiAuth.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearnWebApiAuth.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            List<Order> OrderList = new List<Order>
            {
                new Order {OrderID = 10248, CustomerName = "Rami Vemula", ShipperCity = "Hyderabad", IsShipped = true },
                new Order {OrderID = 10249, CustomerName = "Ramilu", ShipperCity = "Visakhapatnam", IsShipped = false}
            };
            return Ok(OrderList);
        }

    }
}
