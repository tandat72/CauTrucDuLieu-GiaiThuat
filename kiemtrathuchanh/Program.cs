using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtrathuchanh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Câu 1
            BinarySearchTree tree = new BinarySearchTree();
            Console.Write("CAY TIM KIEM NHI PHAN");
            Console.Write("\nNhap so nut: ");

            int N = Convert.ToInt32(Console.ReadLine());
            int x;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap gia tri khoa thu {0}: ", i + 1);
                x = Convert.ToInt32(Console.ReadLine());
                tree.Add(x);
            }
            tree.hienthi();
            //câu 2
            Console.Write("\nGia tri nut max: {0}", tree.FindMax(tree.root));
            //câu 3
            Console.Write("\nDem nut le: {0}", tree.demnutle(tree.root));
            //Câu 4
            Console.Write("\nNhap gia tri nut muon huy: ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            tree.Remove(X1);
            Console.Write("Duyet Thu tu truoc sau huy {0}:\t", X1);
            tree.PreOrder(tree.root);

            //Câu 5
            Console.Write("\nDuyet thu tu sau: \t");
            tree.PostOrder(tree.root);
            Console.ReadKey();
        }
    }
}
