﻿using System;

namespace TheBasics
{
    class MenggunakanObjectBuku
    {
        static void Main(string[] args)
        {
            Buku bukuSatu = new Buku();
            bukuSatu.judulBuku="Buku Saku";
            bukuSatu.jumlahHalaman=129;
            bukuSatu.penulis="Penulis Buku Saku";

            Buku bukuDua = new Buku();
            bukuDua.judulBuku="Buku Dua";
            bukuDua.jumlahHalaman=900;
            bukuDua.penulis="Penulis Buku Dua";
            
            Console.WriteLine(bukuSatu.judulBuku);
            Console.WriteLine(bukuSatu.jumlahHalaman);
            Console.WriteLine(bukuSatu.penulis);

            Console.WriteLine(bukuDua.judulBuku);
            Console.WriteLine(bukuDua.jumlahHalaman);
            Console.WriteLine(bukuDua.penulis);

            Console.ReadLine();
        }
    }
}