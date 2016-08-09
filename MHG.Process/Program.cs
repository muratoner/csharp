using System;
using System.Diagnostics;
using System.Threading;

class Program
{

    /// <summary>
    /// Word dökümanını açma işlemi
    /// </summary>
    static void OpenMicrosoftWord(string file)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "WINWORD.EXE",
            Arguments = file
        };
        Process.Start(startInfo);
    }

    private static void GoogleArama(string t)
    {
        Process.Start($"http://google.com/search?q={t}");
    }

    private static void Kill()
    {
        // notepad başlatılıyor.
        Process process = Process.Start("notepad.exe");
        // 2 saniye bekliyoruz.
        Thread.Sleep(2000);
        // notepad'i kapatıyoruz.
        process.Kill();
    }

    private static void GetProcesses()
    {
        // Lokal bilgisayarda çalışan tüm işlemler getiriliyor.
        Process[] processes = Process.GetProcesses();
        // Toplam sayı bastırılıyor.
        Console.WriteLine("Toplam: {0}", processes.Length);
        // tüm işlemler dögü ile dönülüp processId konsola basılıyor.
        foreach (Process process in processes)
        {
            Console.WriteLine(process.Id);
        }
    }

    private static void GetProcessesByName(string processName)
    {
        while (true)
        {
            // Lokal bilgisayarda çalışan processName değişkeninde belirtilen işlemler getiriliyor.
            Process[] processes = Process.GetProcessesByName(processName);
            // Toplam sayı bastırılıyor.
            Console.WriteLine("{0} " + processName + " işlemi çalışıyor.", processes.Length);
            Thread.Sleep(5000);
        }
    }

    static void Main(string[] args)
    {
        // ... Word dosyasına ait yol geçiliyor.
        OpenMicrosoftWord(@"C:\Users\Murat\Documents\Gears.docx");

        // Google'da aranacak terimi metoda geçiyoruz.
        GoogleArama("muratoner.net");

        // "ornek.txt" adındaki dosya açılacak.
        // ... Konsol uygulamasının exe uzantısının olduğu yerde arayacaktır dosyayı.
        Process.Start("ornek.txt");

        // Process.Start metodunu burada kullanıyoruz.
        Process.Start("C:\\");

        // Notepad uygulaması başlatılacak ve 2 saniye sonra notepad uygulaması kill metodu sayesinde kapatılacak.
        Kill();

        // Tüm işlemler konsola bastırılıyor.
        GetProcesses();

        // chrome uygulamasına ait kaç işlem olduğunu konsola yazacağım 5 saniyede bir.
        GetProcessesByName("chrome");
    }
}