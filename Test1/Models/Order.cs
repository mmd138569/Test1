using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace Test1.Models;

public class Order
{
    public int Id { get; set; }
    public string PersonalID { get; set; }
    public int Number { get; set; }
    public Date Date { get; set; }
}