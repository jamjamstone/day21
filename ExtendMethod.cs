using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day21
{
    //확장메소드를 만들기 위해서는 정적메소드 필요
    static class ExtendMethod
    {
        ///정적 메서드 생성하되, 반환값, 함수 이름, 기능을추가하고자 하는 클래스명에 this 붙이기
        public static int NextIncludeEndNum(this Random random, int startNum, int endNum)
        {



            return random.Next(startNum, endNum + 1);
        }

        public static void AddedFunction(this DontTouch dt)
        {
            Console.WriteLine("add function");
        }
        //메서드 명에도 <>를 붙여서 제네릭 표기를 해야 제네릭 타입클래스에 확장메서드 추가 가능
        public static void PrintAllMembers<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
