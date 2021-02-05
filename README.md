# Netflix_API
Netflix_API (ER + SQL)

#### 1. Description
```
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
```

#### 2. Link a un demo con el proyecto desplegado: https://github.com/JoseMarin/Netflix_API

```
* Nombre de la App: [GIT] (https://github.com/)
```
#### 3. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto y echarlo a andar en local.

###### Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
```
###### packages Nuget 
```
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
###### Cadena de Conexión Base de datos 
```
"AllowedHosts": "*",
  "ConnectionStrings": {
    "NetflixDatabase": "Server=192.168.1.135;Database=netflix;User ID=usuario;Password=password"
    }
```
#### 4. URIs endpoints.
```
Clientes
GET       /api/Clientes
POST      /api/Clientes
GET       /api/Clientes/{id}
PUT       /api/Clientes/{id}
DELETE    /api/Clientes/{id}

Videos
GET       /api/Videos
POST      /api/Videos
GET       /api/Videos/{id}
PUT       /api/Videos/{id}
DELETE    /api/Videos/{id}
```

#### 5. Screenshot imagen que indique cómo debe verse el proyecto.
![image](https://user-images.githubusercontent.com/16636086/106975608-1f4eb680-6757-11eb-90c9-af48dba80385.png)
