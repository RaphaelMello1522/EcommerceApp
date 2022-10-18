using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shared.Service
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Sucess { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
