# u-send-first
Mail Inbox App

API layer of this project was created with ```'ASP.NetCore Web API'.```
The concept of ```'Code First' ``` has been adopted.
The ```'Microsoft.EntityFrameworkCore' ``` library is used in data processing.
The ``` 'SOLID' ``` principles have been complied with.
Front-End side is built with ```'Vue.js'.```


Requirements for preparing the application for use:
```
-Visual Studio 2022
```
```
-Any Database application connected with 'SQL SERVER'
```
```
-Visual Studio Code
```
Usage of the application:

#For API Layer:

-Clone from the repository to your local.

-Run the ```'U-Send-First.sln'``` application from the ```'api'``` folder in the ```'src'``` folder.

-In the opened application, set the server connection code written in the ``` 'appsettings.Development.json'``` and appsettings.json files in the ```'U-Send First.Api'``` project in the 'API' layer according to your own ```'SQL SERVER'```connection.

  ```("Server=localhost,[port];Database=USendFirstDb;User Id=[own user id];Password=[password]")```
  
-The data in ``` 'data/U-Send-First.Data.Seed/MigrationBuilderExtensions.cs'``` was prepared to be seed data and placed in the migration file. If desired, the data can be reproduced in accordance with the written format.

-Since the migration file is ready in the project, to transfer the necessary data to the database, the 
```
"Update-Database -P U-Send-First.Data -Context USendFirstDbContext -S U-Send-First.Api"
``` 
command in ```'_docs/Migration.txt'``` must be copied and
  It should be pasted and run in the "Package Manager Console" section.
  
-When the specified steps are taken, the API layer and database will be ready.

-After completing these steps, run the application with the solid green arrow icon on the top tab. 

-The API will start working without opening the browser.

	Example user emails: ```"admin@usendfirst.com","jim@usendfirst.com"-passwords "123."```

#For the Client Layer:

-Open the ```'USendFirst-client'``` folder with the ```'Visual Studio Code'``` application.

-In the application that opens, click on the 'New Terminal' section from the 'Terminal' tab on the top tab.

-Run the ```'npm install'``` command in the window that opens to download the necessary ```'npm'``` files.

-After the download is complete, run the ```'npm run dev'``` command in the same window.

-The client application will rise over the link given by ```'vite'```, which is used as a compilation tool.

-You can access the client application by copying the given 'url' link to the browser.

-NOTE :
	-'U-Send-First.Api' must be running for the client Application to work.
  
  ------------------------------------------------------------------------------------------------------------
  
Bu projenin 'API' katmanı ```'ASP.NetCore Web API'``` ile oluşturulmuştur. 
```'Code First' ``` anlayışı benimsenmiştir. 
Veri işlemlerinde ``` Microsoft.EntityFrameworkCore``` kütüphanesi kullanılmıtır. 
```SOLID``` prensiblerine uyulmuştur. 
Front-End tarafı ```'Vue.js'``` ile oluşturulmuştur. 

Uygulamanın kullanıma hazırlanması için gereksinimler :
```
-Visual Studio 2022
```
```
-'SQL SERVER' ile bağlantılı herhangi bir Database uygulaması
```
```
-Visual Studio Code 
```

Uygulamanın kullanımı :
Api Katmanı için :
-Repositoriden locale klonlayınız.
-'src' dosyası içerisindeki 'api' klasöründen 'U-Send-First.sln' uygulamasını çalıştırınız. 
-Açılan uygulamada api katmanında bulunan 'U-Send-First.Api' projesinin içerisindeki 'appsettings.Development.json' ve 'appsettings.json' dosyalarında yazılı olan server bağlantı kodunu kendi 'SQL SERVER' bağlantınıza göre ayarlayınız.
	("Server=localhost,[port bilgisi];Database=USendFirstDb;User Id=[kendi kullanıcı Id'niz];Password=[şifreniz]")
	
- 'data/U-Send-First.Data.Seed/MigrationBuilderExtensions.cs' içerisinde bulunan veriler seed veriler olması için hazırlanıp migration dosyası içerisine yerleştirilmiştir. istenilirse veriler yazılan formata uygun şekilde çoğaltılabilir. 

-Migration dosyası projenin içerisinde hazır olduğundan dolayı gerekli verileri database aktarmak için '_docs/Migration.txt' içerisindeki "Update-Database -P U-Send-First.Data -Context USendFirstDbContext -S U-Send-First.Api" komutu kopyalanıp 
	"Package Manager Console" bölümüne yapıştırılıp çalıştırılmalıdır. 
-Belirtilen adımlar atıldığında API katmanı ve database hazır olacaktır. 
-Örnek kullanıcı mailleri : "admin@usendfirst.com","jim@usendfirst.com" şifreleri "123."
-Bu adımları tamamladıktan sonra uygulamayı üst sekmede bulunan içi dolu yeşil ok simgesiyle çalıştırınız. 
-'API' browser açmadan çalışmaya başlayacaktır. 

Client Katmanı için :

-'USendFirst-client' klasörünü "Visual Studio Code" uygulaması ile açınız.
-Açılan uygulamada üst sekmede bulunan 'Terminal' sekmesinden 'New Terminal' bölümüne tıklayınız.
-Gerekli 'npm' dosyalarını indirmek için açılan pencerede 'npm install' komutunu çalıştırınız. 
-İndirme işlemi tamamlandıktan sonra 'npm run dev' komutunu aynı pencerede çalıştırınız. 
-Derleme aracı olarak kullanılan 'vite' nin verdiği link üzerinden client uygulaması ayağa kalkacaktır.
-Verilen 'url' linkini browser a kopyalayarak client uygulamasına erişebilirsiniz. 

NOT:
-'client' Uygulamasının çalışabilmesi için 'U-Send-First.Api' çalışır halde olmalıdır.


  
  
  
  
  
