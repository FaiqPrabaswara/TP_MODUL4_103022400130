using System;
using TP_MODUL4_103022400130;

namespace TP_MODUL4_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kodePos = new KodePos();

            Console.WriteLine("=== TABLE DRIVEN: KODE POS ===");
            Console.WriteLine("Batununggal : " + kodePos.getKodePos("Batununggal"));
            Console.WriteLine("Kujangsari  : " + kodePos.getKodePos("Kujangsari"));
            Console.WriteLine("Mengger     : " + kodePos.getKodePos("Mengger"));
            Console.WriteLine("Wates       : " + kodePos.getKodePos("Wates"));
            Console.WriteLine("Cijaura     : " + kodePos.getKodePos("Cijaura"));
            Console.WriteLine("Jatisari    : " + kodePos.getKodePos("Jatisari"));
            Console.WriteLine("Margasari   : " + kodePos.getKodePos("Margasari"));
            Console.WriteLine("Sekejati    : " + kodePos.getKodePos("Sekejati"));
            Console.WriteLine("Kebonwaru   : " + kodePos.getKodePos("Kebonwaru"));
            Console.WriteLine("Maleer      : " + kodePos.getKodePos("Maleer"));

            Console.WriteLine();
            Console.WriteLine("Tekan Enter untuk lanjut ke simulasi DoorMachine...");
            Console.ReadLine();

            DoorMachine door = new DoorMachine();

            Console.WriteLine("=== STATE BASED CONSTRUCTION: DOOR MACHINE ===");
            door.BukaPintu();
            door.KunciPintu();
            door.BukaPintu();
        }
    }
}