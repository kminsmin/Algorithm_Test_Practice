using System;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static Member[] members;
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            members = new Member[count];
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(' ');
                members[i] = new Member(int.Parse(temp[0]), temp[1]);
            }
            members = members.OrderBy(m => m.age).ToArray();
            foreach(Member member in members)
            {
                Console.WriteLine($"{member.age} {member.name}");
            }
        }
    }
    class Member
    {
        public int age;
        public string name;

        public Member(int memberAge, string memberName)
        {
            age = memberAge;
            name = memberName;
        }
    }
}