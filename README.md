# assessment-backend-net
 
Merhaba, projeyi clone'layıp windows makinada direkt ayağa kaldırabilirsiniz. MongoDB cloud olarak kullanılmıştır.
UI katmanı ve işlevlerdeki maddeler yetişmediği için projede yer almıyor.
Test için postman ile istek atabilirsiniz. Proje run edildiğinde APIGateway ve PersonInfo.API ayağa kalkacaktır.
APIGATEWAY UI katmanında PersonInfo.API ve Report.API ye yönlendirme route amaçlı inşa edilmiştir.
Şuanki durumda UI olmadığı için direkt PersonInfo.API ile devam edebilirsiniz.

PersonInfo.API'de 3 metot yer alıyor. Kolaylık olması için hepsini HttpGet olarak tasarladım.

https://localhost:44321/api/PersonInfo/GetAllPersonel => Kişileri hepsini getirir.

https://localhost:44321/api/PersonInfo/PersonelCreate => Kişi oluşturur. Datalar serviste otomatik olarak create ediliyor.

https://localhost:44321/api/PersonInfo/PersonelDelete/63a72d272f5eabcd0926c6ff => İlgili id'li kişiyi delete eder.
