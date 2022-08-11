using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Models
{
    public class AnonymousCard:BaseCard
    {
        public bool Anonymous { get; } = true;
        public bool Is_Physical { get; } = true;
    }
}
