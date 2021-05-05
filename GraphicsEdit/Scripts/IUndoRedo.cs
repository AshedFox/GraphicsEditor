using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts
{
    interface IUndoRedo
    {
        void Undo();

        void Redo();
    }
}
