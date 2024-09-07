using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Shared.Response
{
    public class ResponseBase
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
    }

    public class ResponseBaseGeneric<T> : ResponseBase
    {
        public T Data { get; set; } = default!;
    }

    public class PaginationResponse<T> : ResponseBase
    {
        public ICollection<T>? Data { get; set; }
        public int TotalPages { get; set; }
    }
}
