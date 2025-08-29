using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Date = Microsoft.OData.Edm.Date;

namespace Test1.Models.Entities;

public class Order
{
    public int Id { get; set; }
    public int PersonalID { get; set; }
    public int Number { get; set; }
    public ICollection<OrderDetail> orderDetails { get; set; }
    public Personal Personal { get; set; }
    public DateTime Date { get; set; }

}