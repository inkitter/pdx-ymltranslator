# P社翻译文件YML翻译器（钢铁雄心4、群星）
# Paradox Interactive YML Translator
Github：https://github.com/inkitter/pdx-ymltranslator

## V1.5 170411
目前已经自带合并功能，不再需要Merger。窗口可以调整大小了:)
### 准备
0. 需要安装.NET Framework 4.5。
1. 把游戏原版的*_l_english.yml放入eng文件夹，注意不要放其他语言版本。
2. 将翻译过的yml文件放入chn文件夹。
3. 如果需要自定义词典，需将 ymldict.csv 文件放入程序目录。
4. 如果需要对比旧版原文的功能，将旧版的 yml 文件放入 old\[某目录]\ 之中。release包内已有群星1.4.1和钢铁雄心1.3.3的原文本。不需要则删除old文件夹即可（此功能可能导致程序错误或者性能低下）。
5. 确认以上步骤，即可运行 pdx-ymltranslator.exe。

### 使用

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


## for HOI4, Stellaris


可能用到的dos命令
```
rd eng /s /q
rd chn /s /q

md eng
copy "D:\SteamLibrary\steamapps\common\Hearts of Iron IV\localisation\*_l_english.yml" eng /Y

mklink /j chn "D:\git\HOI4_mod\chnLocal\localisation"

```