using System;

namespace C_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "Pork Fried Rice (35  baht)", "Chicken Fried Rice (30 baht)", "Beef Fried Rice (45 baht)" };
            Console.WriteLine("*********Welcome to Vincenzo Room*********");///หน้าตาหน้าแรกของโปรแกรม
            Console.WriteLine("|-------------Menu Food------------------|");
            Console.WriteLine("|----1. {0} ----|", food[0]);////ดึงข้อมูลจากอาเรย์ของบนลงมาเพื่อแสดงรายการอาหารทั้ง 3 บรรทัด
            Console.WriteLine("|----2. {0} --|", food[1]);
            Console.WriteLine("|----3. {0} -----|", food[2]);
            Console.WriteLine("|----------------------------------------|");
            Console.Write("=====What you name...  ");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("=====Hello {0}", name);
            Console.WriteLine("--------------------------------");
            do/// ลูป
            {
                Console.WriteLine(" 1.Food 2.Exit");
                Console.WriteLine("--------------------------------");
                Console.Write("=====Select 1 or 2 : ");
                String select = Convert.ToString(Console.ReadLine());
                switch (select)
                {
                    case "1":/// เลือกข้อ 1 จากพาไปสู้fun ของการเลือกอาหารรร
                        Order foodSl = new Order();
                        foodSl.List();
                        break;

                    case "2":
                        ConTAcT showcontact = new ConTAcT();/// เลือกข้อ 2 จะไปFun contact
                        showcontact.CONTACT();
                        break;

                    default:
                        Console.WriteLine("=====You Select ONLY 1 OR 2 !!!");
                        continue;
                }
                break;
            }while(true);
        }
    }
    public class Order /// main code 
    {
        public int price = 0;
        public int paid = 0;
        public int ShowList = 0;///ตัวแปรต่างๆที่ใช้
        public int charge = 0;
        public int i = 0;
        public int o = 0;
        public int k = 0;
        public string Confirm = " ";
        public string[] food = { "Pork Fried Rice 35  baht", "Chicken Fried Rice 30 baht", "Beef Fried Rice 45 baht" };
        public void List()
        {
            int menufood1 = 35, menufood2 = 30, menufood3 = 45;
            int[] foodSel = new int[10];
            while(true)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Press 1 Choose food");
                Console.WriteLine("Press 2 Confirm Order and Del menu ");
                Console.WriteLine("Press 3 exit");
                Console.WriteLine("--------------------------------");
                Console.Write("=====Press : ");
                int menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)///เลือกสั่งอาหาร
                {
                    Console.Write("=====How many_food : ");
                    int smanyf = Convert.ToInt32(Console.ReadLine());
                    string[] array = new string[smanyf];
                    for (k = 0; k < array.Length; k++)///เพิ่มจำนวนอาหารตามที่พิมตามข้างบน
                    {
                        if (true)
                        {
                            Console.Write("=====Your Food Select : ", i + 1);
                            foodSel[i] = Convert.ToInt32(Console.ReadLine());
                            if (foodSel[i] == 1)
                            {
                                price += menufood1;///บวกราคาอหารตามที่เลือก
                            }
                            if (foodSel[i] == 2)
                            {
                                price += menufood2;
                            }
                            if (foodSel[i] == 3)
                            {
                                price += menufood3;
                            }
                            i++;
                        }
                    }
                }
                else if (menu == 2)///โชว์อาหารหรือลบรายการอาหารที่สั่ง
                {
                    for (o = 0; o < foodSel.Length; o++)
                    {                        
                        if (foodSel[o] >= 1)
                        {
                            Console.WriteLine(" \tALL Menu ");///โชว์รายการที่เลือกไปตามข้อที่ 1
                            for (ShowList = 0; ShowList < i; ShowList++)
                            {
                                if (foodSel[ShowList] == 1)///ถ้า foodSel มีข้อมูลอยู่จริงจะบอกว่ามีอะไรบ้าง
                                {
                                    Console.WriteLine("1. {0} ", food[0]);
                                }
                                if (foodSel[ShowList] == 2)
                                {
                                    Console.WriteLine("2. {0} ", food[1]);
                                }
                                if (foodSel[ShowList] == 3)
                                {
                                    Console.WriteLine("3. {0} ", food[2]);
                                }
                            }
                            Console.WriteLine("Cost {0} ", price);///แสดงราคาอาหาร
                            Console.Write("=====Confirm Order or Del Order Menu ( Y / D ) : ");///ต้องการสั่งอาหารหรือลบรายการอาหารทั้งหมด
                            Confirm = Convert.ToString(Console.ReadLine());
                            if (Confirm == "Y")
                            {
                                CalculatePrice();///ถ้าเลือกข้อนี่จะถูกส่งไปที่ fun calculate
                                break;
                            }
                            if (Confirm == "D")
                            {
                                price = 0;
                                List();/// ถ้าเลือกข้อนี้ List จะรีเซ็ตใหม่เหมือนเริ่มหน้าเมนูใหม่ทั้งหมด
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Your Input Y / D ONLY!!!");
                            }
                        }
                        if (foodSel[o] <= 0)
                        {
                            Console.WriteLine(" No food item in List");///ถ้าใน Lsit ไม่มีการสั่งอาหารจะมีคำนี้ขึ้นมา
                        }
                    }
                    if (Confirm == "Y")///ถ้าถูกเลือก Y จริงจะทำงานต่อตากบรรทัดที่ 125 เพื่อส่งไปfuncontact
                    {
                        if (paid >= price)///ถ้าเงินมากกว่าถึงจะส่งไปที่ contact
                        {
                            ConTAcT contact = new ConTAcT();
                            contact.CONTACT();
                            break;
                        }
                        if (price > paid) ///ถ้าเงินน้อยกว่าจะให้ทำคำสั่งใหม่
                        {
                            continue;
                        }
                    }                    
                }                
                else if (menu == 3)
                {
                    ConTAcT contact = new ConTAcT();
                    contact.CONTACT();///ส่งการไปfun ติดต่อ
                    break;
                }
                else
                {
                    Console.WriteLine("Please Selstion 1 , 2 and 3 ONLY!!!");///ถ้าเลือกนอกเหนือที่บอกให้เหลือ
                }
            } 
        }
        public void CalculatePrice() ///fun การคำนวณเงิน
        {
            Console.WriteLine("--------------------------------");
            Console.Write("===== You paid : ");/// รับค่าที่ลูกค้าใส่จำนวนเงินเข้ามา
            paid = Convert.ToInt32(Console.ReadLine());
            charge = paid - price; /// นำค่าจากที่ลูกกรอกดข้ามาเอาลบกับรายการอาหาร
            if (paid >= price)
            {
                Console.WriteLine("Your charge {0} baht ", charge);///นำเงินมาคำนวณเป็นตังแต่บาทกัน
                Console.WriteLine("You get {0} one hundreds banknotes", charge / 100);
                Console.WriteLine("You get {0} fifty banknotes", charge % 100 / 50);
                Console.WriteLine("You get {0} twenty banknotes", charge % 100 % 50 / 20);
                Console.WriteLine("You get {0} ten coins", charge % 100 % 50 % 20 / 10);
                Console.WriteLine("You get {0} one coins", charge % 100 % 50 % 20 % 10 / 1);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("--------Thanks for buy----------");                
            }
            if (price > paid)
            {
                Console.WriteLine("Money low");///กรณีที่เงินที่ลูกค้าน้อยกว่าราคาอาหาร
            }
        }
    }
    public class ConTAcT
    {
        public void CONTACT()///fun การติดต่อ
        {
            while (true)
            {
                Console.WriteLine("--------------------------------");
                Console.Write("=====More contact ( Y / N ) : ");///ให้เลือกระหว่าง Y/N
                string contact = Convert.ToString(Console.ReadLine());

                switch (contact)
                {
                    case "Y":///ถ้า Y จะตอบกลับข้อมูลการติดต่อให้
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Facebook : Vincenzo Room");
                        Console.WriteLine("Instagram: Vincenzo Room");
                        Console.WriteLine("*********See You Again**********");
                        Console.WriteLine("********************************");
                        break;
                    case "N":///ถ้า ื จะตอบด้วยข้อความสั้นๆ
                        Console.WriteLine("*********See You Again**********");
                        Console.WriteLine("********************************");
                        break;
                    default:
                        Console.WriteLine("Select Y / N ONLY");///ถ้าไม่เลือก Y/N จะขึ้นให้เลือกแบบนี้
                        continue;
                }
                break;
            }
        }
    }
}
