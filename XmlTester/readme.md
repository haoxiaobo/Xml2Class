# 这个发明干什么用的？

在开发中，我们会遇到两个系统对接的情况，系统之前需要传递一些数据，下面是一个XML数据报文的例子，这个例子中，系统A向系统B发送了两个个人客户的信息。

#### 代码1：报文

```xml
<PersonsData>
    <Custom Type="person">
        <Name>张三</Name>
        <Sex>M</Sex>
        <Cert>
            <CertType>01</CertType>
            <CertNo>1101010101010101010</CertNo>
        </Cert>
    </Custom>
    <Custom Type="person">
        <Name>李四</Name>
        <Sex>M</Sex>
        <Age>20</Age>
        <Cert>
            <CertType>02</CertType>
            <CertNo>G8374387</CertNo>
        </Cert>
    </Custom>
</PersonsData>
```

```json
"PersonsData":{ 
    "Custom":[
        {
            "Type":"person",
            "Name":"张三",
            "Sex": "M",
            "Cert":{
                "CertType":"01",
                "CertNo":"1101010101010101010"
            }
        },
        {
            "Type":"person",
            "Name":"李四",
            "Sex":"M",
            "Age":"20",
            "Cert": {
                "CertType":"02",
                "CertNo":"G8374387"
            }
        }
    ]
}
```

双方系统要生成或是解析这些数据，在系统中都需要有对应的对象定义。如下：

#### 代码2：对应的类定义

```csharp
public class PersonsDataClass // 根层级的对象
{
    public CustomClass[] Custom; // 客户数组
}

public class CustomClass  // 客户对象
{
    [XmlAttribute]
    public string Type;  
    public string Name;
    public string Sex;
    public int Age;
    public CertClass Cert;
}

public class CertClass
{
    public string CertType;
    public string CertNo;
}

```

通过这些类的定义，在程序中可以很方便地生成实际数据的报文:

#### 代码3：源系统中的数据组装、序列化与发送

```csharp
// 服务器生成报文的过程。
PersonDataClass pd = new PersonDataCalss();
// 从数据库中取出数据，填充。下面是直接赋值的例子
pd.Custom = new Custom[]{
    new Custom(){
        Type="person",
        Name = "张三",        
        Cert = new CertClass(){
            CertNo = "110293929392880912",
            CertType="01"
        }
    },
    new Custom(){
        Type="person",
        Name = "李四",
        Age = 20,
        Cert = new CertClass(){
            CertNo = "G41023",
            CertType="02"
        }
    },
 };

string xml = XmlSerializer.Serialize(pd);
SendByInternet(SystemB_Url, xml); // 发送到网络上的系统B
```

或是在接收方（system B)解析它们为对象：

#### 代码4：接收方的报文解析

``` csharp
string xml = this.request.Body; // 从网络取得的报文

PersonDataClass pd;
pd = (PersonDataClass)XmlSerializer.DeSerialize(xml);
```

#### 实际情况

上面的过程中，发送方与接受方两个系统中需要有相同的代码2（类定义）。但在实际的工作中，两端的系统常常不是同样的技术平台，无法共享相同的代码。或是系统B得不到任何系统A的设计文档，只能得到实际运行中截取的数据报文。

因此，通过分析数据报文来得到代码2中的类定义代码，是经常要进行的工作。

这个工作传统情况下，是通过人工的分析与手工定义来实现的。但这种方式下，工作量大，容易出错，特别是在报文非常复杂、层次很深的时候，人工分析要保证正确几乎不可能。在我们处理过的一个报文里，有几千行的的数据，涉及的对象层到6层深，各类对象十几种，属性达上百个。


**本发明的工作就是把这个人工作业改为自动化分析。**


# 关于其它的一些问题

## 类定义是什么

如上面代码2中的示例。

## 树状的节点结构

指代码1中的报文结构。其中各个层次的对象形成了树状的结构。

## 对象字典

“字典”指得的是“键-值(Key-Value”对的**集合**（对，是个集合）。这是计算机算法中常用的一种数据结构，用于根据一个名字，来方便地查找到对应的项目。

如下是一个字典，在这个字典中，以字符串做键，以整数做值：

```
"a":1,
"b":5,
"c":10,
"d":3,
"e":5
……
```

在这个字典中，给出a, 则可以得到对应的整数1，给出d，则可以得到对应的整数3.

在本发明中，字典被用来保存已经识别出来的数据对象，每个数据对象都以其名字做为“键”来保存在字典中。一开始，程序会初始化一个空的字典，即你说的空集，在遍历分析数据报文的过程中，被识别出来的对象会被放入这个字典（也即集合）中，根据发现的对象、对象内部的字段而补充数据模型。

“如发现有之前的定义存在”，指得是：数据报文中的一个对象（如custom)被第一次发现时（张三），在这个集合中增加一个对象的记录。第二次发现时（李四），同样的对象不会重建，而是在字典中（集合中）之前已经有的记录的对象上，补充更新发新的字段。

对象的“属性”，即“字段”，在编程中，这两个术语几乎是同义的。

# 之前有定义存在，这个之前是指什么时候定义存在？


## 合并字段是什么意思

注意一下代码1中的报文：

第一个客户的报文中没有age字段，但在第二个客户报文中，这个字段出现了。

代码分析工作中，通过对第一个客户的信息分析，定义了CustomClass类，在对第二个客户的信息分析中，发现了这个字段，需要被合并加入已经定义好的CustomClass类，并意识到这个字段是“可空”的。

人工分析要处理这个问题，自动化分析中也需要处理这个问题。

