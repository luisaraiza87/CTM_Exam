using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CTMExam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {


        [HttpGet]
        public string Get(int N)
        {
            List<string> result = FizzBuzz(N);            

            return string.Join(',', result);
        }

        public List<string> FizzBuzz(int n)
        {

            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;

        }
    }
}
