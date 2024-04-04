using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;
internal class Connection
{
    private string connectionString = "Data Source=NOTE-FABIO;Initial Catalog=ScreenSound;Persist Security Info=True;User ID=sa;Password=1234;Encrypt=False;Trust Server Certificate=True";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }
}
