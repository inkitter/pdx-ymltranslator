# P社翻译文件YML翻译器（钢铁雄心4、群星）
# Paradox Interactive YML Translator
Github：https://github.com/inkitter/pdx-ymltranslator

### 准备

  使用本软件首先使用YML文本合并器：https://github.com/inkitter/pdx-ymlmerger 整理文本，否则容易出现错行问题。
  （整理需要历遍文本，速度较慢，而且在翻译过程中并不会经常用，因此2个工具分离。）

0. 需要安装.NET Framework 4.5。
1. 把游戏原版的*_l_english.yml放入eng文件夹，注意不要放其他语言版本。
2. 将翻译过的yml文件放入chn文件夹。
3. 运行 pdx-ymltranslator.exe。


### 使用

1. 窗口上半部分：左侧文件列表选择文件，右侧会显示文件内容。已经截取了变量名与文本内容，选择后会显示在下方文本框。
2. 下方文本框分为：原文、译文、百度API翻译参考 三个。
3. 翻译时使用中间的文本框，翻译完成后点击Apply保存该行的翻译。全文件翻译完毕后务必点击Save按钮，否则翻译的内容不会被保存。也可以翻译一行保存一次。。。
4. Open Browser 按钮可以直接在默认浏览器打开google或baidu的网页翻译。按钮右侧选择，默认baidu。
5. Paste API text to Translate 按钮可以直接把API的参考内容复制到翻译文本框。
6. 因为文本中使用了§这种奇怪的符号来标记字体颜色，输入符号比较麻烦，在右侧提供了Text Color功能，选择文本后点击相应的颜色会自动在文本上加入该颜色代码，不选择文本则只插入§R这种起始，需要在结束处再点击§! 来插入颜色结束。
7. Open Original 与 Open Translated 用于使用默认文本编辑器打开YMl文件，方便验证文件。
8. 支持字典式翻译，使用程序目录下的ymldict.csv文件。release包中的ymldict.csv文件内容是根据 https://github.com/cloudwu/stellaris_cn/blob/master/terms_list.txt 制作的群星词典。


## for HOI4, Stellaris


可能用到的dos命令
```
rd eng /s /q
rd chn /s /q

md eng
copy "D:\SteamLibrary\steamapps\common\Hearts of Iron IV\localisation\*_l_english.yml" eng /Y

mklink /j chn "D:\git\HOI4_mod\chnLocal\localisation"
```