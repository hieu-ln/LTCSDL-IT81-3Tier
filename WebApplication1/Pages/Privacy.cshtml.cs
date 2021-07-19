using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using LTCSDL.BLL;
using LTCSDL.DAL.DTO;

namespace WebApplication1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public CategoriesDTO cate;
        public string msg;
        CategoriesBLL srv;
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
            srv = new CategoriesBLL();
        }

        public void OnGet()
        {
            cate = new CategoriesDTO();
            //string msg = "";
            cate = srv.getCategoryById(2, out msg);            
        }
    }
}
