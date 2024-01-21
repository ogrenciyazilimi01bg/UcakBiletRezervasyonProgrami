# UcakBiletRezervasyonProgrami
Bu projede, Uçak Bileti Rezervasyonu için geliştirilen kodların kaynağı yer almaktadır. Bu proje, C# dilinde yazılmış bir uçak bileti rezervasyonu uygulamasını içermektedir. Proje, konsol uygulaması olarak
tasarlanmıştır ve kullanıcının istekleri doğrultusunda sinema bileti rezervasyonu yapmayı amaçlamaktadır. Bu yönergeleri, projeyi kendi makinenizde çalıştırmak ve geliştirmek için kullanabilirsiniz.
## Classlar
Bu proje Uçak bileti rezervasyon projesi.Burda Ucak ,Ucus,Lokasyon,Rezervasyon ,Bilgi classlarından oluşmaktadır. Bu projede, 5 Class yer almaktadır. Ucak Class’ı içerisinde: ıd, ucakModel, ucakMarkasi,seriNo ve 
koltukKapasitesi özellikleri yer almaktadır. Ucus Class’ı içerisinde: ıd , saat,tarih özellikleri bulunur ve lokasyon classından Lokasyon ve  uçak classından uçak türetilir. Lokasyon Class’ı içerisinde: id,sehir,
ulke,havaalani,aktifpasif,seyehatSuresi özellikleri yer alır. Rezervasyon Class’ı içerisinde: Ucus class’ından ucus türetilir. Müşteri adı soyadı,id,yas, bilet adedi, koltuk no ve müşteri cep telefonu özellikleri
yer almaktadır. Bilgi Class’ı içerisinde: Rezervasyon class’ı içerisinde rezervasyon özellik türetilir ve bilet fiyatı özellik yer almaktadır. GirisEkranı Class'ı içerisinde :Buradan program ilerleyecek ve 
kullanıcıdan bilgiler isteyerek uygulama çalışmaya devam edecektir.
## Consol uygulaması bu şekilde çalışır:
1)Aşağıdaki Lokasyonlardan birini seçiniz yazar. Lokasyonlar  hakkında bilgiler yazar. Kulllanıcıdan bir lokasyon sayısı girmesi istenir.Yazılı olan lokasyon numaralarından girin. 
2)Seçilen lokasyon numarasına göre uçak  hakkında bilgiler ekrana yazacak. Ardından tarih seçmeniz istenir.Bugün seçerseniz işleme devam eder başka bir tarihi seçerseniz kullanıcıdan ekrana tarih girmesi istenir.
Örnek:14.05.2023 gibi. 3) Uçuş saatleri çıkacak. Kullanıcı uçus saati seçecek. 4) Müsteri adı soyadı girilir. Ekrana müşteri adı soyadı yazılır. 5)Yaş girilmesi istenir. Yaş kontrolü yapılır ve 16 yaşından küçük 
yolcular için özel bir uyarı verilir.6) Müsteri telefon no konsola girilir. .Örnek :(###)-###-##-## 7)Konsola boş koltuk sayısı ,koltuk yerleri ve boş koltuklar çıkar. 8) Kullanıcıdan bilet adeti girmesi istenir. 
Bilet adeti kadar koltuk numarası boş mu kontrol edilir. Değilse tekrar koltuk numarası girmesi istenir. Yeterli koltuk adeti varsa işleme devam edilir. Bilet adeti ekrana çıkar ve toplam fiyatı yazar.
9)Bilet adeti kadar koltuk numarası girilmesi istenir. Kullanıcı bilet adeti kadar koltuk numaralarını tek tek girer. 10)Oluşturulan bilet konsolda çıkar. Ve işlem başarılı yazısı çıkar.
### CSV Dosyaları 
Program, verileri düzenli bir şekilde saklamak için ayrı CSV dosyalarını kullanır. 
Ucak.csv: Uçak bilgilerini içerir. 
Lokasyon.csv: Lokasyon bilgilerini içerir.
 Ucus.csv: Uçuş bilgilerini içerir.
 Rezervasyon.csv: Rezervasyon bilgilerini içerir.
Bilgi.csv:Bilgi bilgilerini içerir.
Bu .csv dosyaları açmak için projenin dosyasındaki bin dosyasının içnden Debug dosyasını açın net6.0 dosyasına girin Burda çıkan excel dosyalarını Notepad++ da açın. Bu dosyaların içinlerinde kaydolan verileri göreceksiniz.
