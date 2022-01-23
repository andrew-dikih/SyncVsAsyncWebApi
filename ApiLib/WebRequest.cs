using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib;

public class WebRequest
{
    public long Id { get; }

    public WebRequest(long id)
    {
        Id = id;
    }
}
