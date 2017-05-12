# P社翻译文件YML翻译器（钢铁雄心4、群星）
# Paradox Interactive YML Translator
Github：https://github.com/inkitter/pdx-ymltranslator

> 需要安装.NET Framework 4.5。

## 目前版本： V1.7.2 170510
  
* old文件夹中是旧版的文本，因群星1.6加入了官中文本，分为 en-1.6 及 cn-1.6 两个。
* eng是原版文本，可以放入 yml 文件。
* chn文件夹是翻译之后的文本，目前程序会读取位于 chn\english\*.yml 作为初始载入的已翻译文本，但是保存时候会自动生成并保存在 chn\english\ 和 chn\simp_chinese 两个目录里。且 chn\simp_chinese 目录中文件首行会变为 l_simp_chinese:。
* 建议灵活使用 `mklink` 命令，诸如 `mklink /j chn "chnLocal\localisation"` 来建立文件夹链接，方便文本的翻译与统一。

### 更新内容
1. 换行符默认存为LF（"\n"），可选CRLF（"\r\n"）。


### 详细说明
* 如果需要自定义词典，需将 ymldict.csv 文件放入程序目录。

1. 窗口上半部分：左侧文件列表选择文件，右侧会显示文件内容。已经截取了变量名与文本内容，选择后会显示在下方文本框。
2. 颜色标记：①可能要翻译的部分会标记浅蓝色。②如果启用了旧版对比，若新旧英文不同，则会将英文部分标记为橙色。③若为新增文本，则英文部分标记为浅蓝色。
2. 下方文本框分为：原文、译文、百度API翻译参考 三个。
3. 翻译时使用中间的文本框，翻译完成后点击Apply保存该行的翻译（快捷键 Ctrl + Enter）。全文件翻译完毕后务必点击Save按钮，否则翻译的内容不会被保存，当然可以翻译一行保存一次。。。
4. Open Browser 按钮可以直接在默认浏览器打开google或baidu的网页翻译。按钮右侧选择哪个网页，默认baidu。
5. Paste API text to Translate 按钮可以直接把API的参考文本复制到翻译文本框。
6. 因为文本中使用了§这种奇怪的符号来标记字体颜色，输入符号比较麻烦，在右侧提供了Text Color功能，选择文本后点击相应的颜色会自动在文本上加入该颜色代码，不选择文本则只插入§R这种起始，需要在结束处再点击§! 来插入颜色结束。
7. Open Original 与 Open Translated 用于使用默认文本编辑器打开YMl文件，方便验证文件。
8. Save 按钮上方 下拉菜单用于选择旧版原文参考，用以对比新旧英文差异。复选框 Only Translated 用于只保存翻译过的文本，不保存未翻译的文本。勾选简/繁会进行强制转换后再保存，不勾选则不改变。
9. Ctrl + ↓ 可以直接跳转到下一个可能需要翻译的行。
10. Ctrl + ← 可以根据FROM文本框的内容再次查询API，并在下面的文本框显示。
11. Save 按钮左边有个文本框，可以快速搜索打开的yml中某个原文中的单词，用于查找同词使翻译一致。输入搜索内容在文本框内按 Enter 即可。
1. [1.7.1]增加了 Merge 与 CN 两个按钮，都是对文件列表中的全部文件进行操作的。 Merge 按钮会合并所有文件，并保存在 chn\english 中。 CN 按钮会将所有 english 的文件转存为 simp_chinese，并保存在 simp_chinese 文件夹。

## for HOI4, Stellaris


可能用到的dos命令
```
rd eng /s /q
rd chn /s /q

md eng
copy "D:\SteamLibrary\steamapps\common\Hearts of Iron IV\localisation\*_l_english.yml" eng /Y

mklink /j chn "D:\git\HOI4_mod\chnLocal\localisation"

```