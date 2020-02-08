using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAgregation
{
    class Department
    {
       public int depid;
       public string deptname;
        public Department(int depid,string deptname)
        {
            this.depid = depid;
            this.deptname= deptname;
        }
    }
}
