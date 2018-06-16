using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
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
