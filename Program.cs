﻿class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
    {
        double max = 0;
        dynamic n1 = nilai1;
        dynamic n2 = nilai2;
        dynamic n3 = nilai3;

        if (n1 > n2 && n1 > n3)
        {
            max = n1;
        }
        else if (n2 > n1 && n2 > n3)
        {
            max = n2;
        }
        else if (n3 > n1 && n3 > n2)
        {
            max = n3;
        }
        else
        {
            Console.WriteLine("Tidak ada angka yang diinput");
        }
        Console.WriteLine("Nilai terbesar adalah: " + max);
    }
}

class Utama
{
    public static void Main(string[] args)
    {
        //103022300114
        PemrosesData pm = new PemrosesData();
        pm.DapatkanNilaiTerbesar<double>(10, 30, 22);
    }
}