using Dapper.Contrib.Extensions;

namespace CrudSqlServer.Models;
[Table("[Marca]")]
public class Marca
{
    public int id { get; set; }
    public string nome { get; set; }
}