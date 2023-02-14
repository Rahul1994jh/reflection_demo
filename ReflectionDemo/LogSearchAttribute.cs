using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class SearchAttribute : Attribute
    {
        public string? Name { get; set; }
    }
}
