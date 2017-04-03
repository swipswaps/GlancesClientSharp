using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.UI
{
    public class GenericEventArgs<T> : EventArgs
    {
        public T Element { get; private set; }

        public GenericEventArgs(T element)
        {
            Element = element;
        }
    }
}
