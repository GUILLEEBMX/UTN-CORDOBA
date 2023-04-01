using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Services
{
    public  interface IQueryServices
    {
        public  Task FirstQuery(DataGridView dgvQueries);
        public  Task SecondQuery(DataGridView dgvQueries);
        public  Task ThirthQuery(DataGridView dgvQueries);
        public void MessageToShow(TextBox txtQueries, int numberQuery);


    }
}
