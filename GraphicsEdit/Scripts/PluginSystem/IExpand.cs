using Shapes;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginSystem
{
    interface IExpand
    {
        List<Plugin> ImportAll();
        List<Plugin> Import(string path);
    }
}
