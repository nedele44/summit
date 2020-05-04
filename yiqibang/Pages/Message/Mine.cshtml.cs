using System;
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
            
        }
        public void OnPost()
        {
            if (Request.RouteValues["opt"].ToString()=="read")
            {
                foreach (var item in MyMessages)
                {
                    if (item.Selected)
                    {
                        _repository.Get(item.Id).IsRead = true;
                    }
                }
            }
            else if (Request.RouteValues["opt"].ToString() == "delete")
            {
                foreach (var item in MyMessages)
                {
                    if (item.Selected)
                    {
                        _repository=_repository.Delete(item.Id);
                    }

                }
            }
          
        }
       

    }
}
