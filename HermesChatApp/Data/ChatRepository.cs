using HermesChatApp.Data;
using HermesChatLoginUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HermesChatLoginUI.Data
{
    public class ChatRepository
    {

        private ApplicationDbContext _context;

        public ChatRepository(ApplicationDbContext context) => _context = context;

        public Chat GetChat(int id)
        {
            return _context.Chats
                .Include(x => x.Messages)                
                .FirstOrDefault(x => x.Id == id);
        }

        //public string GetProfilePicture(int userId)
        //{

        //}

        public IEnumerable<Chat> GetChats(string userId)
        {
            return _context.Chats
                .Include(x => x.Users)
                .Where(x => !x.Users
                    .Any(y => y.UserId == userId))
                .ToList();
        }

        public async Task<Message> CreateMessage(int chatId, string message, string userId)
        {
            var Message = new Message
            {
                ChatId = chatId,
                Text = message,
                Name = userId,
                Timestamp = DateTime.Now
            };

            _context.Messages.Add(Message);
            await _context.SaveChangesAsync();

            return Message;
        }


    }
}