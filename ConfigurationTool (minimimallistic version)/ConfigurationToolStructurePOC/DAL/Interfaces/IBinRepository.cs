﻿using ConfigurationToolStructurePOC.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationToolStructurePOC.DAL.Interfaces
{
    public interface IBinRepository : IRepository<Bin>
    {
        IEnumerable<string> GetAllBinTypes();

    }
}
