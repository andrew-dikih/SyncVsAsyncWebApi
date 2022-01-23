using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib.Metrics;

public class ActiveRequest
{
    public IThread? Thread { get; set; }
    public long RequestId { get; set; }

    public override string ToString()
    {
        return $"{RequestId}({Thread?.Id})";
    }
}
