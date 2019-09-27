# MapCreator
## Unityでざっくりしたマップの形を作るだけのプログラム。  
### 内容物
- Scripts/MapCreator.cs  
このスクリプトを空のオブジェクトにアタッチし、次の項目を設定すると簡易的な3Dマップを作成します。  
    - MapBlock : ベースとなるブロックです。下地になる色の`Cube`のPrefabをアタッチしてね。
    - CoverBlock : 上をカバーするブロックです。草原や雪などをイメージした`Cube`のPrefabをアタッチしてね。
    - MapData : CSVファイルの一行目にマップサイズ(X,Y)2行目以降に高さを記録したファイルをアタッチしてね。
    - ObjectScale : Cubeのオブジェクトの高さをここで設定できます。
    - MapObj : これに空のオブジェクトをアタッチするとそのオブジェクトの子に、何もアタッチしないとこのスクリプトがついたオブジェクトの子オブジェクトになります。そのままだと`Hierarchy`がやばいことになるので…。

### イメージ図
![image](https://user-images.githubusercontent.com/17357179/65772382-0d2d3300-e175-11e9-8250-f46aa8cf8f57.png)