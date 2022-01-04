using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFac_Example.Services
{
    public interface IMailService
    {
        List<string> GetEmailAddress();
    }
}
