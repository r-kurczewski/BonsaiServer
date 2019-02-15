using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Models
{
    public class ServerResponse
    {
        public int ErrorCode;

        public ServerResponse(int errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}
