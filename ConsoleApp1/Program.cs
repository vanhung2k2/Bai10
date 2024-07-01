using DAL;
using DALImpl;
using DTO;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void StudentManager()
            {
                {
                    INhanVien nhanVienManager  = new NhanVienManager();

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Menu:");
                            Console.WriteLine("1. Thêm nhân viên");
                            Console.WriteLine("2. Tạo sản lượng theo công đoạn của từng nhân viên");
                            Console.WriteLine("3. Xuất và hiển thị báo cáo");
                            Console.WriteLine("4. Thoát");
                            Console.Write("Chọn chức năng: ");
                            int choice;
                            if (!int.TryParse(Console.ReadLine(), out choice))
                            {
                                Console.WriteLine("Chức năng không hợp lệ, vui lòng chọn lại!");
                                continue;
                            }

                            switch (choice)
                            {
                                case 1:
                                    nhanVienManager.ThemNhanVien();
                                    break;

                                case 2:
                                    Console.Write("Nhập ID nhân viên: ");
                                    if (!int.TryParse(Console.ReadLine(), out int idNhanVien))
                                    {
                                        Console.WriteLine("ID nhân viên không hợp lệ.");
                                        continue;
                                    }

                                    Console.Write("Nhập mã công đoạn: ");
                                    string maCongDoan = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(maCongDoan))
                                    {
                                        Console.WriteLine("Mã công đoạn không được để trống.");
                                        continue;
                                    }

                                    Console.Write("Nhập tên công đoạn: ");
                                    string tenCongDoan = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(tenCongDoan))
                                    {
                                        Console.WriteLine("Tên công đoạn không được để trống.");
                                        continue;
                                    }

                                    Console.Write("Nhập số lượng sản phẩm: ");
                                    if (!int.TryParse(Console.ReadLine(), out int soLuongSanPham) || soLuongSanPham < 0)
                                    {
                                        Console.WriteLine("Số lượng sản phẩm không được nhỏ hơn 0.");
                                        continue;
                                    }

                                    CongDoan congDoan = new CongDoan(maCongDoan, tenCongDoan, soLuongSanPham);
                                    nhanVienManager.TaoSanLuong(idNhanVien, congDoan);
                                    break;

                                case 3:
                                    break;

                                case 4:
                                    return;

                                default:
                                    Console.WriteLine("Chức năng không hợp lệ, vui lòng chọn lại!");
                                    break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập lại.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi không xác định: {ex.Message}");
                        }
                    }

                }
            }
        }
    }
}