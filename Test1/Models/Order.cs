using System.ComponentModel.DataAnnotations.Schema;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Date = Microsoft.OData.Edm.Date;

namespace Test1.Models;

public class Order
{
    public int Id { get; set; }
    public string PersonalID { get; set; }
    public int Number { get; set; }
    [NotMapped]
    public Date Date { get; set; }
}