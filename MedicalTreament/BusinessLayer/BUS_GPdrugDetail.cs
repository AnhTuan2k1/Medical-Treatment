using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BUS_GPdrugDetail
    {
        DAO_GPdrugDetail dao_GPdrugDetail;

        public BUS_GPdrugDetail()
        {
            dao_GPdrugDetail = DAO_GPdrugDetail.getInstance();
        }

    }
}
