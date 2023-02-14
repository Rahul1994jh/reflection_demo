using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class BaseAttribute : Attribute
    {
        public string? Name { get; set; }
    }
}
