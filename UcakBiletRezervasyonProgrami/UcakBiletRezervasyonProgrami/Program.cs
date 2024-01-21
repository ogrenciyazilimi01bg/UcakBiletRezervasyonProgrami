using UcakBiletRezervasyonProgrami;
using System;


namespace UcakBiletRezervasyonProgrami
{
    class GirisEkrani
    {

        public static string SehirK;
        public static string tarihY;
        public static string tarihM;
        public static string tarihD;
        public static int biletAdeti;
        public static int LokasyonNumarası;
        public static string KoltukNo;
        static void Main(string[] agrs)
        {

            string ProgramaGirisTarihi = ("Tarih :" + DateTime.Now);
            Console.WriteLine("                               * Princess Dream Airlines HOŞGELDİNİZ *           " + ProgramaGirisTarihi);
            Console.WriteLine("        Aşağıdaki Lokasyonlardan birini Seçiniz.");
            Console.WriteLine("");

            var SeyehatSuresiK = 0;
            var UcusSaatiK = "";
            var SeriNoK = "";


            Lokasyon Lokasyon1 = new Lokasyon();
            Lokasyon1.id = 1;
            Lokasyon1.sehir = " İstanbul - İzmir            ";
            Lokasyon1.ulke = "           Türkiye   ";
            Lokasyon1.seyehatSuresi = 70;
            Lokasyon1.havaalani = "İstanbul Sabiha Gökçen Havalimanı - İzmir Adnan Menderes Havalimanı ";
            Lokasyon1.aktifPasif = true;

            Lokasyon Lokasyon2 = new Lokasyon();
            Lokasyon2.id = 2;
            Lokasyon2.sehir = " İstanbul - Ankara            ";
            Lokasyon2.ulke = "           Türkiye   ";
            Lokasyon2.seyehatSuresi = 65;
            Lokasyon2.havaalani = "İstanbul Sabiha Gökçen Havalimanı - Ankara Esenboğa Havalimanı ";
            Lokasyon2.aktifPasif = true;

            Lokasyon Lokasyon3 = new Lokasyon();
            Lokasyon3.id = 3;
            Lokasyon3.sehir = " İzmir - Ankara    ";
            Lokasyon3.ulke = "           Türkiye   ";
            Lokasyon3.seyehatSuresi = 70;
            Lokasyon3.havaalani = "İzmir Adnan Menderes Havalimanı - Ankara Esenboğa Havalimanı ";
            Lokasyon3.aktifPasif = true;



            Ucak Ucak1 = new Ucak();
            Ucak1.id = 1;
            Ucak1.ucakModel = " 707     ";
            Ucak1.ucakMarkasi = "Boeing";
            Ucak1.seriNo = "ABC554";
            Ucak1.koltukKapasitesi = 120;


            Ucak Ucak2 = new Ucak();
            Ucak2.id = 2;
            Ucak2.ucakModel = " 707    ";
            Ucak2.ucakMarkasi = "Boeing";
            Ucak2.seriNo = "AGD546";
            Ucak2.koltukKapasitesi = 120;

            Ucak Ucak3 = new Ucak();
            Ucak3.id = 3;
            Ucak3.ucakModel = " 707    ";
            Ucak3.ucakMarkasi = "Boeing";
            Ucak3.seriNo = "ABC";
            Ucak3.koltukKapasitesi = 120;



            Ucus Ucus1 = new Ucus();
            Ucus1.id = 1;
            Ucus1.Lokasyon = (Lokasyon1);
            Ucus1.Ucak = (Ucak1);
            Ucus1.saat = "14:00";
            Ucus1.tarih = DateTime.Now;

            Ucus Ucus2 = new Ucus();
            Ucus2.id = 2;
            Ucus2.Lokasyon = (Lokasyon1);
            Ucus2.Ucak = (Ucak1);
            Ucus2.saat = "18:00";



            Ucus Ucus3 = new Ucus();
            Ucus3.id = 3;
            Ucus3.Lokasyon = (Lokasyon1);
            Ucus3.Ucak = (Ucak1);
            Ucus3.saat = "20:30";

            Ucus Ucus4 = new Ucus();
            Ucus4.id = 4;
            Ucus4.Lokasyon = (Lokasyon1);
            Ucus4.Ucak = (Ucak1);
            Ucus4.saat = "22:40";

            Ucus Ucus5 = new Ucus();
            Ucus5.id = 5;
            Ucus5.Lokasyon = (Lokasyon2);
            Ucus5.Ucak = (Ucak2);
            Ucus5.saat = "14:00";


            Ucus Ucus6 = new Ucus();
            Ucus6.id = 6;
            Ucus6.Lokasyon = (Lokasyon2);
            Ucus6.Ucak = (Ucak2);
            Ucus6.saat = "18:00";


            Ucus Ucus7 = new Ucus();
            Ucus7.id = 7;
            Ucus7.Lokasyon = (Lokasyon2);
            Ucus7.Ucak = (Ucak2);
            Ucus7.saat = "20:30";

            Ucus Ucus8 = new Ucus();
            Ucus8.id = 8;
            Ucus8.Lokasyon = (Lokasyon2);
            Ucus8.Ucak = (Ucak2);
            Ucus8.saat = "22:40";

            Ucus Ucus9 = new Ucus();
            Ucus9.id = 9;
            Ucus9.Lokasyon = (Lokasyon3);
            Ucus9.Ucak = (Ucak3);
            Ucus9.saat = "14:00";


            Ucus Ucus10 = new Ucus();
            Ucus10.id = 10;
            Ucus10.Lokasyon = (Lokasyon3);
            Ucus10.Ucak = (Ucak3);
            Ucus10.saat = "18:00";


            Ucus Ucus11 = new Ucus();
            Ucus11.id = 11;
            Ucus11.Lokasyon = (Lokasyon3);
            Ucus11.Ucak = (Ucak3);
            Ucus11.saat = "20:30";

            Ucus Ucus12 = new Ucus();
            Ucus12.id = 12;
            Ucus12.Lokasyon = (Lokasyon3);
            Ucus12.Ucak = (Ucak3);
            Ucus12.saat = "22:40";







            Rezervasyon Rezervasyon1 = new Rezervasyon();
            Rezervasyon1.Ucus = (Ucus1);
            Rezervasyon1.koltukNo = (KoltukNo);
            Rezervasyon1.biletAdeti = (biletAdeti);



            Rezervasyon Rezervasyon2 = new Rezervasyon();
            Rezervasyon2.Ucus = (Ucus2);


            Rezervasyon Rezervasyon3 = new Rezervasyon();
            Rezervasyon3.Ucus = (Ucus3);

            Rezervasyon Rezervasyon4 = new Rezervasyon();
            Rezervasyon4.Ucus = (Ucus4);

            Rezervasyon Rezervasyon5 = new Rezervasyon();
            Rezervasyon5.Ucus = (Ucus5);

            Rezervasyon Rezervasyon6 = new Rezervasyon();
            Rezervasyon6.Ucus = (Ucus6);

            Rezervasyon Rezervasyon7 = new Rezervasyon();
            Rezervasyon7.Ucus = (Ucus7);

            Rezervasyon Rezervasyon8 = new Rezervasyon();
            Rezervasyon8.Ucus = (Ucus8);

            Rezervasyon Rezervasyon9 = new Rezervasyon();
            Rezervasyon9.Ucus = (Ucus9);


            Rezervasyon Rezervasyon10 = new Rezervasyon();
            Rezervasyon10.Ucus = (Ucus10);

            Rezervasyon Rezervasyon11 = new Rezervasyon();
            Rezervasyon11.Ucus = (Ucus11);


            Rezervasyon Rezervasyon12 = new Rezervasyon();
            Rezervasyon12.Ucus = (Ucus12);

            Bilgi Bilgi1 = new Bilgi();
            Bilgi1.biletFiyatı = 500;
            Bilgi1.Rezervasyon = (Rezervasyon1);

            Bilgi Bilgi2 = new Bilgi();
            Bilgi2.biletFiyatı = 500;
            Bilgi2.Rezervasyon = (Rezervasyon2);

            Bilgi Bilgi3 = new Bilgi();
            Bilgi3.biletFiyatı = 500;
            Bilgi3.Rezervasyon = (Rezervasyon3);

            Bilgi Bilgi4 = new Bilgi();
            Bilgi4.biletFiyatı = 500;
            Bilgi4.Rezervasyon = (Rezervasyon4);

            Bilgi Bilgi5 = new Bilgi();
            Bilgi5.biletFiyatı = 500;
            Bilgi5.Rezervasyon = (Rezervasyon5);



            Bilgi Bilgi6 = new Bilgi();
            Bilgi6.biletFiyatı = 500;
            Bilgi6.Rezervasyon = (Rezervasyon6);

            Bilgi Bilgi7 = new Bilgi();
            Bilgi7.biletFiyatı = 500;
            Bilgi7.Rezervasyon = (Rezervasyon7);

            Bilgi Bilgi8 = new Bilgi();
            Bilgi8.biletFiyatı = 500;
            Bilgi8.Rezervasyon = (Rezervasyon8);

            Bilgi Bilgi9 = new Bilgi();
            Bilgi9.biletFiyatı = 500;
            Bilgi9.Rezervasyon = (Rezervasyon9);


            Bilgi Bilgi10 = new Bilgi();
            Bilgi10.biletFiyatı = 500;
            Bilgi10.Rezervasyon = (Rezervasyon10);

            Bilgi Bilgi11 = new Bilgi();
            Bilgi11.biletFiyatı = 500;
            Bilgi11.Rezervasyon = (Rezervasyon11);

            Bilgi Bilgi12 = new Bilgi();
            Bilgi12.biletFiyatı = 500;
            Bilgi12.Rezervasyon = (Rezervasyon12);


            try
            {
                // Ucak.csv dosyasının oluşturulması ve verilerin yazılması
                using (StreamWriter sw = new StreamWriter("Ucak.csv"))
                {
                    sw.WriteLine("id,ucakModel,ucakMarkasi,seriNo,koltukKapasitesi");
                    sw.WriteLine($"{Ucak1.id},{Ucak1.ucakModel},{Ucak1.ucakMarkasi},{Ucak1.seriNo},{Ucak1.koltukKapasitesi}");
                    sw.WriteLine($"{Ucak2.id},{Ucak2.ucakModel},{Ucak2.ucakMarkasi},{Ucak2.seriNo},{Ucak2.koltukKapasitesi}");
                    sw.WriteLine($"{Ucak3.id},{Ucak3.ucakModel},{Ucak3.ucakMarkasi},{Ucak3.seriNo},{Ucak3.koltukKapasitesi}");
                }

                // Lokasyon.csv dosyasının oluşturulması ve verilerin yazılması
                using (StreamWriter sw = new StreamWriter("Lokasyon.csv"))
                {
                    sw.WriteLine("id,sehir,ulke,seyehatSuresi,havaalani,aktifPasif");
                    sw.WriteLine($"{Lokasyon1.id},{Lokasyon1.sehir},{Lokasyon1.ulke},{Lokasyon1.seyehatSuresi},{Lokasyon1.havaalani},{Lokasyon1.aktifPasif}");
                    sw.WriteLine($"{Lokasyon2.id},{Lokasyon2.sehir},{Lokasyon2.ulke},{Lokasyon2.seyehatSuresi},{Lokasyon2.havaalani},{Lokasyon2.aktifPasif}");
                    sw.WriteLine($"{Lokasyon3.id},{Lokasyon3.sehir},{Lokasyon3.ulke},{Lokasyon3.seyehatSuresi},{Lokasyon3.havaalani},{Lokasyon3.aktifPasif}");
                }

                // Ucus.csv dosyasının oluşturulması ve verilerin yazılması
                using (StreamWriter sw = new StreamWriter("Ucus.csv"))
                {
                    sw.WriteLine("id,Lokasyon,Ucak,Saat");
                    sw.WriteLine($"{Ucus1.id},{Ucus1.Lokasyon},{Ucus1.Ucak},{Ucus1.saat}");
                    sw.WriteLine($"{Ucus2.id},{Ucus2.Lokasyon},{Ucus2.Ucak},{Ucus2.saat}");
                    sw.WriteLine($"{Ucus3.id},{Ucus3.Lokasyon},{Ucus3.Ucak},{Ucus3.saat}");
                    sw.WriteLine($"{Ucus4.id},{Ucus4.Lokasyon},{Ucus4.Ucak},{Ucus4.saat}");
                    sw.WriteLine($"{Ucus5.id},{Ucus5.Lokasyon},{Ucus5.Ucak},{Ucus5.saat}");
                    sw.WriteLine($"{Ucus6.id},{Ucus6.Lokasyon},{Ucus6.Ucak},{Ucus6.saat}");
                    sw.WriteLine($"{Ucus7.id},{Ucus7.Lokasyon},{Ucus7.Ucak},{Ucus7.saat}");
                    sw.WriteLine($"{Ucus8.id},{Ucus8.Lokasyon},{Ucus8.Ucak},{Ucus8.saat}");
                    sw.WriteLine($"{Ucus9.id},{Ucus9.Lokasyon},{Ucus9.Ucak},{Ucus9.saat}");
                    sw.WriteLine($"{Ucus10.id},{Ucus10.Lokasyon},{Ucus10.Ucak},{Ucus10.saat}");
                    sw.WriteLine($"{Ucus11.id},{Ucus11.Lokasyon},{Ucus11.Ucak},{Ucus11.saat}");
                    sw.WriteLine($"{Ucus12.id},{Ucus12.Lokasyon},{Ucus12.Ucak},{Ucus12.saat}");
                }
                using (StreamWriter sw = new StreamWriter("Bilgi.csv"))
                {
                    sw.WriteLine("Bilet Fiyatı,Rezervasyon Bilgisi");
                    sw.WriteLine($"{Bilgi1.biletFiyatı},{Bilgi1.Rezervasyon}");
                    sw.WriteLine($"{Bilgi2.biletFiyatı},{Bilgi2.Rezervasyon}");
                    sw.WriteLine($"{Bilgi3.biletFiyatı},{Bilgi3.Rezervasyon}");
                    sw.WriteLine($"{Bilgi4.biletFiyatı},{Bilgi4.Rezervasyon}");
                    sw.WriteLine($"{Bilgi5.biletFiyatı},{Bilgi5.Rezervasyon}");
                    sw.WriteLine($"{Bilgi6.biletFiyatı},{Bilgi6.Rezervasyon}");
                    sw.WriteLine($"{Bilgi7.biletFiyatı},{Bilgi7.Rezervasyon}");
                    sw.WriteLine($"{Bilgi8.biletFiyatı},{Bilgi8.Rezervasyon}");
                    sw.WriteLine($"{Bilgi9.biletFiyatı},{Bilgi9.Rezervasyon}");
                    sw.WriteLine($"{Bilgi10.biletFiyatı},{Bilgi10.Rezervasyon}");
                    sw.WriteLine($"{Bilgi11.biletFiyatı},{Bilgi11.Rezervasyon}");
                    sw.WriteLine($"{Bilgi12.biletFiyatı},{Bilgi12.Rezervasyon}");
                }



            }
            catch (Exception e)
            {
                Console.WriteLine($"Hata: {e.Message}");
            }

            static int GetLastReservationId()
            {
                int lastId = 0;

                try
                {
                    using (StreamReader sr = new StreamReader("Rezervasyon.csv"))
                    {
                        string lastLine = null;
                        while ((lastLine = sr.ReadLine()) != null)
                        {
                            // Dosyanın son satırını bul
                            // Satır formatı: id,ucus,musteriAdiSoyadi,musteriCepTelefonu,yas,biletAdeti,koltukNo
                            string[] parts = lastLine.Split(',');
                            if (parts.Length > 0)
                            {
                                lastId = int.Parse(parts[0]);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Hata: {e.Message}");
                }

                return lastId;
            }
            // Burdaki kodda Lokasyon bilgileri veriliyor
            Console.WriteLine("\t" + "Kalkış - Varış");
            Console.WriteLine(Lokasyon1.id + ")" + Lokasyon1.sehir + "" + Lokasyon1.ulke + "" + Lokasyon1.havaalani + "Uçuş süresi:" + Lokasyon1.seyehatSuresi + "Dk" + "  " + "Uçuş aktif mi:" + Lokasyon1.aktifPasif);
            Console.WriteLine(Lokasyon2.id + ")" + Lokasyon2.sehir + "" + Lokasyon2.ulke + "   " + Lokasyon2.havaalani + " Uçuş süresi:" + Lokasyon2.seyehatSuresi + "Dk" + "  " + "Uçuş aktif mi:" + Lokasyon2.aktifPasif);
            Console.WriteLine(Lokasyon3.id + ")" + Lokasyon3.sehir + "" + Lokasyon3.ulke + "   " + Lokasyon3.havaalani + "             " + " Uçuş süresi:" + Lokasyon3.seyehatSuresi + "Dk" + "  " + "Uçuş aktif mi:" + Lokasyon3.aktifPasif);

            //Lokasyon numarası isteniyor burdaki kodda ve o numara da lokasyon varsa o lokasyon ile ilgili bilgiler yazıyor.Yoksa o numarada lokasyon tekrar numara girmesi isteniyor.
            while (true)
            {

                Console.WriteLine("Tercih edilen lokasyon numarasını giriniz ");
                LokasyonNumarası = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (LokasyonNumarası == 1)
                {
                    Console.WriteLine("Seçilen Lokasyon:" + Lokasyon1.sehir + Lokasyon1.ulke + Lokasyon1.havaalani + "Uçuş süresi:" + Lokasyon1.seyehatSuresi + "Dk" + "  " + "Uçuş aktif mi:" + Lokasyon1.aktifPasif);
                    Console.WriteLine("SeriNo:" + Ucak1.seriNo + "  " + "Modeli:" + Ucak1.ucakMarkasi + Ucak1.ucakModel + "  " + "Uçak Kapasitesi:" + Ucak1.koltukKapasitesi);
                    SehirK = Lokasyon1.sehir;
                    SeyehatSuresiK = Lokasyon1.seyehatSuresi;
                    SeriNoK = Ucak1.seriNo;
                    break;
                }

                else if (LokasyonNumarası == 2)
                {
                    Console.WriteLine("Seçilen Lokasyon:" + Lokasyon2.sehir + Lokasyon2.ulke + Lokasyon2.havaalani + "Uçuş süresi:" + Lokasyon2.seyehatSuresi + "Dk" + "  " + "Uçuş aktif mi:" + Lokasyon2.aktifPasif);
                    Console.WriteLine("SeriNo:" + Ucak2.seriNo + "  " + "Modeli:" + Ucak2.ucakMarkasi + Ucak2.ucakModel + "  " + "Uçak Kapasitesi:" + Ucak2.koltukKapasitesi);
                    SehirK = Lokasyon2.sehir;
                    SeyehatSuresiK = Lokasyon2.seyehatSuresi;
                    SeriNoK = Ucak2.seriNo;
                    break;
                }

                else if (LokasyonNumarası == 3)
                {
                    Console.WriteLine("Seçilen Lokasyon:" + Lokasyon3.sehir + Lokasyon3.ulke + Lokasyon3.havaalani + "Uçuş süresi:" + Lokasyon3.seyehatSuresi + "Dk" + "  " + "Uçuş aktif mi:" + Lokasyon3.aktifPasif);
                    Console.WriteLine("SeriNo:" + Ucak3.seriNo + "  " + "Modeli:" + Ucak3.ucakMarkasi + Ucak3.ucakModel + "  " + "Uçak Kapasitesi:" + Ucak3.koltukKapasitesi);
                    SehirK = Lokasyon3.sehir;
                    SeyehatSuresiK = Lokasyon3.seyehatSuresi;
                    SeriNoK = Ucak3.seriNo;
                    break;
                }


                else
                {
                    Console.WriteLine("Böyle bir lokasyon yok, tekrar deneyin");
                    continue;
                }
            }

            //Bilet tarihi seçimi yapılması isteniyor bu kodda.Başka bir günü  seçerse o günü yazması isteniyor.
            Console.WriteLine("            ");
            Console.WriteLine("Bilet tarihi Seçiniz");
            Console.WriteLine("1)" + Ucus1.tarih.Day + "." + Ucus1.tarih.Month + "." + Ucus1.tarih.Year);
            Console.WriteLine("2)Başka bir gün için tarih seçiniz ");
            Console.WriteLine("            ");


            Console.WriteLine("            ");
            int UcusSecin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("         ");

            if (UcusSecin == 1)
            {
                Console.WriteLine("Seçtiğiniz tarih:" + Ucus1.tarih.Day + "." + Ucus1.tarih.Month + "." + Ucus1.tarih.Year);
                tarihD = Ucus1.tarih.Day.ToString();
                tarihM = Ucus1.tarih.Month.ToString();
                tarihY = Ucus1.tarih.Year.ToString();
            }
            else if (UcusSecin == 2)
            {
                while (true)
                {
                    Console.WriteLine("İstediğiniz tarihi örnekte gördüğünüz gibi giriniz.");
                    Console.WriteLine("Örnek;  10.05.2023");
                    Console.WriteLine("            ");
                    DateTime SecilenTarih = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Seçtiğniz tarih :" + SecilenTarih.Day + "." + SecilenTarih.Month + "." + SecilenTarih.Year);
                    tarihD = SecilenTarih.Day.ToString();
                    tarihM = SecilenTarih.Month.ToString();
                    tarihY = SecilenTarih.Year.ToString();

                    // Geçmiş bir tarih girilince bu kod çalışır ve tekrar tarih girilmesi istenir.
                    if (SecilenTarih < Ucus1.tarih)
                    {
                        Console.WriteLine("Geçmiş bir tarih girdiniz");
                        continue;

                    }
                    else
                    {
                        break;
                    }
                }

            }
            else if (UcusSecin < 1)
            {
                Console.WriteLine("Hatalı giriş yaptınız.Lütfen tekrar programa giriş yapınız.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.Lütfen tekrar programa giriş yapınız");
                Console.ReadLine();
            }

            //Seçilen lokasyon ve güne göre uçuş zamanı bilgisi verilir. 
            Console.WriteLine("            ");
            if (LokasyonNumarası == Lokasyon1.id)
            {
                Console.WriteLine(Ucus1.Lokasyon.sehir + "  " + Ucus1.id + ")" + Ucus1.saat + "  " + Ucus2.id + ")" + Ucus2.saat + "  " + Ucus3.id + " )" + Ucus3.saat + "  " + Ucus4.id +")"+ Ucus4.saat);

            }
            else if (LokasyonNumarası == Lokasyon2.id)
            {
                Console.WriteLine(Ucus5.Lokasyon.sehir + "  " + Ucus1.id + ")" + Ucus5.saat + "  " + Ucus2.id + ")" + Ucus6.saat + "  " + Ucus3.id + " )" + Ucus7.saat + "  " + Ucus4.id+")" + Ucus8.saat);
            }
            else if (LokasyonNumarası == Lokasyon3.id)
            {
                Console.WriteLine(Ucus9.Lokasyon.sehir + "  " + Ucus1.id + ")" + Ucus9.saat + "  " + Ucus2.id + ")" + Ucus10.saat + "  " + Ucus3.id + " )" + Ucus11.saat + "  " + Ucus4.id+")" + Ucus12.saat);
            }

            //Bu kodda uçuş  zamanı seçilir.
            Console.WriteLine("Lokasyon uçuş saati seçiniz ");
            Console.WriteLine("            ");
            Double UcakSaati = Convert.ToInt32(Console.ReadLine());

            if (UcakSaati == 1)
            {
                Console.WriteLine("Seçilen saat:" + Ucus1.saat);
                UcusSaatiK = Ucus1.saat;
            }
            else if (UcakSaati == 2)
            {
                Console.WriteLine("Seçilen saat:" + Ucus2.saat);
                UcusSaatiK = Ucus2.saat;
            }
            else if (UcakSaati == 3)
            {
                Console.WriteLine("Seçilen saat:" + Ucus3.saat);
                UcusSaatiK = Ucus3.saat;
            }
            else if (UcakSaati == 4)
            {
                Console.WriteLine("Seçilen saat:" + Ucus4.saat);
                UcusSaatiK = Ucus4.saat;
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
            }

            // Müsteri adı soyadı ve telefon numarası alınır bu kodda.
            Console.WriteLine("Müşteri Adı Soyadı giriniz");
            string Musteri = Convert.ToString(Console.ReadLine());

            Rezervasyon1.musteriAdiSoyadi = Musteri;
            Console.WriteLine("Müsteri ad - Soyad :" + Musteri);

            int musteriYasi;

            do
            {
                Console.WriteLine("Müşteri Yaşı giriniz");
                musteriYasi = Convert.ToInt32(Console.ReadLine());

                if (musteriYasi < 16)
                {
                    Console.WriteLine("Müşteri yaşı 16'dan küçük olamaz. Lütfen geçerli bir yaş giriniz.");
                }

            } while (musteriYasi < 16);

            Rezervasyon1.yas = musteriYasi;
            Console.WriteLine("Müşteri Yaşı: " + musteriYasi);
            Console.WriteLine("Müşteri Telefon No giriniz.Örnek :(###)-###-##-## ");
            Double Ceptelefon = Convert.ToDouble(Console.ReadLine());
            Rezervasyon1.musteriCepTelefonu = Ceptelefon;


            var koltukA = "";

            //Bu kodda bugün  seçimine göre işlemler devam ediyor.Boş koltuk sayısı da yazdırılır.
            if (UcusSecin == 1)
            {
                Console.WriteLine(" 20 Tane boş koltuk  ");
                int bos = 20;

                Console.WriteLine("                Uçak başı                        ");
                for (int i = 1; i <= 120; i += 6)
                {
                    Console.WriteLine($"{i,3}  {i + 1,3}  {i + 2,3} Koridor {i + 3,3}  {i + 4,3}  {i + 5,3}");
                }
                Console.WriteLine("");
                // Bu kodda random dolu koltuklar olusturluyor
                Random r = new Random();
                string[] K = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120" };

                List<string> doluKoltuklar = new List<string>();
                HashSet<string> secilenKoltuklar = new HashSet<string>();

                while (doluKoltuklar.Count < 20)
                {
                    int index = r.Next(0, K.Length);
                    string koltukNo = K[index];

                    if (!secilenKoltuklar.Contains(koltukNo))
                    {
                        doluKoltuklar.Add(koltukNo);
                        secilenKoltuklar.Add(koltukNo);
                    }
                }

                foreach (string koltuk in doluKoltuklar)
                {
                    Console.WriteLine("boşKoltuk: " + koltuk);
                }
                /*Burdaki kodlarda Bilet adeti girilmesi istenir  ve o kadar bilet var mı diye kontrol edilir.
                Yeterli koltuk yoksa tekrar bilet adeti istenir.Aynı zamanda bilet sayısına göre fiyat hesaplanır.
                Bilet adeti kadar boş koltuk no girilmesi istenir.*/
                while (true)
                {
                    Console.WriteLine("Bilet adeti giriniz ");
                    int biletAdeti = Convert.ToInt32(Console.ReadLine());
                    Rezervasyon1.biletAdeti = biletAdeti;
                    Console.WriteLine("Bilet adeti: " + biletAdeti);


                    int Kalan;
                    Kalan = bos - biletAdeti;


                    int fiyat = biletAdeti * Bilgi1.biletFiyatı;
                    Console.WriteLine(fiyat + " TL  ");

                    if (Kalan < 0)
                    {
                        Console.WriteLine("Yetersiz koltuk Sayısı");
                        continue;

                    }
                    else
                    {

                        string[] KoltukNo = new string[biletAdeti];
                        Console.WriteLine("Lütfen bilet adeti kadar tek tek yukarıda yazan boş Koltuk No giriniz");
                        for (int d = 0; d < biletAdeti; d++)
                        {
                            KoltukNo[d] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Seçilen Koltuk No: " + KoltukNo[d]);
                            koltukA += KoltukNo[d] + " ";
                        }
                        break;

                    }



                }



            }
            // Bu kodda bugün değil ileri bir tarih seçildiyse onun için işlemler yapılır.Ve boş koltuk sayısı söylenir.
            else
            {
                Console.WriteLine("                Uçak başı                        ");
                for (int i = 1; i <= 120; i += 6)
                {
                    Console.WriteLine($"{i,3}  {i + 1,3}  {i + 2,3} Koridor {i + 3,3}  {i + 4,3}  {i + 5,3}");
                }
                Console.WriteLine("");
                int bosk = 120;
                //Burdaki kodlarda Bilet adeti girilmesi istenir  ve o kadar bilet var mı diye kontrol edilir.
                //Yeterli koltuk yoksa tekrar bilet adeti istenir.Aynı zamanda bilet sayısına göre fiyat hesaplanır.
                // Bilet adeti kadar boş koltuk no girilmesi istenir.
                while (true)
                {
                    Console.WriteLine("Bilet adeti giriniz ");
                    int biletAdeti = Convert.ToInt32(Console.ReadLine());
                    Rezervasyon1.biletAdeti = biletAdeti;
                    Console.WriteLine("Bilet adeti: " + biletAdeti);
                    int kalan;
                    kalan = bosk - biletAdeti;
                    int fiyat = biletAdeti * Bilgi1.biletFiyatı;
                    Console.WriteLine(fiyat + " TL  ");

                    if (kalan < 0)
                    {
                        Console.WriteLine("Yetersiz koltuk Sayısı");
                        continue;

                    }
                    else
                    {


                        string[] KoltukNo = new string[biletAdeti];
                        Console.WriteLine("Lütfen bilet adeti kadar tek tek Koltuk No giriniz");
                        for (int d = 0; d < biletAdeti; d++)
                        {
                            KoltukNo[d] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Seçilen Koltuk No: " + KoltukNo[d]);
                            koltukA += KoltukNo[d] + " ";
                        }



                        break;
                    }

                }

            }

            int lastReservationId = GetLastReservationId();

            Console.WriteLine("Rezervasyon işlemi gerçekleşti. Bilet örneğiniz aşağıda bulunmaktadır.");
            Console.WriteLine("                                                                             ");
            // Bilet yazdırma.

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Bilet Bilgisi                              Rezervasyon yapılış Tarihi:    " + DateTime.Now);
            Console.WriteLine("  Nereden - Nereye" + SehirK + "" + "" + "" + SeyehatSuresiK + "dk");
            Console.WriteLine(" " + "Uçak Seri No: " + SeriNoK);
            Console.WriteLine("  Uçuş Tarihi: " + tarihD + "." + tarihM + "." + tarihY);
            Console.WriteLine("  Uçak kalkış saati : " + UcusSaatiK);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Adı Soyad :" + Rezervasyon1.musteriAdiSoyadi.ToUpper());
            Console.WriteLine("  Cep Telefonu:");
            Console.WriteLine("{0:  (###)-###-##-##}", Rezervasyon1.musteriCepTelefonu);
            Console.WriteLine("  Fiyatı:" + Rezervasyon1.biletAdeti * Bilgi1.biletFiyatı + " TL  " + "Bilet Adeti:" + Rezervasyon1.biletAdeti);
            Console.WriteLine("  Koltuk No:" + koltukA);
            Console.WriteLine("bilet No:" + (lastReservationId + 1));
            Console.WriteLine("_________________________________________________________________________________________________________________");

            Console.WriteLine("*********************************İşlem Başarılı*******************************************");

            using (StreamWriter sw = new StreamWriter("Rezervasyon.csv", true))
            {
                // Yeni rezervasyon bilgilerini dosyaya yazma
                sw.WriteLine($"{lastReservationId + 1},{Rezervasyon1.Ucus},{Rezervasyon1.musteriAdiSoyadi},{Rezervasyon1.musteriCepTelefonu},{Rezervasyon1.yas},{Rezervasyon1.biletAdeti},{koltukA}");
                
            }


        }



    }
}




















