using Stack;
using System;

namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(); // Khởi tạo ngăn xếp

            string choice;
            do
            {
                // Nhập số nguyên N ở hệ 10
                Console.WriteLine("Nhập số nguyên N (hệ 10): ");
                int n = int.Parse(Console.ReadLine());
                int so = n; // Lưu lại giá trị ban đầu của N

                // Nhập hệ cơ số cần chuyển đổi (2, 8, 16)
                Console.WriteLine("Nhập hệ số X cần chuyển đổi (2, 8, 16): ");
                int x = int.Parse(Console.ReadLine());

                // Kiểm tra nếu hệ cơ số hợp lệ
                if (x == 2 || x == 8 || x == 16)
                {
                    // Chuyển đổi số sang hệ cơ số tương ứng và lưu vào stack
                    while (n > 0)
                    {
                        stack.Push(n % x); // Đẩy phần dư vào stack
                        n = n / x; // Cập nhật giá trị N
                    }
                }
                else
                {
                    Console.WriteLine("Hệ số không hợp lệ!");
                    return; // Thoát chương trình nếu hệ số không hợp lệ
                }

                string kq = ""; // Biến lưu kết quả
                string dinhdangcua16 = "0123456789ABCDEF"; // Chuỗi chứa ký tự hệ 16

                // Lấy các phần tử từ stack ra để tạo kết quả cuối cùng
                while (!stack.IsEmpty())
                {
                    int a = stack.Pop(); // Lấy phần tử từ đỉnh stack

                    if (x == 16)
                    {
                        kq += dinhdangcua16[a]; // Chuyển số thành ký tự hệ 16
                    }
                    else
                    {
                        kq += a; // Thêm số bình thường vào chuỗi kết quả
                    }
                }

                // In kết quả
                Console.WriteLine($"Số {so} chuyển sang hệ {x} là: {kq}");

                // Hỏi người dùng có tiếp tục không
                Console.WriteLine("Tiếp tục không? (Y/N)");
                choice = Console.ReadLine();
            } while (choice.ToUpper() == "Y"); // Lặp lại nếu người dùng nhập "Y"

            Console.ReadLine();
        }

    }
}
