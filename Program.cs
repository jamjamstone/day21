namespace day21
{
   class Algorihm
    {
        static Random Random = new Random();
        public static void FisherYatesShuffle(int[] ints)
        {
            for(int i=ints.Length-1; i > 0; i--)//역순으로 진행
            {
                int j = Random.NextIncludeEndNum(0, i);// 앞에있는 인덱스중 하나를 랜덤으로 잡아 서로 교환
                int temp=ints[i];
                ints[i]=ints[j];
                ints[j]=temp;
            }
        }
    }
        class Animal
        {
            public string Name { get; set; }
        }
        class Pig : Animal
        {

        }
        class DontTouch
        {
            public string messageToOther = "터진다!";

        }
            
        class Change : DontTouch
        {
            public void PrintAddedFunction()
            {
                Console.WriteLine("추가함");
            }
        }





    internal class Program
    {

        static void Main(string[] args)
        {
            //노드와 링크드리스트 
            //링크드 리스트 사용처-> 스타크래프트의 이동명령 예약 등 삭제와 갱신 추가가 
            //많이 일어나는 부분, 버프 디버프 등
            ///단방향 링크드리스트
            ///value와 next를 보유
            ///링크드리스트는 마지막에 추가 처음에 추가 제거 등등의 기능이 존재한다.
            ///양방향리스트의 경우에는 메모리를 추가로 사용하는 단점이 존재 대신 장점도 존재하는데 바로 뒤애서
            ///부터 찾아가는 방법이 존재한다.
            ///널러블을 사용하는 이유 0과 null은 다르기 때문
           /// 다형성을 이용해 형변환이 일어난 경우 바뀌기 전 클래스의 특수능력을 못 써서
           /// 다시 형변환 해줘야 한다.
           /// 확장메소드
           /// 이미 만들어진 클래스를 건드리지 않으면서 기능 추가하는 방법
           /// console이나 Math처럼 정적으로 만들어진 클래스는 확장메소드
           /// 사용불가! 일반적인 클래스들만 확장메서드 사용 가능!
           /// 셔플 알고리즘 -> fisher yates 알고리즘 
           /// 맨 뒤에서부터 역순으로, 앞의 인덱스를 랜덤으로 뽑아다가 섞는 알고리즘
           /// 
            Random random = new Random();
            int tempNum=random.Next(1,7);
            random.NextIncludeEndNum(1, 6);//확장메소드로 인해서 추가됨!
            Console.WriteLine("주사위 굴려서 "+tempNum+"이 나왔습니다.");
            
            DontTouch dt = new DontTouch();
            dt.AddedFunction();
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            ints.Add(6);
            ints.PrintAllMembers();

        }
    }
}
