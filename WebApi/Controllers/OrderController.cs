using System.Security.Principal;
using Domain.Dtos;
using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("[controller]")]
public class OrderController
{
    private readonly IWebHostEnvironment _environment;
    private readonly OrderService _orderservice;

    public OrderController(OrderService todoService, IWebHostEnvironment environment)
    {
        _orderservice = todoService;
        _environment = environment;
    }
    [HttpPost]
    public async Task<Response<double>> Order([FromBody] OrderDto order)
    {
        return await _orderservice.Order(order);
    }
    [HttpGet("GetOrders")]
    public async Task<Response<List<OrderDto>>> GetOrders()
    {
        return await _orderservice.GetOrder();
    }


}