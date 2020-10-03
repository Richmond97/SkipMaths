/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinoGenius
{
    class Maths
    {
        private int answerR;
        public List<int> answerList = new List<int>();


        public List<int> generateN()
        {

            Random rd = new Random();
            Random rd2 = new Random();
            List<int> firstNumber = new List<int>();
            List<int> secondtNumber = new List<int>();

            int randomOperation;
            int answer;


            //  n1 = n1.next(10, 20);

            for (int i = 0; i < firstNumber.Capacity; i++)
            {
                firstNumber.Add(rd.Next(80, 100));
            }

            for (int i = 0; i < secondtNumber.Capacity; i++)
            {
                secondtNumber.Add(rd.Next(0, 100));
            }

            System.Diagnostics.Debug.WriteLine("Random 1= " + firstNumber + "Random 2 =" + secondtNumber);

            for (int i = 0; i < secondtNumber.Capacity; i++)
            {

                randomOperation = (rd.Next(0, 100));

                if (randomOperation % 2 == 0)
                {
                    for (int j = 0; j < secondtNumber.Capacity; j++)
                    {
                        answer = firstNumber[i] + secondtNumber[i];
                        answerList.Add(answerR);
                    }
                }
                else
                {
                    answer = firstNumber[i] - secondtNumber[i];
                    answerList.Add(answerR);
                }
            }


            System.Diagnostics.Debug.WriteLine(answerList);
            return answerList;
        }

    }
}
*/
        
      

    
