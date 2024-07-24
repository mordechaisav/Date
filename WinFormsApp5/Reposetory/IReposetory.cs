using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5.Reposetory
{
    internal interface IReposetory<T>
    {
        T Add(T item);
    }
}
