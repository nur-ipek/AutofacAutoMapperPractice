using Autofac;
using AutoFac_Example.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace AutoFac_Example.Configurations
{
    public class RegisterModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmailService>().As<IMailService>();
        }
    }
}
