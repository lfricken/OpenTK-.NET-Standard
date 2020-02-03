using System;
using System.Threading;
using OpenTK;
using OpenTK.Input;
using OpenTK.Platform;


namespace InputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Toolkit.Init(new ToolkitOptions()
            {
                Backend = PlatformBackend.PreferNative,
                EnableHighResolution = true
            });
            Console.WriteLine("Testing Keyboard");

            while (true)
            {
                var keyboard = Keyboard.GetState();
                if (keyboard.IsAnyKeyDown)
                {
                    Console.WriteLine("Key detected. Working");
                    break;
                }

                Thread.Sleep(500);
            }
        }
    }
}
