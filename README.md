# HelloTye

tye非常便于微服务互相调用时的测试与部署，能一行命令启动多个项目并通过环境变量指定互相调用地址。

前期准备：

1. 准备VS2019及.NET Core 3.1环境
2. 安装或升级tye
	- `dotnet tool install -g Microsoft.Tye --version "0.6.0-*" --add-source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet5/nuget/v3/index.json`
	- `dotnet tool update -g Microsoft.Tye --version "0.6.0-*" --add-source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet5/nuget/v3/index.json`

demo试玩步骤：

1. 使用 `Developer Command Prompt for VS 2019` 导航到sln文件所在路径
2. 执行：`tye run`
3. 打开 <http://localhost:8000/>，即可看到面板

纯手工试玩步骤：

1. 建个解决方案，包括后台与前台（两个WebApi项目，通过互相调用联系来指代前后台关系）
2. 假如后台项目名为`backend`，前台即通过`Configuration.GetServiceUri ("backend")`来获取后台项目访问地址
3. 使用 `Developer Command Prompt for VS 2019` 导航到sln文件所在路径
4. 执行：`tye init`
5. 执行：`tye run`
6. 打开 <http://localhost:8000/>，即可看到面板

英文介绍：<https://devblogs.microsoft.com/aspnet/introducing-project-tye/>
