﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using yiqibang.Entity;
using yiqibang.Model;
using yiqibang.Repository;

namespace yiqibang.Pages.Message
{

    public class MineModel : PageModel
    {

        public IList<MessageModel> MyMessages { get; set; }
        private MessageRepository _repository;
        public MineModel()
        {
            _repository = new MessageRepository();
        }
        public void OnGet()
        {
            MyMessages = _repository.Get();
        }
        public void OnPost()
        {
            string opt = Request.RouteValues["opt"].ToString();
            if (opt == "read")
            {
                foreach (var item in MyMessages)
                {
                    if (item.Selected)
                    {
                        _repository.Get(item.Id).IsRead = true;
                    }
                }
            }
            else if (opt == "delete")
            {
                foreach (var item in MyMessages)
                {
                    if (item.Selected)
                    {
                        _repository.Delete(item.Id);
                    }
                }
            
            }

        }


    }
}
