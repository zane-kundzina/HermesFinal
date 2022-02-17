using HermesChatLoginUI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HermesChatLoginUI.Models;
using System.Dynamic;

namespace HermesChatApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ChatRepository _repo;
        public HomeController(ChatRepository repo) => _repo = repo;

        public int ChatId { get; private set; }


        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet("{id}")]
        public IActionResult Chat()
        {
            var chatSet = new ChatViewModel();
            chatSet.ActiveChat = _repo.GetChat(1);
            //chatSet.Chats = _repo.GetChats();
            
            //string userImage = default avatar if there is no user image uploaded by user (coolCat) or image path to uploaded image by user;


            return View(chatSet);
        }

        
        public IActionResult Settings()
        {
            return View();
        }
        
        public IActionResult SettingsTest()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> CreateMessage(int chatId, string message)
        {
            var Message = await _repo.CreateMessage(chatId, message,User.Identity.Name);

            return RedirectToAction("Chat");
        }

    }
}
