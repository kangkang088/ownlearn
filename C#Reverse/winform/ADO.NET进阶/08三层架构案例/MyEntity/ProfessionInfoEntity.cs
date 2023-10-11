using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntity
{
    public class ProfessionInfoEntity
    {
        public ProfessionInfoEntity() 
        {
            this.ProfessionInfoID = 0;
            this.ProfessionName = string.Empty;
        }
        public int ProfessionInfoID { get; set; }
        public string ProfessionName { get; set; }
    }
}
