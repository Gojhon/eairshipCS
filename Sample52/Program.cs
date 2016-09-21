using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample52
{
    struct Test
    {
        public string name;
        public int korean;
        public int math;
        public int society;
        public int science;

        public Test(string name, int korean, int math, int society, int science)
        {
            this.name = name;
            this.korean = korean;
            this.math = math;
            this.society = society;
            this.science = science;
        
        }
        public void Show()
        {
            Console.WriteLine(name + "의 시험 점수:");
            Console.WriteLine("국어: " + korean + ", 수학: " + math + ", 사회:" + society + ", 과학: " + science);
        }
      }
    class Program
    {
        static void Main(string[] args)
        {
            Test student1 = new Test("김철수", 94, 96, 84, 92);
            student1.Show();

            Test student2;
            student2.name = "김영희";
            student2.korean = 100;
            student2.math = 84;
            student2.society = 96;
            student2.science = 86;
            student2.Show();
        }
    }
}
