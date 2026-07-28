using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApi_Test.Model;

namespace WebApi_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplyoeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Details()
        {
            return Ok("sunil");
        }

        [HttpGet("emplyoee")]
        public ActionResult<Employee> Employees()
        {
            var emp = new List<Employee>
            {
                new Employee
                {
                    ID =1,
                    Name ="sunil",
                    City = "Buldana"
                },
                new Employee
                {
                    ID = 2,
                    Name = "gayatri",
                    City ="Pune"
                }
            };
            return Ok(emp);
        }

        [HttpPost("LowestValue")]
        public IActionResult Find_Lowest_Value([FromBody] int[] numbers)
        {
            //int[] arr = [55, 77, 66, 11, 66, 88, 2, 77];
            //int minval = arr[0];
            //for (int i=0;i<arr.Length;i++)
            //{
            //    if (arr[i]< minval)
            //    {
            //        minval = arr[i];
            //    }
            //}

            int minval= numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < minval)
                {
                    minval = numbers[i];
                }

            }

            return Ok(minval);
        }

        [HttpPost("BubbleSort")]
        public IActionResult BubbleSortNos([FromBody] int [] numbers)
        {
            //int[] arr = [55, 44, 9, 7, 33, 66, 88];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length-1 -i; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            int temp = arr[j];
            //            arr[j]= arr[j+1];
            //            arr[j + 1] = temp;
            //        }
            //    }               
            //}
            //return Ok(arr);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return Ok(numbers);
            
        }

        [HttpPost("ReverseArray")]
        public IActionResult ReverseArray([FromBody] int[] number)
        {
            //int[] arr = [10, 20, 30, 40, 50,60];
            //int i =0;
            //while (i<(arr.Length)/2)
            //{
            //    int temp = arr[i];
            //    arr[i] = arr[arr.Length-1-i];
            //    arr[arr.Length-1-i] = temp;
            //    i++;
            //}
            //return Ok(arr);

          
            int i = 0;
            while (i < (number.Length) / 2)
            {
                int temp = number[i];
                number[i] = number[number.Length - 1 - i];
                number[number.Length - 1 - i] = temp;
                i++;
            }
            return Ok(number);
        }

        [HttpGet("Cities")]
        public IActionResult DummyApiData()
        {
            List<string> cities = new List<string>()
            {
                "Mumbai","pune","Buldana","Nagpur"
            };
            return Ok(cities);
        }

        [HttpGet("Employees")]
        public IActionResult EmployeeInfo()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    ID=1,
                    Name="sunil",
                    City ="Buldana",
                    Gender ="Male",
                    salary = 1080000
                },
                new Employee
                {
                    ID=2,
                    Name = "Gayatri",
                    City ="Degaon",
                    Gender ="Female",
                    salary = 15000
                },
                  new Employee
                {
                    ID=3,
                    Name = "Aai",
                    City ="Palodi",
                    Gender ="Female",
                    salary = 150000
                },
                    new Employee
                {
                    ID=2,
                    Name = "Baba",
                    City ="Kherda",
                    Gender ="Male",
                    salary = 1100000
                }

            };
            return Ok(employees);
        }
    }
}
