using System;

namespace Lab01
{
    // class Student {
    //     private int ID;
    //     private string tenSV;
    //     private string Khoa;
    //     private float DiemTB;
    //     public Student() {
    //         ID = 1;
    //         tenSV = "Vo Tran Trung Anh";
    //         Khoa = "Cong nghe so";
    //         DiemTB = 8.5f;
    //     }
    //     public Student(Student stu) {
    //         ID = stu.ID;
    //         tenSV = stu.tenSV;
    //         Khoa = stu.Khoa;
    //         DiemTB = stu.DiemTB;
    //     }
    //     public Student(int id, string ten, string kh, float dtb){
    //         ID = id;
    //         tenSV = ten;
    //         Khoa = kh;
    //         DiemTB = dtb;
    //     }
    //     public int StudentID {
    //         get {
    //             return ID;
    //             }
    //         set {
    //             ID = value;
    //             }
    //     }
    //     public String Name {
    //         get {
    //             return tenSV;
    //             }
    //         set {
    //             tenSV = value;
    //             }
    //     }
    //     public String KhoaTruong {
    //         get {
    //             return Khoa;
    //             }
    //         set {
    //             Khoa = value;
    //             }
    //     }
    //     public float Diemtrungbinh {
    //         get {
    //             return DiemTB;
    //             }
    //         set {
    //             DiemTB = value;
    //             }
    //     }
    //     public void Show() {
    //         Console.WriteLine("Ma Sinh Vien: {0}", this.ID);
    //         Console.WriteLine("Ho va ten: {0}", this.tenSV);
    //         Console.WriteLine("Khoa: {0}", this.Khoa);
    //         Console.WriteLine("Diem trung binh: {0}", this.DiemTB);
    //     }

    // }
    // class Tester {
    //     public static void Main() {
    //         Student[] DSSV;
    //         int n;
    //         Console.Write("Nhap so luong sinh vien: ");
    //         n = int.Parse(Console.ReadLine());
    //         DSSV = new Student[n]; // TAo mang n phan tu
    //         Console.WriteLine("Nhap danh sach sinh vien ");
    //         for (int i=1;i<=n;i++) {
    //             DSSV[i] = new Student();
    //             Console.Write("Nhap ma sinh vien thu " + i);
    //             DSSV[i].StudentID = int.Parse(Console.ReadLine());
    //             Console.Write("Nhap ten sinh vien thu " + i);
    //             DSSV[i].Name = Console.ReadLine();
    //             Console.Write("Nhap ten khoa thu " + i);
    //             DSSV[i].KhoaTruong = Console.ReadLine();
    //             Console.Write("Nhap diem trung binh thu " + i);
    //             DSSV[i].Diemtrungbinh = float.Parse(Console.ReadLine());
    //         }
    //         Console.WriteLine("=====================Xuat sinh vien==================");
    //         foreach(Student sv in DSSV)
    //             sv.Show();
    //         Console.ReadLine();
    //     }       
    // }
    class trunganh {
        public static void Main(String[] args) {
            // Bai 1
            Console.Write("Nhap so nguyen a103 = ");
            int a103 = Convert.ToInt32(Console.ReadLine());

            if(a103>0) 
                Console.WriteLine("SO NGUYEN DUONG \n");
            else
                Console.WriteLine("SO NGUYEN AM \n");
            
            // Bai 2
            Console.WriteLine("Bai 2");
            Console.Write("Nhap so nguyen k (k<=10) = ");
            
            int k103 = Convert.ToInt32(Console.ReadLine());

            if(k103>10)
                Console.WriteLine("So phai nho hon hoac bang 10");
            else {
                switch (k103)
            {
                case 0:
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
                case 10:
                    Console.WriteLine("Muoi");
                    break;
            }
            }
            // Bai 3
            Console.WriteLine("Bai 3");
            Console.WriteLine("Nhap vao 3 so thuc bat ki");
            Console.Write("So x = ");
            float x103 = Convert.ToSingle(Console.ReadLine());
            Console.Write("So y = ");
            float y103 = Convert.ToSingle(Console.ReadLine());
            Console.Write("So z = ");
            float z103 = Convert.ToSingle(Console.ReadLine());

            if(x103+y103>z103 && x103+z103>y103 && y103+z103>x103){
                Console.WriteLine("La 3 canh cua tam giac");
            }else{
                Console.WriteLine("Khong phai 3 canh cua tam giac \n");
            }
            // Bai 4

            Console.WriteLine("Bai 4");
            Console.WriteLine("Nhap vao 3 so thuc bat ki");
            Console.Write("So thu 1 = ");
            float q103 = Convert.ToSingle(Console.ReadLine());
            Console.Write("So thu 2 = ");
            float w103 = Convert.ToSingle(Console.ReadLine());
            Console.Write("So thu 3 = ");
            float e103 = Convert.ToSingle(Console.ReadLine());

            if(q103+w103>e103 && q103+e103>w103 && w103+e103>q103){
                Console.WriteLine("La 3 canh cua tam giac");
                if((q103*q103 + w103*w103) == e103*e103 || (q103*q103 + e103*e103) == w103*w103 || (w103*w103 + e103*e103) == q103*q103){
                    Console.WriteLine("La 3 canh cua tam giac vuong");
                }else{
                    Console.WriteLine("Khong phai 3 canh cua tam giac vuong");
                }
            }else{
                Console.WriteLine("Khong phai 3 canh cua tam giac");
            }
            
        }
    }
}