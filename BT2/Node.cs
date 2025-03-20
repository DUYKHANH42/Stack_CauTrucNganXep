namespace BT2
{
    public class Node
    {
        public int data; // Lưu giá trị của node
        public Node next; // Trỏ đến node tiếp theo

        // Hàm tạo (constructor) để khởi tạo node với giá trị x
        public Node(int x)
        {
            data = x;  // Gán giá trị cho node
            next = null;  // Ban đầu chưa liên kết với node nào khác
        }
    }


}
