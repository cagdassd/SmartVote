﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICandidateService
    {
        public Task Add(Candidate entity);
        public Task<List<Candidate>> GetAll();
    }
}
