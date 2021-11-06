//Finished it in 10 minutes

using System;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));
        }

        static int[] gradingStudents(int[] grades)
        {
            int[] ans = new int[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                if(grades[i] >= 38 && grades[i] % 5 != 0)
                {
                    int temp = FindNextHeigherMultiple(grades[i]);
                    if (Math.Abs(grades[i] - temp) < 3)
                        ans[i] = temp;
                    else
                        ans[i] = grades[i];
                }
                else
                    ans[i] = grades[i];
            }

            return ans;
        }

        static int FindNextHeigherMultiple(int n)
        {
            int result = 0;
            for (int i = n; i <= n + 4; i++)
            {
                if(i % 5 == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
