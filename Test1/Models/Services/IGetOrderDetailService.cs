using System.Collections.Generic;
using Test1.Models.DTOs;
using Test1.Models.Entities;

namespace Test1.Models.Services;

public interface IGetOrderDetailService
{
    List<OrderDetailListDTO> Execute();
}
