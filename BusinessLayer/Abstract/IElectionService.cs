﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IElectionService
    {
        public Task<List<Election>> GetElections();
        public Task Add(Election entity);
    }
}
