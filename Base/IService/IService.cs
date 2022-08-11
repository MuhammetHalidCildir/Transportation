using Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.IService
{
    public interface IService
    {
        string CardControl();
        string AddMoneyToPrivateCard(decimal money,PrivateCard privateCard);
        string AddMoneyToAnoymousCard(decimal money,AnonymousCard anonymousCard);

    }
}
