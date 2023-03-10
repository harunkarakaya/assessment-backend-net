# assessment-backend-net
Örnek Microservices Architecture

![Microservices architecture example](https://user-images.githubusercontent.com/45761495/210186608-d7bc579d-b18b-4f6f-8136-0c49451b086f.PNG)

Senaryo
Birbirleri ile haberleşen minimum iki microservice'in olduğu bir yapı tasarlayarak, basit bir telefon rehberi uygulaması oluşturulması sağlanacaktır.

Beklenen işlevler:

Rehberde kişi oluşturma, 
Rehberde kişi kaldırma, 
Rehberdeki kişiye iletişim bilgisi ekleme, 
Rehberdeki kişiden iletişim bilgisi kaldırma, 
Rehberdeki kişilerin listelenmesi, 
Rehberdeki bir kişiyle ilgili iletişim bilgilerinin de yer aldığı detay bilgilerin getirilmesi, 
Rehberdeki kişilerin bulundukları konuma göre istatistiklerini çıkartan bir rapor talebi, 
Sistemin oluşturduğu raporların listelenmesi, 
Sistemin oluşturduğu bir raporun detay bilgilerinin getirilmesi, 
Teknik Tasarım, 
Kişiler: Sistemde teorik anlamda sınırsız sayıda kişi kaydı yapılabilecektir. Her kişiye bağlı iletişim bilgileri de yine sınırsız bir biçimde eklenebilmelidir.


Karşılanması beklenen veri yapısındaki gerekli alanlar aşağıdaki gibidir:

UUID
Ad
Soyad
Firma
İletişim Bilgisi
Bilgi Tipi: Telefon Numarası, E-mail Adresi, Konum
Bilgi İçeriği
Rapor: Rapor talepleri asenkron çalışacaktır. Kullanıcı bir rapor talep ettiğinde, sistem arkaplanda bu çalışmayı darboğaz yaratmadan sıralı bir biçimde ele alacak; rapor tamamlandığında ise kullanıcının "raporların listelendiği" endpoint üzerinden raporun durumunu "tamamlandı" olarak gözlemleyebilmesi gerekmektedir.


Rapor basitçe aşağıdaki bilgileri içerecektir:

Konum Bilgisi
O konumda yer alan rehbere kayıtlı kişi sayısı
O konumda yer alan rehbere kayıtlı telefon numarası sayısı


Veri yapısı olarak da:

UUID
Raporun Talep Edildiği Tarih
Rapor Durumu (Hazırlanıyor, Tamamlandı)
