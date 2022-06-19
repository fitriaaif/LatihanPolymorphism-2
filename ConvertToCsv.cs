using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    public class ConvertToCsv : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            // konversi objek mahasiswa ke CSV
            string csv = string.Format("{0},{1},{2}", mhs.npm, mhs.nama, mhs.email);

            Console.WriteLine("\nHasil konversi ke CSV: ");
            Console.WriteLine(csv);
        }
    }
}