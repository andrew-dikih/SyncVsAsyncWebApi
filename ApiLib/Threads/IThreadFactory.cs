using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib;

public interface IThreadFactory
{
    IThread CreateThread(int synchronousTimeMs, int ioTimeMs,IoBehavior ioBehavior,string id);
}
