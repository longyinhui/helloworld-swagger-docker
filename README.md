# helloworld-swagger-docker
This is a simple Helloworld for ASP.NET Core Swagger API project with Docker, deployed in http://106.55.179.167:8083/swagger/index.html

## Implementation Steps
### _In Development environment_ (Windows + Visual Studio + .NET 7.0)
1. Create new ASP.NET Core Web API project, enabling OpenAPI (or adding Swagger packages by manual) and Docker
2. Add API controller (see _Controllers/APIController.cs_)
3. Update _Program.cs_ and _launchSetting.json_ (need to add port, e.g.:83)
4. Build. if failed, check `<GenerateDocumentationFile>` and `<NoWarn>` in _csproj_
5. Publish. Target: _Folder_; Deployment Mode: _Self-contained_; choose correct Target Runtime
6. Prepare Dockerfile for publish (see _Dockerfile.publish_), which will be the Dockerfile used in Deployment environment

### _In Deployment environment_ (Linux-CentOS)
7. Copy publish folder to target server, and make sure correct Dockerfile is included
8. Run Docker
```sh
cd <folder path>
docker build -t helloworldswagger:v1 .
docker run -it -d -p 8083:83 helloworldswagger:v1
```
> Note: `helloworldswagger:v1` is image's name
