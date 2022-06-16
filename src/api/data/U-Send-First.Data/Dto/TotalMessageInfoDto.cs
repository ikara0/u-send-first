using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Send_First.Data.Dto
{
    public class TotalMessageInfoDto
    {
        public string UserName { get; set; }
        public int TotalMessages { get; set; }
        public int UnReadMessages { get; set; }
    }
}
