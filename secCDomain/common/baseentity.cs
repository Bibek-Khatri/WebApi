using System;
using System.Collections.Generic;
using System.Text;

namespace secCDomain.common
{
    public class baseentity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
