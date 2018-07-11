using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDBFirstAutoMapper.Data;

namespace MVCDBFirstAutoMapper.Business
{
    public class BusinessBase : IDisposable
    {
        public EMDBContext _db = null;
        public CustomMapping _CustomMapping = null;
        public BusinessBase()
        {
            _db = new EMDBContext();
            _CustomMapping = CustomMapping.GetInstance();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
