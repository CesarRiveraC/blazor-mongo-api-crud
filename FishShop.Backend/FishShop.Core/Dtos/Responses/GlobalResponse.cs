using FishShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.Core.Dtos.Responses
{
    public class GlobalResponse
    {

        public GlobalResponse(Object result)
        {
            this.Data = result;
        }

        public static int StatusCode => 1;
        public static string Message => "OK";
        public object Data { get; set; }
    }
}
