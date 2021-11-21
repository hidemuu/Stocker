# Stocker

興味のある商品の情報を入力すると、
価格調査、レコメンド集計、画像データから
最適な商品やメーカを提案する。
最終的な選定に必要な情報を自動出力
・安さを重視するならこのメーカ
・デザイン性を重視するならこのタイプ　等
物件を選ぶ時に、抽象的な希望からだんだん具体化していく作業を
自動化するようなイメージ。

・データスクレイピングにより作成する。
・楽天商品検索APIにて作成する。

https://haniwaman.com/rakuten-api/
https://qiita.com/Massasquash/items/ed565b8ba4fd51dca54f

好みの製品画像をいくつか入力すると、
それら全てにマッチする製品を提案する

画像データは抽象化して提案データの一つとして出力する（視覚情報）
https://qiita.com/kult/items/184126aa9ff7b5698f22



# Prerequisites

* 



### Quick start 


#### 環境設定

- ターゲットOS / フレームワーク
  Windows 10
  .Net framework 4.7.2
  .Net Standard 2.0

- 通信チャネル
  Restful Webサービス
  PostgreSQL データベース
  RabbitMQ メッセージキューイング

- 通信ポート
  REST API ： 8443
  PostgreSQL : 5432


