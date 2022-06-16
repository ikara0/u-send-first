using U_Send_First.Data.Context;
using U_Send_First.Data.Dto;
using U_Send_First.Data.Services.Abstractions;

namespace U_Send_First.Data.Services.Concretes
{
    internal class MessageService : IMessageService
    {
        private readonly USendFirstDbContext dbContext;

        public MessageService(USendFirstDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public MessageViewDto GetMessageById(Guid id)
        {
            var data = dbContext.Messages.SingleOrDefault(m => m.Id == id);
            if(data == null)
            {
                return null;
            }
            var selectedMessage = new MessageViewDto
            {
                Subject = data.Subject,
                Content = data.Content
            };
            return selectedMessage;

        }

        public List<MessageListDto> GetMessageByUserId(Guid id)
        {
            var data = dbContext.Messages.Where(m => m.UserId == id)
                                         .Select(m => new MessageListDto
                                         {
                                             MessageId = m.Id,
                                             Subject = m.Subject,
                                             Content = m.Content,
                                             IsRead = m.IsRead,
                                         }).ToList();

            return data;
        }

        public TotalMessageInfoDto InfoForUser(Guid id)
        {
            var user = dbContext.Users.SingleOrDefault(u => u.Id == id);
            if (user is null)
            {
                return null;
            }
            var totalMessages = dbContext.Messages.Where(m => m.UserId == id)
                                                  .Count();

            var unReadMessages = dbContext.Messages.Where(m => m.UserId == id && m.IsRead == false).Count();
                                                 
            var data = new TotalMessageInfoDto
            {
                UnReadMessages = unReadMessages,
                TotalMessages = totalMessages,
                UserName = user.UserName
            };

            return data;
        }

        public bool ReadMessage(Guid id)
        {
            var message = dbContext.Messages.SingleOrDefault(m => m.Id == id);
            if(message is null)
            {
                return false;
            }
            message.IsRead = true;
            dbContext.Update(message);
            return dbContext.SaveChanges() > 0;
        }
    }
}