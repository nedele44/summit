using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using yiqibang.Entity;
using yiqibang.Repository;

namespace yiqibang.Pages.Article
{
    public class IndexModel : PageModel
    {
        public IList<ArticleItemModel> Items { get; set; }
        private ArticleRepository _repository;
        public IndexModel()
        {
            _repository = new ArticleRepository();
        }
        public void OnGet()
        {
            Items = _repository.Get();
        }
    }
}