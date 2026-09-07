
1- region endregion (function name 命名 ,包一组类型一样的function)
2- ctrl+k+u 多行解注释   ctrl+k+c 多行注释
3- 查套件 (右键点击function->选择移至定义区）(绿的才可以)
4- 重复代码 switch 成 function call
5- debug有code/ release没有code 
6- 版本换成抓取内部properties
7- program cs 可以控制谁是主程式
8- 正式项目放已测试熟练的功能，不熟的同文件夹开个新小项目测试验证
9- 多画架构图(mermaid/svg)-draw.io
10- 项目管理 把多余的外包进新的class 然后加public static 
11- 养成不写var 换成对应的变量 维护比较方便
12- 除错小技巧
```
 Debug.WriteLine($"{x} {y} {w} {h} ");
 Console.WriteLine($"{x} {y} {w} {h} ");
 solution -> class -> properties -> output type 要换 Console Application
```
13- visual studio exception 除错小技巧
```
View Details
```
14- 防呆常用 skill
```C#=
checkbox
if-else
bool flag
try-catch-finally
```
15-  VS Code 自动排版快捷键：
```C#=
- 整个文件格式化：`Shift + Alt + F`
- 只格式化选中代码：先选取，再按 `Ctrl + K`，接着按 `Ctrl + F`
```
16- 命名统一
```C#=
private 字段：_name
方法参数：name
局部变量：name
公开属性：Name
类名称：Person
```
17- 用站点查看局部代码exception
18- 通常dataGridView用foor loop output
19- 查看 API 类型最简单的方法是在 Visual Studio 把鼠标停在属性上，例如：
```C#=
circleGauge.NumSamples      // uint
circleGauge.CenterX         // float
numXCircle.Value            // decimal
circleGauge.GetFound()      // bool
```
tips- 数量用整数、测量值用 decimal、状态用 bool、文字路径用 string。
20- 多行注释
```
///<summary>
///
///<summary>
```
























