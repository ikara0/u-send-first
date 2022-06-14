using U_Send_First.Data.Seed;

namespace Microsoft.EntityFrameworkCore.Migrations
{
    public static class MigrationBuilderExtensions
    {
        public static void MigrateUsers(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Users",
                                        new string[]
                                        {
                                            "Id","UserName","EMail","Password","CreatedAt","CreatedBy","ModifiedAt","ModifiedBy",
                                        },
                                        new object[,]
                                        {
                                            {ConstantIds.User.AdminId,"admin","admin@usendfirst.com","123!",DateTime.Now,ConstantIds.User.AdminId,DateTime.Now,ConstantIds.User.AdminId},
                                            {ConstantIds.User.TestUserId,"Jim","jim@usendfirst.com","123!",DateTime.Now,ConstantIds.User.AdminId,DateTime.Now,ConstantIds.User.AdminId }
                                        },
                                        schema: "Profile");
        }

        public static void MigrateMessages(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Messages",
                                        new string[]
                                        {
                                            "Id","UserId","Content","Subject","IsRead","CreatedAt","CreatedBy","ModifiedAt","ModifiedBy"
                                        },
                                        new object[,]
                                        {
                                            {ConstantIds.Message.MessageFirstId,ConstantIds.User.AdminId,"Just wanted to check on you!","Hi Again",false,DateTime.Now.AddDays(-5),ConstantIds.User.TestUserId,DateTime.Now,null},
                                            {ConstantIds.Message.MessageSecondId,ConstantIds.User.TestUserId,"Just wanted to let you know I'm good","Hi Friend",false,DateTime.Now,ConstantIds.User.AdminId,DateTime.Now,null },
                                            {ConstantIds.Message.MessageThirdId,ConstantIds.User.AdminId,"You have to hurry! We'll be late to the party.","Warning!!",true,DateTime.Now.AddDays(-1),ConstantIds.User.TestUserId,DateTime.Now,ConstantIds.User.TestUserId},
                                            {ConstantIds.Message.MessageFourthId,ConstantIds.User.TestUserId,"Hey ! Check out this job posting!","Job Alert",true,DateTime.Now,ConstantIds.User.AdminId,DateTime.Now,ConstantIds.User.AdminId}
                                        },
                                        schema: "Media");
        }
    }
}