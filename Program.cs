using System;

namespace Lab01
{
    class Student {
        private int ID;
        private string tenSV;
        private string Khoa;
        private float DiemTB;
        public Student() {
            ID = 1;
            tenSV = "Vo Tran Trung Anh";
            Khoa = "Cong nghe so";
            DiemTB = 8.5f;
        }
        public Student(Student stu) {
            ID = stu.ID;
            tenSV = stu.tenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public Student(int id, string ten, string kh, float dtb){
            ID = id;
            tenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        public int StudentID {
            get {
                return ID;
                }
            set {
                ID = value;
                }
        }
        public String Name {
            get {
                return tenSV;
                }
            set {
                tenSV = value;
                }
        }
        public String KhoaTruong {
            get {
                return Khoa;
                }
            set {
                Khoa = value;
                }
        }
        public float Diemtrungbinh {
            get {
                return DiemTB;
                }
            set {
                DiemTB = value;
                }
        }
        public void Show() {
            Console.WriteLine("Ma Sinh Vien: {0}", this.ID);
            Console.WriteLine("Ho va ten: {0}", this.tenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem trung binh: {0}", this.DiemTB);
        }

    }
    class Tester {
        public static void Main() {
            Student[] DSSV;
            int n;
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n]; // TAo mang n phan tu
            Console.WriteLine("Nhap danh sach sinh vien ");
            for (int i=1;i<=n;i++) {
                DSSV[i] = new Student();
                Console.Write("Nhap ma sinh vien thu " + i);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten sinh vien thu " + i);
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap ten khoa thu " + i);
                DSSV[i].KhoaTruong = Console.ReadLine();
                Console.Write("Nhap diem trung binh thu " + i);
                DSSV[i].Diemtrungbinh = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("=====================Xuat sinh vien==================");
            foreach(Student sv in DSSV)
                sv.Show();
            Console.ReadLine();
        }       
    }
}