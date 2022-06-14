using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<MessageListDto> GetMessageByUserId(Guid id)
        {
            var data = dbContext.Messages.Where(m => m.UserId == id)
                                         .Select(m => new MessageListDto
                                         {
                                             Subject = m.Subject,
                                             Content = m.Content,
                                             IsRead = m.IsRead,
                                         }).ToList();

            return data;
        }
    }
}
