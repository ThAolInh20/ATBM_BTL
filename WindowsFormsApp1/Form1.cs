using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;
using LanguageExt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Collections.Specialized;
using System.Xml.Linq;
using System.Reflection.Metadata;
using Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public BigInteger s, r, v, decNumm,p, q, g, Y, X;

        private string inputdata,inputdata1, inputdata2;
      
        //tính a^exp mod mod
        public static BigInteger power(BigInteger a, BigInteger k, BigInteger q)
        {
            BigInteger result = 1;
            while (k > 0)
            {
                if ((k & 1) != 0)
                {
                    result = (result * a) % q;
                }
                a = (a * a) % q;
                k >>= 1;
            }
            return result;
        }
        //tinh m^-1mod n
        public static BigInteger ModInverse(BigInteger a, BigInteger q)
        {
            BigInteger s = 0, t = 1, r = q, oldS = 1, oldT = 0, oldR = a;

            while (r != 0)
            {
                BigInteger quotient = oldR / r;

                BigInteger temp = r;
                r = oldR - quotient * r;
                oldR = temp;

                temp = s;
                s = oldS - quotient * s;
                oldS = temp;

                temp = t;
                t = oldT - quotient * t;
                oldT = temp;
            }

            BigInteger gcd = oldR;
            BigInteger inverse = oldS % q;

            if (inverse < 0)
            {
                inverse += q;
            }

            return inverse;
        }
        //tinh he so chia 2
        static private BigInteger[] heSo(BigInteger n)
        {
            long s = 0;
            while ((n & 1) == 0)
            {
                s++;
                n >>= 1;
            }
            return new BigInteger[] { s, n };
        }
        //kiểm tra so nt
        static private bool checkMillerRabin(BigInteger s, BigInteger d, BigInteger n, BigInteger a)
        {
            if (n == a) return true;
            var p = power(a, d, n);
            if (p == 1) return true;
            while (s > 0)
            {
                if (p == n - 1) return true;
                p = p * p % n;
                s--;
            }
            return false;
        }

        private static bool KiemTraSoNguyenTo(BigInteger n)
        {
            if (n < 2) return false;
            if ((n & 1) == 0) return n == 2;
            var heso = heSo(n - 1);
            var s = heso[0];
            var d = heso[1];
            long[] ran = { 2, 3, 5, 7, 23, 11, 17, 61 };
            bool laSoNT = true;
            foreach (long e in ran)
            {
                if (checkMillerRabin(s, d, n, e) == false) //\thuật toán ktra số nguyên tố cho những số lớn
                    laSoNT = false;
            }
            return laSoNT;
        }

        private void taokhoa()
        {  
                string p1, q1,g1,X1,Y1;
                p1 = "C667DEF373B2362971945721D8EF0FA5DF1D509C8098EAB51D9B29F4239B99F48B84F0A691B26F54FAEA145DCF1B63F7138EE2917AFEB1393E4297F471CF683BB691C612754D622DF38687644DB046CB712F4FAD01564BB665145421235FF90725FD5213E7764D2074E97DF79D4DF58D1DF7EF6C962B63CA9B0DE231977A9B83";
                q1 = "98CFCCB04287DDD931CB31314DA0DA8702DF3521";
                g1 = "52D54BF2A17708C402D52F5A40C7565EE62CA48B62AAE1B9CB1ACE47E3BE228F44EF303F598F97D56E8C3EC9487E3B1F913036030E404672317E8350F8D98D291F30ECE2D916F401914A8C5023D9D88FED209B5BBC0E5E668AB42587C3F0EF4F0BA879BDCC188B97DAC6CE2D1FB8C91F72F0AA9B7AE3C7E10BE0DD5751FE7103";
                X1 = "014099CE8CE21AA3715531285BE21E09FF49ED8B";
                Y1 = "52B4721932745ED10A06328FD140F2E5F02BC76E0662700A78CBA28814061C4E38E48CBE593B1C09F1D1FB3B48B579EB05F261AFF268580B7FC433B3E49FFBA84D1DF4FC1F8FC841EB18452754881BDD5ACFEE8BCECA39E798399D466C43B687A6003F989615CD15032B5181C7B6EBE49D92BFE96B2BB8A06A849F1FDAFDC74B";
                p = BigInteger.Parse(p1, System.Globalization.NumberStyles.HexNumber);
                g = BigInteger.Parse(g1, System.Globalization.NumberStyles.HexNumber);
                q = BigInteger.Parse(q1, System.Globalization.NumberStyles.HexNumber);
                X = BigInteger.Parse(Y1, System.Globalization.NumberStyles.HexNumber);
                Y = BigInteger.Parse(X1, System.Globalization.NumberStyles.HexNumber);
                if (p < 0)
                {
                    p = -p;
                }
                if (q < 0)
                { 
                    q=-q;
                }      
                if (g < 0)
                {
                    g = -g;
                }
                if (X < 0) 
                { 
                    X = -X;
                }
                if (Y < 0) 
                {
                    Y = -Y; 
                }; 
            
        }

        //reset khoa
        private void reset_khoa()
        {
            p = 0;
            q = 0;
            g = 0;
            X = 0;
            Y = 0;
        }


        //ham bam SHA_1
        public string SHA1hash(string input)
        {
            // Chuyển đổi chuỗi đầu vào thành một mảng byte
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);

            // Khởi tạo các biến ban đầu
            uint h0 = 0x67452301;
            uint h1 = 0xEFCDAB89;
            uint h2 = 0x98BADCFE;
            uint h3 = 0x10325476;
            uint h4 = 0xC3D2E1F0;

            // Tính toán độ dài của chuỗi đầu vào (theo byte)
            long messageLength = inputBytes.Length * 8;

            // Thêm bit đầu tiên là 1 và các bit 0 tới khi độ dài của chuỗi mới là một bội số của 512 bit
            int numberOfZeroBytes = ((448 - inputBytes.Length - 1) % 64 + 64) % 64;
            byte[] paddedInput = new byte[inputBytes.Length + 1 + numberOfZeroBytes + 8];
            Array.Copy(inputBytes, 0, paddedInput, 0, inputBytes.Length);
            paddedInput[inputBytes.Length] = 0x80;
            for (int i = 0; i < numberOfZeroBytes; i++)
            {
                paddedInput[inputBytes.Length + 1 + i] = 0x00;
            }

            // Thêm độ dài của chuỗi đầu vào (theo bit) vào cuối chuỗi
            byte[] messageLengthBytes = BitConverter.GetBytes((ulong)messageLength);
            Array.Reverse(messageLengthBytes);
            Array.Copy(messageLengthBytes, 0, paddedInput, paddedInput.Length - 8, 8);

            // Tính toán các từ của khối tin
            uint[] words = new uint[paddedInput.Length / 4];
            for (int i = 0; i < paddedInput.Length / 4; i++)
            {
                byte[] temp = new byte[4];
                Array.Copy(paddedInput, i * 4, temp, 0, 4);
                Array.Reverse(temp);
                words[i] = BitConverter.ToUInt32(temp, 0);
            }

            // Tính toán giá trị băm
            for (int i = 0; i < words.Length; i += 16)
            {
                uint[] block = new uint[80];
                Array.Copy(words, i, block, 0, 16);

                for (int j = 16; j < 80; j++)
                {
                    uint temp = block[j - 3] ^ block[j - 8] ^ block[j - 14] ^ block[j - 16];
                    block[j] = (temp << 1) | (temp >> 31);
                }

                uint a = h0;
                uint b = h1;
                uint c = h2;
                uint d = h3;
                uint e = h4;

                for (int j = 0; j < 80; j++)
                {
                    uint f, k;
                    if (j < 20)
                    {
                        f = (b & c) | ((~b) & d);
                        k = 0x5A827999;
                    }
                    else if (j < 40)
                    {
                        f = b ^ c ^ d;
                        k = 0x6ED9EBA1;
                    }
                    else if (j < 60)
                    {
                        f = (b & c) | (b & d) | (c & d);
                        k = 0x8F1BBCDC;
                    }
                    else
                    {
                        f = b ^ c ^ d;
                        k = 0xCA62C1D6;
                    }

                    uint temp = ((a << 5) | (a >> 27)) + f + e + k + block[j];
                    e = d;
                    d = c;
                    c = (b << 30) | (b >> 2);
                    b = a;
                    a = temp;
                }

                h0 += a;
                h1 += b;
                h2 += c;
                h3 += d;
                h4 += e;
            }
            // Chuyển đổi giá trị băm từ các biến uint sang chuỗi hex
            StringBuilder sb = new StringBuilder();
            sb.Append(h0.ToString("x8"));
            sb.Append(h1.ToString("x8"));
            sb.Append(h2.ToString("x8"));
            sb.Append(h3.ToString("x8"));
            sb.Append(h4.ToString("x8"));
            return sb.ToString();
        }
        
        
        //tao chu kí
        private void chuki(string m)
        {
            taokhoa();
  
            // Tính giá trị r
            BigInteger k = 37;
            r = BigInteger.ModPow(g, k, p) % q;
            if (r < 0)
            {
                r = -r;
            }
            // Tính giá trị của băm SHA-1 của chuỗi m
            decNumm = BigInteger.Parse(SHA1hash(m), System.Globalization.NumberStyles.HexNumber);
            if(decNumm < 0)
            {
                decNumm=-decNumm;
            }
            BigInteger s1=ModInverse(k, q);//tính k^-1 mod q
            BigInteger s2 = (decNumm + X * r) % q;
            s = (s1*s2)%q ;      
        }


        //kiem tra chu ki
        private void ktra_chuky(string m)
        {
            BigInteger w = ModInverse(s, q);
            BigInteger u1 = ((decNumm % q) * (w % q)) % q;
            BigInteger u2 = (r * w) % q;
            BigInteger v1 = power(g, u1, p);
            BigInteger v2 = power(Y, u2, p);
            v = ((v1 * v2) % p) % q;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Microsoft Word Documents (*.docx)|*.docx";
            openFileDialog.Title = "Select a file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                // Call method to read the selected file and display the content in the text box
                txt1.Text = DisplayFileContent(selectedFileName);
            }
            
        }
       
        private void Ky_Click(object sender, EventArgs e)
        {
            
            string input = txt1.Text;
            if (txt1.Text == "")
            {
                reset_khoa();
                MessageBox.Show("moi nhap van ban");
            }
            else
            {
                taokhoa();
                chuki(input);
                
                txt2.Text =r.ToString() + "-" + s.ToString();
            }
            

        }
        public string SHA1Hash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                StringBuilder hexBuilder = new StringBuilder(hashBytes.Length * 2);
                foreach (byte b in hashBytes)
                {
                    hexBuilder.Append(b.ToString("x2"));
                }
                return hexBuilder.ToString();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Filevanban_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string data = System.IO.File.ReadAllText(openFileDialog.FileName);
                txt3.Text= data;
            }
        }

        private void Filechuky_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string data = System.IO.File.ReadAllText(openFileDialog.FileName);
                txt4.Text = data;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            inputdata1 = txt4.Text;
        }

        private void Chuyen_Click(object sender, EventArgs e)
        {
            txt3.Text = inputdata;
            txt4.Text = txt2.Text;
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            // Lấy chuỗi cần lưu từ TextBox hoặc từ biến khác
            string data = txt2.Text;
            // Tạo đường dẫn cho file
            string path = @"E:\NguyenPhuongNam_nhom7\chuky.txt";
            // Lưu chuỗi vào file
            System.IO.File.WriteAllText(path, data);

            MessageBox.Show("Lưu file thành công!");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
 
            private void button7_Click(object sender, EventArgs e)
        {
            string thongbao;
            string input1, input2="";
            input1 = txt4.Text;
            if (txt3.Text == "")
            {
                reset_khoa();
                MessageBox.Show("moi nhap van ban");
            }
            else
            {
                taokhoa();
                chuki(inputdata2);

                input2 = r.ToString() + "-" + s.ToString();
            }
            if (string.Compare(input1, input2)==0)
                {
                    thongbao = "chu ki dung!";
                }
            else
                {
                    thongbao = "chu ki sai!";
                }
            txt5.Text = thongbao;
              
        }
        private string DisplayFileContent(string fileName)
        {
            string k= "";
            if (Path.GetExtension(fileName) == ".txt")
            {
                // Read the content of the text file
                string content = System.IO.File.ReadAllText(fileName);

                // Display the content in the text box
                k = content;
            }
            else if (Path.GetExtension(fileName) == ".docx")
            {
                // Create an instance of Word Application
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                // Open the Word document
                Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Open(fileName);

                // Read the content of the Word document
                string content = wordDoc.Content.Text;

                // Close the Word document and the Word Application
                wordDoc.Close();
                wordApp.Quit();

                // Set the content to the Textbox
                k = content;   
            }
            return k;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            inputdata = txt1.Text;
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txt2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            inputdata2= txt3.Text;
        }
    }
}
