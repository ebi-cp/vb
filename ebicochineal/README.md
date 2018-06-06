## VisualBasicで解いてみた  
むかしゴルフで１度だけ使ったことはある  
提出数少ない１位取れそう  
C#知っていれば結構書ける（ローカルでは）  
#### かなりバージョンが古いらしいのと、コンパイルエラーでメッセージ出ないため何がだめなのか、さっぱり分からない  
#### AtCoderではLinq(Select)使えないっぽい？  
#### ToListとかも使えないっぽい  
#### for eachの型省略してもローカルのだとエラー出なかったけどAtCoderではコンパイルエラーでる  
#### あとはバージョンが古いせいかもしれないけど遅い  
遅いというよりなんか起きてそう  
[abc094 C TLEしてみた](https://abc094.contest.atcoder.jp/submissions/all?task_screen_name=arc095_a&language_screen_name=vbnc_4.2.2.30&status=TLE)  
[abc094 C AC](https://abc094.contest.atcoder.jp/submissions/2551524)  
ローカルではC#とかわらない速度が出ていたけどAtCoderでは４倍くらい時間かかった  
TLEの原因は配列を変数に入れるときに型を書かなかったことでObject型になってこれをInt.Parseするとローカルの環境の１００倍近く遅くなった  
#### Long型をModするとなんかWAになる自分で書いた方がよさそう  
[agc024 A WA](https://agc024.contest.atcoder.jp/submissions/2548261)  
[agc024 A WA](https://agc024.contest.atcoder.jp/submissions/2549224)  
[agc024 A AC](https://agc024.contest.atcoder.jp/submissions/2549215)  
[agc024 A AC](https://agc024.contest.atcoder.jp/submissions/2549319)