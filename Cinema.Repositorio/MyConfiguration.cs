﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Repositorio
{
    public class MyConfiguration: DbConfiguration
    {
        public MyConfiguration()
        {
            SetProviderServices(
                System.Data.Entity.SqlServer.SqlProviderServices.ProviderInvariantName,
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
                );
        }
    }
}
