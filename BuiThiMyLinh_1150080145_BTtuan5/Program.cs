using System;

public class Program
{

    public static void TinhCVDT()
    {
        // Chương trình tính chu vi và diện tích hình chữ nhật
        //  Nhập dữ liệu 
        Console.Write("Nhap vao chieu dai: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap vao chieu rong: ");
        double b = Convert.ToDouble(Console.ReadLine());
        // Tính chu vi và diện tích  
        double fl = (a + b) * 2;
        double S = a * b;
        // iển thị kết quả  
        Console.WriteLine("Chu vi la: " + fl);
        Console.WriteLine("Dien tich la: " + S);
    }

    public static void TimSoLon()
    {
        Console.Write("Nhap vao so nguyen a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap vao so nguyen b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        // Tìm số max  
        int max = 0;
        if (a > b)
        {
            max = a;
        }
        if (b > a)
        {
            max = b;
        }
        Console.WriteLine("So lon hon trong 2 so la: " + max);
    }

    public static void TimSoLonNhat()
    {
        // Tìm max trong 3 số nguyên a, b, c 
        // Nhập dữ liệu 
        Console.Write("Nhap vao so nguyen a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap vao so nguyen b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap vao so nguyen c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        // Tìm số max  
        int max = 0;
        if ((a > b) && (a > c))
        {
            max = a;
        }
        else if ((b > a) && (b > c))
        {
            max = b;
        }
        else
        {
            max = c;
        }
        Console.WriteLine("So lon nhat trong 3 so la: {0}", max);

    }

    public static void XepHang()
    {
        int diem = 8;

        if (diem > 10 || diem < 0)
        {
            Console.WriteLine("Diem khong hop le!");
        }
        else if (diem >= 9)
        {
            Console.WriteLine("Xuat sac!");
        }
        else if (diem >= 8)
        {
            Console.WriteLine("Gioi!");
        }
        else if (diem >= 6.5)
        {
            Console.WriteLine("Kha!");
        }
        else if (diem >= 5)
        {
            Console.WriteLine("Trung binh!");
        }
        else if (diem >= 3.5)
        {
            Console.WriteLine("Yeu!");
        }
        else
        {
            Console.WriteLine("Kem!");
        }

    }
    // Hàm: Tháng có bao nhiêu ngày
    public static void ThangCoBaoNhieuNgay()
    {
        // Nhập dữ liệu
        Console.Write("Nhap vao nam: ");
        int nam = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap vao thang: ");
        int thang = Convert.ToInt32(Console.ReadLine());

        // Tìm số ngày trong tháng
        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Thang co 31 ngay!");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Thang co 30 ngay!");
                break;

            case 2:
                // Kiểm tra năm nhuận:
                // Năm chia hết cho 400 hoặc (chia hết cho 4 và không chia hết cho 100)
                if ((nam % 400 == 0) || ((nam % 4 == 0) && (nam % 100 != 0)))
                {
                    Console.WriteLine("Thang co 29 ngay! (nam nhuan)");
                }
                else
                {
                    Console.WriteLine("Thang co 28 ngay!");
                }
                break;

            default:
                Console.WriteLine("Thang khong hop le!");
                break;
        }
    }


