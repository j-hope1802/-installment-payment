using System.Net;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Data;
using Infrastructure.Service;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Service;
public class OrderService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;


    public OrderService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;

    }

    public async Task<Response<double>> Order(OrderDto order)
    {
        try
        {
            var mapped = _mapper.Map<Order>(order);
            await _context.Orders.AddAsync(mapped);
            await _context.SaveChangesAsync();
            double productamount = 0;
            if (order.PhoneNumber == null)
            {

            }
            if (order.Category == Category.Smartphone)
            {
                if ((int)order.Installement == 12)
                {
                    productamount = ((100 + 3) * order.ProductPrice) / 100;
                }
                else if ((int)order.Installement == 18)
                {
                    productamount = ((100 + 6) * order.ProductPrice) / 100;
                }
                else if ((int)order.Installement == 24)
                {
                    productamount = ((100 + 9) * order.ProductPrice) / 100;
                }
                else { productamount = order.ProductPrice; }
            }
            else if (order.Category == Category.Computer)
            {

                if (order.Installement == Installement.Eighteen)
                {
                    productamount = ((100 + 4) * order.ProductPrice) / 100;
                }
                else if (order.Installement == Installement.TwentyFour)
                {
                    productamount = ((100 + 8) * order.ProductPrice) / 100;
                }
                else
                {
                    productamount = order.ProductPrice;
                }
            }

            else if (order.Category == Category.Television)
            {

                if (order.Installement == Installement.TwentyFour)
                {
                    productamount = (((100 + 4)) * order.ProductPrice) / 100;
                }
                else
                {
                    productamount = order.ProductPrice;
                }

            }
            return new Response<double>(productamount);

        }

        catch (System.Exception ex)
        {
            return new Response<double>(HttpStatusCode.InternalServerError, new List<string>() { ex.Message });
        }

    }
    public async Task<Response<List<OrderDto>>> GetOrder()
    {
        try
        {
            var response = await _context.Orders.ToListAsync();
            var mapped = _mapper.Map<List<OrderDto>>(response);
            return new Response<List<OrderDto>>(mapped);
        }
        catch (System.Exception ex)
        {
            return new Response<List<OrderDto>>(HttpStatusCode.InternalServerError, new List<string>() { ex.Message });
        }

    }


}

