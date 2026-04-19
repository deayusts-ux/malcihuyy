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
        // Kita HAPUS bagian verb 'runas' agar tidak ada UAC / Prompt admin yang menyebabkan cancel.
        
        try {
            Process.Start(psi);
        } catch (Exception ex) {
            Console.WriteLine("Terjadi kesalahan saat membuka MYOB: " + ex.Message);
            Console.ReadLine();
        }
    }
}
