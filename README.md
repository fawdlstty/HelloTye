# HelloTye

tye�ǳ�����΢���������ʱ�Ĳ����벿����һ���������������Ŀ��ͨ����������ָ��������õ�ַ��

ǰ��׼����

1. ׼��VS2019��.NET Core 3.1����
2. ��װ������tye
	- `dotnet tool install -g Microsoft.Tye --version "0.6.0-*" --add-source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet5/nuget/v3/index.json`
	- `dotnet tool update -g Microsoft.Tye --version "0.6.0-*" --add-source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet5/nuget/v3/index.json`

demo���沽�裺

1. ʹ�� `Developer Command Prompt for VS 2019` ������sln�ļ�����·��
2. ִ�У�`tye run`
3. �� <http://localhost:8000/>�����ɿ������

���ֹ����沽�裺

1. �������������������̨��ǰ̨������WebApi��Ŀ��ͨ�����������ϵ��ָ��ǰ��̨��ϵ��
2. �����̨��Ŀ��Ϊ`backend`��ǰ̨��ͨ��`Configuration.GetServiceUri ("backend")`����ȡ��̨��Ŀ���ʵ�ַ
3. ʹ�� `Developer Command Prompt for VS 2019` ������sln�ļ�����·��
4. ִ�У�`tye init`
5. ִ�У�`tye run`
6. �� <http://localhost:8000/>�����ɿ������

Ӣ�Ľ��ܣ�<https://devblogs.microsoft.com/aspnet/introducing-project-tye/>
