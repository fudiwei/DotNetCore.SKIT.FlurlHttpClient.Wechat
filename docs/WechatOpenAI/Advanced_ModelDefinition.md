## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，查询技能商店列表的请求是 `SkillStoreGetListRequest`，响应是 `SkillStoreGetListResponse`，接口是 `ExecuteSkillStoreGetListAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的查询技能商店列表，它的接口地址是 `[POST] /skill_store/get_list`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.OpenAI/Models_ 目录。

---

### 微信对话开放平台 API 支持情况：

<details>

<summary>[展开查看]</summary>

|     |   微信 API   | 备注 |
| :-: | :----------: | :--: |
|  √  |   注册用户   |      |
|  √  |   获取令牌   |      |
|  √  |   通用接口   |      |
|  √  |    机器人    |      |
|  √  |     技能     |      |
|  √  |     意图     |      |
|  √  |    语义槽    |      |
|  √  |     词典     |      |
|  √  |     词条     |      |
|  √  | 对话开放接口 |      |
|  √  |   技能商店   |      |
|  √  |   数据统计   |      |

</details>
