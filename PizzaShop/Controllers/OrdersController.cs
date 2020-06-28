using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzeriaApp1.Services.Repositories;
using PizzeriaApp1.DomainClass;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using PizzaShop.Models.ViewModels;

namespace PizzaShop.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private IOrderRepository _orderRepository;
        private IOrderDetailRepository _orderDetailRepository;
        private IPizzaRepository _pizzaRepository; 
       
        public OrdersController(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository, IPizzaRepository pizzaRepository)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _pizzaRepository = pizzaRepository;
        }
        public IActionResult ShowCart()
        {
            List<ShowCartViewModel> list = new List<ShowCartViewModel>();
            if (User.Identity.IsAuthenticated)
            {
                string uId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                Order o = _orderRepository.OrderExists(uId);
                if (o != null)
                {
                    var details = _orderDetailRepository.FindOrder(o.OrderId);
                    foreach (var item in details)
                    {
                        var p = _pizzaRepository.GetPizzaById(item.PizzaId);
                        list.Add(new ShowCartViewModel()
                        {
                            OrderDetailId = item.OrderDetailID,
                            Count = item.Count,
                            Title = p.Name,
                            ImageName = p.ImageUrl
                        });

                    }
                }
            }

            return View(list);
        }
        
        public IActionResult ShowBill()
        {


            string uId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Order o = _orderRepository.OrderExists(uId);

            List<ShowOrderViewModel> _list = new List<ShowOrderViewModel>();
            if (o != null)
            {
                var details = _orderDetailRepository.FindOrder(o.OrderId);
                foreach (var item in details)
                {
                    var p = _pizzaRepository.GetPizzaById(item.PizzaId);

                    _list.Add(new ShowOrderViewModel()
                    {
                        OrderId = item.OrderId,
                        Count = item.Count,
                        title = p.Name,
                        OrderDetailId = item.OrderDetailID,
                        PriceInEuro = item.PriceInEuro,
                        SumEuro = item.Count * item.PriceInEuro,
                        PriceInDollar = item.PriceInDollar,
                        SumDollar = item.Count * item.PriceInDollar,

                    });

                }

            }
            return View(_list);
        }

      //  [Route("Orders/delete/{id:int}")]
        public IActionResult Delete(int id)
        {
           _orderDetailRepository.DeleteOrderDetail(id);
            _orderDetailRepository.Save();
           
            return RedirectToAction("ShowCart");
        }
        public IActionResult AddToCart(int id)
        {
            string CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Order order = _orderRepository.OrderExists(CurrentUserId);
            if (order == null)
            {
                order = new Order()
                {
                    UserId = CurrentUserId,
                    CreateDate = DateTime.Now,
                    IsFinaly = false,
                    SumDollar = 0,
                    SumEuro = 0
                };
            _orderRepository.InsertOrder(order);
                _orderRepository.Save();
                _orderDetailRepository.InsertOrderDetail(new OrderDetail()
                {
                    OrderId = order.OrderId,
                    Count = 1,
                    PriceInDollar = _pizzaRepository.GetPizzaById(id).PriceInDollar,
                    PriceInEuro = _pizzaRepository.GetPizzaById(id).PriceInEuro,
                    PizzaId = id,
                }
                    );
            _orderRepository.Save();
             _orderDetailRepository.Save();
            }
            else
            {

                var details = _orderDetailRepository.OrderDetailExists(order.OrderId,id);
                if (details == null)
                {
                    _orderDetailRepository.InsertOrderDetail(new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        PizzaId = id,
                        Count = 1,
                        PriceInDollar = _pizzaRepository.GetPizzaById(id).PriceInDollar,
                        PriceInEuro = _pizzaRepository.GetPizzaById(id).PriceInEuro,
                        
                    });
                }
                else
                {
                    details.Count += 1;
                    _orderDetailRepository.UpdateOrderDetail(details);
                }

                _orderDetailRepository.Save();
            }
            _orderDetailRepository.UpdateSum(order.OrderId);
            return Redirect("~/Home/Menu");
        }


        public IActionResult Command(int id, string command)
        {
            var orderDetail = _orderDetailRepository.GetOrderDetailById(id);

            switch (command)
            {
                case "up":
                    {
                        orderDetail.Count += 1;
                       _orderDetailRepository.UpdateOrderDetail(orderDetail);
                        break;
                    }
                case "down":
                    {
                        orderDetail.Count -= 1;
                        if (orderDetail.Count == 0)
                        {
                            _orderDetailRepository.DeleteOrderDetail(orderDetail);
                        }
                        else
                        {
                            _orderDetailRepository.UpdateOrderDetail(orderDetail);
                        }

                        break;
                    }
            }


            _orderDetailRepository.Save();
            return RedirectToAction("ShowCart");
        }

        public IActionResult CheckOut()
        {
            string CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Order order = _orderRepository.OrderExists(CurrentUserId);
            SetFinal(order.OrderId);
            return View();
        }

        public void SetFinal(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            order.IsFinaly = true;
            _orderRepository.UpdateOrder(order);
            _orderRepository.Save();
        }
        public void UpdateSumOrder(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            order.SumDollar = _orderDetailRepository.GetAllOrderDetails().Where(o => o.OrderId == order.OrderId).Select(d => d.Count * d.PriceInDollar).Sum();
            order.SumEuro = _orderDetailRepository.GetAllOrderDetails().Where(o => o.OrderId == order.OrderId).Select(d => d.Count * d.PriceInEuro).Sum();
           _orderRepository.UpdateOrder(order);
            _orderRepository.Save();
        }
    }
}