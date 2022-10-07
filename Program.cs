using System;

namespace InterfaceKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Uygulamasına Hoşgeldiniz....");

            

            

            while (true)
            {
                Console.WriteLine("1- Yayılımcı İşlemleri");
                Console.WriteLine("2- Yönetici İşlemleri");
                Console.WriteLine("3- Çıkış için q' ya basınız. ");
                string secilenİslem = Console.ReadLine();
                if (secilenİslem== "q")
                {
                    Console.WriteLine("Programdan Çıkılıyor...");
                    break;
                }
                else if (secilenİslem== "1")
                {
                   
                    while (true)
                    {
                        Yazilimci yazilimci = new Yazilimci(1, "Enes", "Bayram", "Java , C# , C++");
                        Console.WriteLine("Yazılımcı İşlemi seçiniz : ");
                        Console.WriteLine("1- Format at : ");
                        Console.WriteLine("2- Yazılımcının Bilgilerini Göster : ");
                        Console.WriteLine("3- Çıkış için q'ya basınız ");
                        string yazilimciİslem = Console.ReadLine();

                        if (yazilimciİslem=="q")
                        {
                            Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor..");
                            break;
                        }
                        else if (yazilimciİslem=="1")
                        {
                            Console.WriteLine("İşletim Sistemi giriniz: ");
                            string isletimSistemi = Console.ReadLine();
                            yazilimci.formatAt(isletimSistemi);
                        }
                        else if (yazilimciİslem=="2")
                        {
                            yazilimci.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli bir işlem giriniz...");
                        }
                    }

                }
                else if (secilenİslem =="2")
                {
                    
                    while (true)
                    {
                        Yonetici yonetici = new Yonetici(2, "Türkay", "Yıldız", 55);
                        Console.WriteLine("Yönetici İşlemi seçiniz : ");
                        Console.WriteLine("1- Zam yap : ");
                        Console.WriteLine("2- Yöneticinin bilgilerini göster : ");
                        Console.WriteLine("3- Çıkış için q'ya basınız ");
                        string Yoneticiİslem = Console.ReadLine();

                        if (Yoneticiİslem=="q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor..");
                            break;
                        }
                        else if (Yoneticiİslem=="1")
                        {
                            Console.WriteLine("Zam Miktarını giriniz : ");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());

                            yonetici.zamYap(zamMiktari);
                        }
                        else if (Yoneticiİslem=="2")
                        {
                            yonetici.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem yapınız.");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Lütfen geçerli birşey gir...");
                }


            }
        }
    }
}
