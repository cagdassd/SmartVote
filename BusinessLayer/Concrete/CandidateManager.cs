using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CandidateManager : ICandidateService
    {
        private readonly ICandidateDal _candidateDal;
        public CandidateManager(ICandidateDal candidateDal)
        {
            _candidateDal = candidateDal;
        }
        public void Add(Candidate entity)
        {
            _candidateDal.Add(entity);
        }
    }
}
