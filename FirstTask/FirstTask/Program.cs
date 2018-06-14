using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
  class Program
  {
    static void Main(string[] args)
    {
      // create first BTN data
      var firstBTN = new BTN
      {
        val = 1,
        right = new BTN
        {
          val = 2,
          right = new BTN
          {
            val = 3
          }
        }
      };

      // create second BTN data
      var secondBTN = new BTN
      {
        val = 1,
        right = new BTN
        {
          val = 2,
          right = new BTN
          {
            val = 3
          }
        }
      };

      // compare btn
      bool isEqual = CompareBTN(firstBTN, secondBTN);

      //console the result
      Console.WriteLine("Is Equal: " + isEqual);
      Console.ReadLine();
    }

    public static bool CompareBTN(BTN firstBTN, BTN secondBTN)
    {
      //base case : check both are null
      if (firstBTN == null && secondBTN == null)
        return true;
      //base case :  check any of these is null
      if (firstBTN == null || secondBTN == null)
        return false;

      if (firstBTN.val == secondBTN.val)
      {
        //subtrees
        bool left = CompareBTN(firstBTN.left, secondBTN.left);
        bool right = CompareBTN(firstBTN.right, secondBTN.right);
        return (left && right);
      }
      else
      {
        return false;
      }
    }

  }
}
