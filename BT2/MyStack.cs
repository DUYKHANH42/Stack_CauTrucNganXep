using BT2;

namespace Stack
{
    // Lớp MyStack: Cấu trúc ngăn xếp sử dụng danh sách liên kết đơn
    public class MyStack
    {
        private Node top; // Con trỏ trỏ đến phần tử đầu của ngăn xếp

        // Constructor: Khởi tạo ngăn xếp rỗng
        public MyStack()
        {
            top = null;
        }

        // Kiểm tra ngăn xếp có rỗng không
        public bool IsEmpty()
        {
            if (top == null) // Nếu top == null, ngăn xếp rỗng
            {
                return true;
            }
            return false;
        }

        // Thêm phần tử vào đỉnh ngăn xếp (Push)
        public void Push(int x)
        {
            Node p = new Node(x); // Tạo node mới chứa giá trị x
            if (top == null) // Nếu ngăn xếp rỗng, node mới là top
            {
                top = p;
            }
            else
            {
                p.next = top; // Liên kết node mới với top hiện tại
                top = p; // Cập nhật top mới
            }
        }

        // Lấy phần tử khỏi đỉnh ngăn xếp (Pop)
        public int Pop()
        {
            if (top != null) // Nếu ngăn xếp không rỗng
            {
                int x = top.data; // Lấy giá trị của phần tử top
                top = top.next; // Di chuyển top xuống phần tử kế tiếp
                return x; // Trả về giá trị vừa lấy
            }
            return -1; // Trả về -1 nếu ngăn xếp rỗng
        }
    }
}
