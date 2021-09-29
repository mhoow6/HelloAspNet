using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloEmpty.Models;

namespace RazorTutorial.Pages
{
    public class IndexModel : PageModel
    {
        // �� ���ε� ������ �Ͻ��ؾ� �Ѵ�.
        [BindProperty]
        public HelloMessage HelloMsg { get; set; }
        public string Noti { get; set; }

        public void OnGet()
        {
            this.HelloMsg = new HelloMessage()
            {
                Message = "Hello Razor Pages"
            };
        }

        public void OnPost()
        {
            this.Noti = "Message Changed";
        }
    }
}
