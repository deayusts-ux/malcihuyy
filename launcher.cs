using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = @"C:\myob18ED\Myob.exe";
        psi.WorkingDirectory = @"C:\myob18ED";
        psi.UseShellExecute = true;
        // Optionally run as admin if needed
        // psi.Verb = "runas"; 
        
        try {
            Process.Start(psi);
        } catch (Exception ex) {
            Console.WriteLine("Terjadi kesalahan saat membuka MYOB: " + ex.Message);
            Console.ReadLine();
        }
    }
}
