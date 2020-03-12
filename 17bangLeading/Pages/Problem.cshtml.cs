using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharp;
namespace RazorPage
{
    public class ProblemModel : PageModel
    {
        public List<Problem> problems { get; set; }
        public int pageSize = 2;
        public int pageAmount;
        public void OnGet()
        {

            int pageIndex;
            //未输入页码时默认显示第一页
            if (Request.Query["page"].Count == 0)
            {
                pageIndex = 1;
            }
            else
            {
                pageIndex = Convert.ToInt32(Request.Query["page"][0]);
            }
            ProblemRepository repository = new ProblemRepository();
            problems = repository.Get(pageIndex, pageSize);
            pageAmount = (repository.CountOfProblem() / pageSize) + 1;
        }
    }
}