using EventsLibrary;
using System;

namespace EventsConsole {
    class Program {

        void NbrMod5(object sender, EventArgs e) {
            Console.WriteLine("The nbr is evently divisible by 5.");
        }
        void Run() {
            var ue = new UserEvent();
            ue.RaiseEvent += NbrMod5;
            ue.Add1();
            ue.Add1();
            ue.Add1();
            ue.Add1();
            ue.Add1();
        }
        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
