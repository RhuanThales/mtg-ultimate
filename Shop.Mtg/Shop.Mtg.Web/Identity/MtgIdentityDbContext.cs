using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.Identity
{
    public class MtgIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public MtgIdentityDbContext()
            : base("MtgDbContext")
        {

        }
    }
}