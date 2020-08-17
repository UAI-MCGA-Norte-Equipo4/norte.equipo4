using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Error : IdentityBase
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public DateTime ErrorDate { get; set; }

        public string IpAddress { get; set; }

        public string UserAgent { get; set; }

        public string Exception { get; set; }

        public string Message { get; set; }

        public string Everything { get; set; }

        public string HttpReferer { get; set; }

        public string PathAndQuery { get; set; }

    }
}
