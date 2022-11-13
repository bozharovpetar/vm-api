using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Domain.Models;

namespace VM.Repository
{
    public interface ICoffeeRepository : IRepository<Coffee>
    {
        Coffee GetByName(string name);
    }
}
