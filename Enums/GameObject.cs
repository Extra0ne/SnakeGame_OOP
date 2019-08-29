using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum GameObject : ushort
    {
        def = ' ',
        snakeTail = 'o',
        apple = '$',
        walls = '#'
    }
}
