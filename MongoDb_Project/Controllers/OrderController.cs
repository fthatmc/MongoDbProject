﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDb_Project.Dtos.OrderDtos;
using MongoDb_Project.Services.CustomerServices;
using MongoDb_Project.Services.OrderServices;
using MongoDb_Project.Services.ProductServices;

namespace MongoDb_Project.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public OrderController(IOrderService orderService, ICustomerService customerService, IProductService productService)
        {
            _orderService = orderService;
            _customerService = customerService;
            _productService = productService;
        }

        public async Task<IActionResult> OrderList()
        {
            var values = await _orderService.GetOrderWithCustomerAndProductAsync();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> CreateOrder()
        {
            List<SelectListItem> values = (from x in await _customerService.GetAllCustomerAsync()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CustomerId.ToString()
                                           }).ToList();
            ViewBag.CustomerList = values;

            List<SelectListItem> values1 = (from x in await _productService.GetAllProductAsync()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.ProductId.ToString()
                                            }).ToList();
            ViewBag.ProductList = values1;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderDto createOrderDto)
        {
            await _orderService.CreateOrderAsync(createOrderDto);
            return RedirectToAction("OrderList");
        }
        public async Task<IActionResult> RemoveOrder(string id)
        {
            await _orderService.DeleteOrderAsync(id);
            return RedirectToAction("OrderList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateOrder(string id)
        {
            var values = await _orderService.GetByIdOrderAsync(id);

            List<SelectListItem> values1 = (from x in await _customerService.GetAllCustomerAsync()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.CustomerId.ToString()
                                            }).ToList();
            ViewBag.CustomerList = values1;

            List<SelectListItem> values2 = (from x in await _productService.GetAllProductAsync()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.ProductId.ToString()
                                            }).ToList();
            ViewBag.ProductList = values2;

            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateOrder(UpdateOrderDto updateOrderDto)
        {
            await _orderService.UpdateOrderAsync(updateOrderDto);
            return RedirectToAction("OrderList");
        }
    }
}
