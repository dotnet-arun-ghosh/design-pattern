using design_patterns.CreationalPattern.SimpleFactory;
using System;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple factory simply generates an instance for client without exposing any instantiation logic to the client!");
            var door = DoorFactory.MakeDoor(12.34f, 123.67f);
            var height = door.GetHeight();
            var width = door.GetWidth();
            Console.WriteLine($"Height :{height} Width : {width}");
            Console.WriteLine("==================Simple factory========================");


        }
    }
}
