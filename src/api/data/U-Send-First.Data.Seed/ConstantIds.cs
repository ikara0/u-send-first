using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Send_First.Data.Seed
{
    public static class ConstantIds
    {
        public class User
        {
            public static Guid AdminId = new("6CAF93D2-614A-41B3-AD12-61F654FD8106");
            public static Guid TestUserId = new("8E006022-46A9-4854-9F3B-36CEC56A796D");
        }
        public static class Message
        {
            public static Guid MessageFirstId = new("3C80E279-2021-4284-899E-73E9545A5F43");
            public static Guid MessageSecondId = new("8B5643DC-8B68-447E-B2BA-6B8BEED32A66");
            public static Guid MessageThirdId = new("666CF0BF-188D-4B73-A418-6A0570264108");
            public static Guid MessageFourthId = new("C379AF85-ED02-4B2E-9B19-7DF994930A01");
        }
    }
}
