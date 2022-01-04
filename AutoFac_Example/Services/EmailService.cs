using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFac_Example.Services
{
    public class EmailService : IMailService
    {
        public List<string> GetEmailAddress()
        {
            List<string> mails = new List<string>()
           {
               "tugceeraslan@gmail.com","nuryilmaz@gmail.com"
           };

            return mails;
        }
    }
}
