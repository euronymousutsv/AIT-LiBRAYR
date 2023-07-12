using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class MediaLogic
    {
        private MediaDAO mediaDAO;
        private MediaDS.ViewMediaDataTable mediaTable;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
            mediaTable = new MediaDS.ViewMediaDataTable();
            
        }

        public List<>
    }
}
