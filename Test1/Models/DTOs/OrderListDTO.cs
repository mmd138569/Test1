using System;
using System.Collections.Generic;

namespace Test1.Models.DTOs;

public class OrderListDTO
{
    public int Id { get; set; }
    public string Number { get; set; }
    public DateTime Date { get; set; }
    public string PersonalName { get; set; }

    public List<OrderDetailListDTO> Items { get; set; }
}