using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LittleWork.Entity;
using LittleWork.Repository;
using LittleWork.ExtensionMethods;


namespace LittleWork.Game
{
    public class IndexModel : PageModel
    {
        public IList<GameItemModel> Items { get; set; }

        private GameRepository _repository;

        public IndexModel()
        {
            string description = GameKind.RPG.GetDescription();
            _repository = new GameRepository();
        }
        public void OnGet()
        {
            Items = _repository.get();
        }

        public void Onpost()
        {
            _repository.Add(new GameItemModel());
        }













    }
}