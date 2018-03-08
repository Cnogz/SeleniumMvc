MVC Projesi açılır.
Proje oluşturulduktan sonra c# unit test projesi açılır.
Unit Test projesine NuGet üzerinden Selenium Web Driver eklenir.
Web Driverlar olmadan selenium çalışamaz. Hangi browser kullanılacak ise o driver indirilmelidir.

ChromeDriver:
http://chromedriver.storage.googleapis.com/index.html?path=2.9/
IEDriver:
http://selenium-release.storage.googleapis.com/2.44/IEDriverServer_x64_2.44.0.zip

Çalıştırmak için öncelikle IIS Express çalışıyor olmalı. 
Bu nedenle mvc projesinin üzerine sağ tuş tıklayarak properties içerisindeki web tabında IIS'in seçili olduğundan emin olmalıyız.
Sonrasında IIS'in devreye girmesi için mvc projesine sağ tuşla tıklayıp view => browser ismine tıklayarak çalıştırıp, test projesine geçmeliyiz.Test için ister class içerisinde sağ tuş tıklayarak run tests ya da ekleme metodu üzerindeki reference alanı yanındaki run bolumune tıklamamız yeterlidir.
NOT: Eğer "no tests were found" benzeri bir uyarı alırsanız selenium web driver sürümünden kaynaklı bir hatadır ve metot üzerinden tıklayarak çalıştırdığınzda problem yaşanmayacaktır.

Daha sonra browser çalışmaya baslayacak ve test otomatik olarak yürütülecektir.