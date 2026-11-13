## v4.x 迁移指南

v4.x 版本是一个主要版本，其中包括了一些破坏性的变化。从 v3.x 升级到 v4.x 之前，请仔细阅读本文档。

---

### 目标框架和基础库的变更

微软官方已于 2022 年 12 月 13 日宣布中止对 .NET Core 3.1 的支持。因此，本项目的最低运行时要求调整为 .NET 5.0。

与此同时，相关的 .NET 基础库（即通常在 `System.*` 或 `Microsoft.*` 命名空间下的内置依赖）版本对齐至 .NET 10.0。

### API 模型定义的变更

为了统一并规范化各个模块，我们调整了部分接口模型的定义，主要涉及以下三个方面：

#### 1. 列表形式字段

在之前的版本中，请求模型中列表形式字段被声明为 `IList<T>` 类型，而响应模型中列表形式字段被声明为 `T[]` 类型。

在新版本中，它们均被声明为 `List<T>` 类型。如果你的业务代码中依赖旧版本逻辑，请检查潜在的类型转换异常。

```csharp
/* v3.x 请求模型中的列表形式字段 */
public IList<string> IdList { get; set; }
/* v3.x 响应模型中的列表形式字段 */
public string[] IdList { get; set; }

/* v4.x 请求模型中的列表形式字段 */
public List<string> IdList { get; set; }
/* v4.x 响应模型中的列表形式字段 */
public List<string> IdList { get; set; }
```

#### 2. 引用类型字段

在之前的版本中，为了支持 C# 的 [Nullable Reference Types](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/null-safety/nullable-reference-types) 特性，请求或响应模型中的非可空的引用类型字段会在构造时被赋初值。

在新版本中，它们均被定义为可空的，不再会在构造时被赋初值。如果你的业务代码中依赖旧版本逻辑，请检查潜在的空指针异常。

```csharp
/* v3.x 请求模型中的引用类型 */
public string Name { get; set; } = string.Empty;
public IList<string> IdList { get; set; } = new List<string>();
/* v3.x 响应模型中的引用类型 */
public string Name { get; set; } = default!;
public string[] IdList { get; set; } = default!;

/* v4.x 请求模型中的引用类型 */
public string? Name { get; set; }
public List<string>? IdList { get; set; }
/* v4.x 响应模型中的引用类型 */
public string? Name { get; set; }
public List<string>? IdList { get; set; }
```

#### 3. 深层嵌套类型字段

在之前的版本中，请求或响应模型中存在的深层嵌套类型，可能继承自另一个请求或响应模型，这在构造时会使开发者产生一些困惑。

在新版本中，所有请求或响应模型中的深层嵌套类型的属性，其类型声明均会来自该请求或响应模型。

```csharp
// v3.x 中包含深层嵌套类型字段的类型定义
public class FooRequest
{
    public static class Types
    {
        public class Parent
        {
            public static class Types
            {
                public class Child
                {
                    public string Id { get; set; }
                }
            }
        }
        public Types.Child Child { get; set; }
    }
    public Types.Parent Parent { get; set; }
}
public class BarRequest : FooRequest
{
}
// v3.x 中包含深层嵌套类型字段的对象构造
BarRequest bar = new BarRequest();
bar.Parent = new FooRequest.Types.Parent();
bar.Parent.Child = new FooRequest.Types.Parent.Types.Child();

// v4.x 中包含深层嵌套类型字段的对象构造
BarRequest bar = new BarRequest();
bar.Parent = new BarRequest.Types.Parent();
bar.Parent.Child = new BarRequest.Types.Parent.Types.Child();
```
