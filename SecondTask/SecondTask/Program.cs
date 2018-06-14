using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a list  for data
      var elementCollection = new List<Element>
      {
        new Element
        {
          Num=1,
          Name= "Nihanth",
          Age=25
        },
        new Element
        {
          Num=3,
          Name= "Varsha",
          Age=22
        },
        new Element
        {
          Num=2,
          Name= "Reddy",
          Age=22
        }
      };


      //get unique elements 
      var uniqueElements = GetUnique(elementCollection);

      // convert List to the string json for console.Writeline
      var jsonElements = JsonConvert.SerializeObject(uniqueElements);
      Console.WriteLine(jsonElements);

      Console.ReadLine();
    }

    /// <summary>
    /// Method takes List<Element> as an argument and returns List<Element> where all elements are unique by "num" and age > 20.
    /// </summary>
    /// <param name="elements">ICollection<Element> </param>
    /// <returns>ICollection<Element></returns>
    private static List<Element> GetUnique(List<Element> elements)
    {
      List<Element> returnedElements = elements.Where(e => e.Age > 20)
        .GroupBy(g => new
        {
          g.Num
        })
        .Select(s => new Element
        {
          Num = s.Key.Num,
          Name = s.FirstOrDefault().Name,
          Age = s.FirstOrDefault().Age

        }).ToList();

      return returnedElements;
    }
  }
}
