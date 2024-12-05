# ProductApi

## Descripción
ProductApi es una API web desarrollada con .NET 8 que utiliza Entity Framework Core para interactuar con una base de datos PostgreSQL. Esta API proporciona operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para gestionar productos.

## Características
- Desarrollado con .NET 8
- Utiliza Entity Framework Core para el acceso a datos
- Base de datos PostgreSQL
- Operaciones CRUD para la entidad Product
- Dockerizado para facilitar el despliegue y desarrollo

## Requisitos previos
- .NET 8 SDK
- Docker
- PostgreSQL (se puede usar la versión dockerizada incluida en el proyecto)

## Configuración
1. Clona este repositorio
2. Navega al directorio del proyecto
3. Ejecuta `docker-compose up -d` para iniciar la base de datos PostgreSQL
4. Actualiza la cadena de conexión en `appsettings.json` si es necesario
5. Ejecuta `dotnet ef database update` para aplicar las migraciones
6. Ejecuta `dotnet run` para iniciar la API

## Uso
La API expone los siguientes endpoints:

- GET /api/products: Obtiene todos los productos
- GET /api/products/{id}: Obtiene un producto específico
- POST /api/products: Crea un nuevo producto
- PUT /api/products/{id}: Actualiza un producto existente
- DELETE /api/products/{id}: Elimina un producto

## Estructura del proyecto
- `Controllers/`: Contiene los controladores de la API
- `Models/`: Define el modelo de datos para Product
- `Data/`: Contiene el contexto de la base de datos
- `Migrations/`: Almacena las migraciones de Entity Framework Core

## Contribuir
Las contribuciones son bienvenidas. Por favor, abre un issue para discutir los cambios propuestos antes de realizar un pull request.

## Licencia
Este proyecto está licenciado bajo la Mozilla Public License 2.0. Ver el archivo [LICENSE](LICENSE) para más detalles.