    /*
    Thực hành 5: Viết chương trình nhập vào một số nguyên n. Cho biết:
    a) n là số chẵn hay số lẻ? 
    b) n là số âm hay số không âm? 

    */
    public static void ThucHanh5()
    {
        Console.Write("Nhap vao so nguyen n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // a) n là số chẵn hay số lẻ?
        if (n % 2 == 0)
        {
            Console.WriteLine("n la so chan.");
        }
        else
        {
            Console.WriteLine("n la so le.");
        }

        // b) n là số âm hay số không âm?
        if (n < 0)
        {
            Console.WriteLine("n la so am.");
        }
        else
        {
            Console.WriteLine("n la so khong am.");
        }
    }

    /*Thực hành 6: Viết chương trình nhập vào 2 số thực dương chỉ chiều dài và chiều  rộng của hình chữ nhật. In ra màn hình chu vi và diện tích của hình chữ nhật đó. 
    */
    public static void ThucHanh6()
    {
        Console.Write("Nhap vao chieu dai: ");
        double chieuDai = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap vao chieu rong: ");
        double chieuRong = Convert.ToDouble(Console.ReadLine());

        // Tinh chu vi
        double chuVi = 2 * (chieuDai + chieuRong);
        Console.WriteLine("Chu vi hinh chu nhat la: " + chuVi);

        // Tinh dien tich
        double dienTich = chieuDai * chieuRong;
        Console.WriteLine("Dien tich hinh chu nhat la: " + dienTich);
    }

    /*
    Thực hành 7: Viết chương trình nhập vào ba số thực chỉ độ dài của ba đoạn  thẳng. Kiểm tra nếu ba đoạn thẳng này lập thành được một tam giá thì hiển thị  chu vi và diện tích của tam giác đó. 
    */

    public static void ThucHanh7()
    {
        Console.Write("Nhap vao do dai doan thang 1: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap vao do dai doan thang 2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap vao do dai doan thang 3: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Kiem tra ba doan thang co lap thanh tam giac hay khong
        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Ba doan thang co lap thanh tam giac.");

            // Tinh chu vi
            double chuVi = a + b + c;
            Console.WriteLine("Chu vi tam giac la: " + chuVi);

            // Tinh dien tich
            double p = chuVi / 2; // nửa chu vi
            double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Công thức Heron
            Console.WriteLine("Dien tich tam giac la: " + dienTich);
        }
        else
        {
            Console.WriteLine("Ba doan thang khong lap thanh tam giac.");
        }
    }

    /*
    Thực hành 8: Viết chương trình giải phương trình bậc 2: ax2 + bx + c = 0. 
    */
    public static void ThucHanh8()
    {
        Console.Write("Nhap vao he so a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap vao he so b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap vao he so c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Tinh delta
        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Phuong trinh co nghiem kep:");
            Console.WriteLine("x = " + x);
        }
        else
        {
            Console.WriteLine("Phuong trinh vo nghiem.");
        }
    }


    /*
    Thực hành 9: Tính tổng các phần tử trong mảng.
    */
    public static void ThucHanh9()
    {
        Console.Write("Nhap vao so phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap vao phan tu " + (i + 1) + ": ");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }

        double tong = 0;
        for (int i = 0; i < n; i++)
        {
            tong += arr[i];
        }

        Console.WriteLine("Tong cac phan tu trong mang la: " + tong);
    }

    /*
    Thực hành 10: Dùng giải thuật sắp xếp chọn (Selection Sort) để sắp xếp tăng  dần mảng các số nguyên. Mảng các số nguyên được lưu trong tệp văn bản có tên  là “input_array.txt”.
    */

    public static void ThucHanh10()
    {
        // Đọc mảng từ tệp văn bản
        string[] lines = File.ReadAllLines(@"D:\University\Y4k1 OOP\Code\BuiThiMyLinh_1150080145_BTtuan5\input_array.txt");
        int n = lines.Length;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(lines[i]);
        }
        //in mảng đọc từ file
        Console.WriteLine("Mang doc tu file:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        // Sắp xếp mảng bằng thuật toán sắp xếp chọn
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

       

        // in mảng đã sắp xếp
        Console.WriteLine("\nMang sau khi sap xep tang dan:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }


    /*
    Thực hành 11: Chèn thêm một số nguyên được nhạp vào từ bàn phím vào mảng  đã sắp xếp tăng dần nhưng không làm mất tính tăng dần của mảng. 
    */
    public static void ThucHanh11()
    {
        // Nhập mảng từ bàn phím
        Console.Write("Nhap vao so phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap vao phan tu " + (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sắp xếp mảng
        Array.Sort(arr);

        // Nhập số nguyên cần chèn
        Console.Write("Nhap vao so nguyen can chen: ");
        int x = Convert.ToInt32(Console.ReadLine());

        // Chèn số vào mảng
        Array.Resize(ref arr, n + 1);
        arr[n] = x;

        // Sắp xếp lại mảng
        Array.Sort(arr);

        // In mảng đã sắp xếp
        Console.WriteLine("Mang sau khi chen va sap xep:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    public static void Main()
    {
        //TinhCVDT();
        // TimSoLon();
        // TimSoLonNhat();
        // XepHang();
        // ThangCoBaoNhieuNgay();
        // ThucHanh5();
        // ThucHanh6();
        // ThucHanh7();
        // ThucHanh8();
        // ThucHanh9();
        // ThucHanh10();
        ThucHanh11();

    }
}