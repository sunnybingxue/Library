关于图书管理系统数据库附加的说明
1、首先保证计算机上已经成功安装SQL Server 2005。

2、将数据库文件附加到数据库中。

3、如果当前计算机装有多个SQL Server 2005实例,请在BookManageSystem目录下打开app.config程序文件，将程序数据库连接字符串localhost改为localhost\你的数据库实例名。如果仅有一个实例，就不用修改了。

4、编译运行即可。


管理员账户和密码：admin  admin
读者账户和密码：user  user
