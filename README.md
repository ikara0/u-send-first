# u-send-first
**Mail Inbox App**

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

**#For API Layer**:

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

-The API will start working **without** opening the browser.

	Example user emails: "admin@usendfirst.com","jim@usendfirst.com"-passwords "123."

#**For the Client Layer**:

-Open the ```'USendFirst-client'``` folder with the ```'Visual Studio Code'``` application.

-In the application that opens, click on the ```'New Terminal'``` section from the ```'Terminal'``` tab on the top tab.

-Run the ```'npm install'``` command in the window that opens to download the necessary ```'npm'``` files.

-After the download is complete, run the ```'npm run dev'``` command in the same window.

-The client application will rise over the link given by ```'vite'```, which is used as a compilation tool.

-You can access the client application by copying the given 'url' link to the browser.

-NOTE :
>```'U-Send-First.Api'``` must be running for the client Application to work.
  
  ------------------------------------------------------------------------------------------------------------
  
Bu projenin 'API' katman?? ```'ASP.NetCore Web API'``` ile olu??turulmu??tur. 
```'Code First' ``` anlay?????? benimsenmi??tir. 
Veri i??lemlerinde ``` Microsoft.EntityFrameworkCore``` k??t??phanesi kullan??lm????t??r. 
```SOLID``` prensiblerine uyulmu??tur. 
Front-End taraf?? ```'Vue.js'``` ile olu??turulmu??tur. 

Uygulaman??n kullan??ma haz??rlanmas?? i??in gereksinimler :
```
-Visual Studio 2022
```
```
-'SQL SERVER' ile ba??lant??l?? herhangi bir Database uygulamas??
```
```
-Visual Studio Code 
```

Uygulaman??n kullan??m?? :

**API Katman?? i??in**:

-Repositoriden locale klonlay??n??z.

-```'src'``` dosyas?? i??erisindeki ```'api'``` klas??r??nden ```'U-Send-First.sln'``` uygulamas??n?? ??al????t??r??n??z. 

-A????lan uygulamada api katman??nda bulunan ```'U-Send-First.Api'``` projesinin i??erisindeki ```'appsettings.Development.json'``` ve ```'appsettings.json'``` dosyalar??nda yaz??l?? olan server ba??lant?? kodunu kendi ```'SQL SERVER'``` ba??lant??n??za g??re ayarlay??n??z.

```("Server=localhost,[port bilgisi];Database=USendFirstDb;User Id=[kendi kullan??c?? Id'niz];Password=[??ifreniz]")```
	
- ```'data/U-Send-First.Data.Seed/MigrationBuilderExtensions.cs'``` i??erisinde bulunan veriler seed veriler olmas?? i??in haz??rlan??p migration dosyas?? i??erisine yerle??tirilmi??tir. istenilirse veriler yaz??lan formata uygun ??ekilde ??o??alt??labilir. 

-Migration dosyas?? projenin i??erisinde haz??r oldu??undan dolay?? gerekli verileri database aktarmak i??in ```'_docs/Migration.txt'``` i??erisindeki 
```
"Update-Database -P U-Send-First.Data -Context USendFirstDbContext -S U-Send-First.Api"
```

komutu kopyalan??p ```"Package Manager Console" ```b??l??m??ne yap????t??r??l??p ??al????t??r??lmal??d??r. 

-Belirtilen ad??mlar at??ld??????nda API katman?? ve database haz??r olacakt??r. 
```
-??rnek kullan??c?? mailleri :"admin@usendfirst.com","jim@usendfirst.com" ??ifreleri "123."
```

-Bu ad??mlar?? tamamlad??ktan sonra uygulamay?? ??st sekmede bulunan i??i dolu ye??il ok simgesiyle ??al????t??r??n??z. 
-'API' browser **a??madan** ??al????maya ba??layacakt??r. 

**Client Katman?? i??in**:

-```'USendFirst-client'``` klas??r??n?? ```"Visual Studio Code"```uygulamas?? ile a????n??z.

-A????lan uygulamada ??st sekmede bulunan ```'Terminal'``` sekmesinden ```'New Terminal'``` b??l??m??ne t??klay??n??z.

-Gerekli ```'npm'``` dosyalar??n?? indirmek i??in a????lan pencerede ```'npm install'``` komutunu ??al????t??r??n??z. 

-??ndirme i??lemi tamamland??ktan sonra ```'npm run dev'``` komutunu ayn?? pencerede ??al????t??r??n??z. 

-Derleme arac?? olarak kullan??lan ```'vite'``` nin verdi??i link ??zerinden client uygulamas?? aya??a kalkacakt??r.

-Verilen 'url' linkini browser a kopyalayarak client uygulamas??na eri??ebilirsiniz. 


NOT:
>```'client'``` Uygulamas??n??n ??al????abilmesi i??in ```'U-Send-First.Api'``` ??al??????r halde olmal??d??r.


  
  
  
  
  
