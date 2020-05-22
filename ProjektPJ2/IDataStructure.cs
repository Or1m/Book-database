using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPJ2
{
    interface IDataStructure : IEnumerable
    {
        bool isEmpty();
        bool isFull();
        void Clear();
    }
}
