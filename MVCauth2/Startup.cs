﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCauth2.Startup))]
namespace MVCauth2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
