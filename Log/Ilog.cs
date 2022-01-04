using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Log
{
    interface Ilog
    {
        void write(string Content, LevelEnum level);
    }
}
