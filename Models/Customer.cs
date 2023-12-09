using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace Databinding_Session_Demo.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
