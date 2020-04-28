using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleWork.Entity;
using LittleWork.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LittleWork
{

    public class SingleModel : PageModel
    {
        private GameRepository _repository;

        public GameItemModel Game { get; set; }

        public SingleModel()
        {
            _repository = new GameRepository();
        }
        public void OnGet()
        {
            //关于routeData的数据提取，明天在弄，今天尽量把taghelper的表单部分搞定
            int id = Convert.ToInt32(Request.Query["id"]);
            Game = _repository.Get(id);
        }
    }
}