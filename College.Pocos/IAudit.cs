using System;
using System.Collections.Generic;
using System.Text;

namespace College.Pocos
{
    public interface IAudit
    {
        public Guid Id { get; set; }
    }
}
