# P社翻译文件YML合并器（钢铁雄心4、群星）
# Paradox Interactive YML Merger

Github：[[https://github.com/inkitter/pdx-ymlmerger]]

### 准备

0. 需要安装.NET Framework 4.5。
1. 把游戏原版的*_l_english.yml放入eng文件夹，注意不要放其他语言版本。
2. 将翻译过的yml文件放入chn文件夹。
3. 运行 pdx-ymlmerger.exe。

### 软件使用

1. 左侧列表选择文件，之后点击 Merge 按钮。
2. 中间的文本框显示一些信息，注意最后一行，看有多少行被程序修改合并了。右侧文本框用于显示预览。
3. 点击 Save 按钮保存。
4. 保存后的文件最后一行会有哪些行号的内容被改变了，帮助挑选新增未翻译的文本。翻译后手动删除即可。

### 已知bug
0. 因为没有做异步和按钮失效，处理大文件时一定耐心等待，确定中间和右侧文本框都更新完成了再进行下一步操作。
1. 因为目前没有加入任何错误处理，因此程序很可能各种报错，遇到后重新打开即可。不点Save是不会损坏yml文件的。
目前合并文本使用的方法是：根据变量名在汉化文本中依次查询，遇到相同变量则将英文替换为中文，查询不到则标记为新插入的，将所有插入的行号记录在yml文件末尾。（应该有更好的算法。。。T.T）


## for HOI4, Stellaris

### Prepare

0. .NET Framework 4.5 is required.
1. Put original *_l_english.yml into Folder eng.
2. Put translated ymls into Folder chn.
3. Run pdx-ymlmerger.exe

### Merger Usages

1. Select File in the left listbox. Click Merge Button.
2. Infos will show in textboxes. The last line of middle textbox will tell how many lines was modified. Textbox in the right is used for preview saving.  
3. Click Save Button to save.
4. Line numbers will recorded in the last line of yml, if modified.

