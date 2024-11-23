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
    public class ElectionManager : IElectionService
    {
        private IElectionDal _electionDal;
        public ElectionManager(IElectionDal electionDal)
        {
            _electionDal = electionDal;
        }
        public async Task<List<Election>> GetElections()
        {
            return await _electionDal.GetAll();
        }
    }
}
