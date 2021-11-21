
# ローカルサーバ起動（laravelのアプリルートパスをカレントディレクトリにする）
cd C:\Users\nando\Documents\GitHub\Stocker\src\php\stocker
php -S localhost:8000 -t public

# パッケージリスト更新
sudo yum -y update
# phpインストール
sudo yum install -y php-mbstring php-openssl php-xml unzip
# composerインストール
php -r "copy('https://getcomposer.org/installer', 'composer-setup.php');"
sudo php composer-setup.php --install-dir=/usr/local/bin --filename=composer
composer -V

# phpインストール
ls /usr/bin/php
sudo ln /usr/bin/php
sudo yum -y install http://rpms.famillecollet.com/enterprise/remi-release-7.rpm
sudo yum -y remove php php-pdo php-mbstring
sudo yum -y install php72 php72-mbstring php72-pdo
sudo ln -s /usr/bin/php72 /usr/bin/php

# パスの設定
sudo yum -y install php72-php php72-php-common php72-php-devel php72-php-manual php72-php-pdo php72-php-mbstring php72-php-json php72-php-xml
composer update

# PHPとLaravelのバージョン確認
php -v
laravel -v

# Laravelのアプリ作成
composer create-project <使用するライブラリなどの名前> <ライブラリなどをインストールするディレクトリ名> <バージョン指定などのオプション>
composer create-project --prefer-dist laravel/laravel <アプリ名> "5.8.*"


# 新しく作成したアプリのディレクトリへと移動
cd <アプリ名>

# ルート表示
php artisan route:list

# ローカルサーバーを起動する
php artisan serve --port=8080

# すべてのファイルをステージングする
git add .

# コミットメッセージと共にコミットします
git commit -m "set up bootstrap4"

# SQLiteデータベースの作成
sqlite3 database/database.sqlite
.tables
.exit

# モデルの作成
php artisan make:model <新しく作成するモデル名> 
php artisan make:model -m <モデル名>

# Controller の作成
php artisan make:controller <コントローラー名> --resource --model=<モデル名>

# マイグレーションの実行
php artisan migrate

# Tinker(コンソールでのデータ作成) 終了時はexitを入力
php artisan tinker

# シーダー作成
php artisan make:seeder CategoriesTableSeeder
# 作成したシーダーファイルを読み込み
composer dump-autoload

# Font Awesomeのインストール
npm install

# Font Awesomeインストール後にGitでコミット
git add .
git commit -m "add Font Awesome"

# rutorika-sortableをパッケージマネージャでインストール
composer require illuminate/support
composer require rutorika/sortable 7.0.0

# rutorika-sortableのインストール後にコミット
git add .
git commit -m "install rutorika-sortable"

# resources/views/layouts/app.blade.php を編集後にGitでコミット
git add .
git commit -m "change layouts/app.blade.php"

# JavaScriptのライブラリのインストール
npm install

# JavaScript/CSSのビルド
npm run dev

# Laravelのログイン/ログアウト機能を使用
php artisan make:auth



# Heroku CLI
curl -OL https://cli-assets.heroku.com/heroku-linux-x64.tar.gz && tar zxf heroku-linux-x64.tar.gz && rm -f heroku-linux-x64.tar.gz && sudo mv heroku /usr/local && echo 'PATH=/usr/local/heroku/bin:$PATH' >> $HOME/.bash_profile

# Herokuにビルドパックを追加
heroku buildpacks:set heroku/php  -a <作成するアプリ名>
heroku buildpacks:add heroku/nodejs  -a <作成するアプリ名>

# HerokuのデータベースにPostgresqlを使用
heroku addons:create heroku-postgresql:hobby-dev -a <作成するアプリ名>

# Herokuのデータベース設定を確認
heroku config:get DATABASE_URL -a <作成するアプリ名> 

# 確認したデータベース設定を環境変数として設定
heroku config:set DB_CONNECTION=pgsql -a <作成するアプリ名>
heroku config:set DB_DATABASE=<データベース名> -a <作成するアプリ名>
heroku config:set DB_HOST=<ホスト> -a <作成するアプリ名>
heroku config:set DB_PASSWORD=<パスワード> -a <作成するアプリ名>
heroku config:set DB_PORT=<ポート> -a <作成するアプリ名>
heroku config:set DB_USERNAME=<ユーザー> -a <作成するアプリ名>

# Laravelの本番環境用のキーを生成
php artisan key:generate --show

# 生成したキーを環境変数として設定
heroku config:set APP_KEY=<生成されたキー> -a <作成するアプリ名>




composer require rutorika/sortable
Using version ^8.0 for rutorika/sortable
./composer.json has been updated
Running composer update rutorika/sortable
Loading composer repositories with package information
Updating dependencies
Your requirements could not be resolved to an installable set of packages.

  Problem 1
    - Root composer.json requires rutorika/sortable ^8.0 -> satisfiable by rutorika/sortable[8.0.0].
    - rutorika/sortable 8.0.0 requires illuminate/support ^7.0|^8.0 -> found illuminate/support[v7.0.0, ..., 7.x-dev, v8.0.0, ..., 8.x-dev] but these were not loaded, likely because it conflicts with another require.


Installation failed, reverting ./composer.json and ./composer.lock to their original content.



PHP Fatal error:  Trait 'Rutorika\Sortable\SortableTrait' not found in /home/ec2-user/environment/todo_app/app/Todo.php on line 9

   Symfony\Component\Debug\Exception\FatalErrorException  : Trait 'Rutorika\Sortable\SortableTrait' not found

  at /home/ec2-user/environment/todo_app/app/Todo.php:9
     5| use Illuminate\Database\Eloquent\Model;
     6| 
     7| class Todo extends Model
     8| {
  >  9|     use \Rutorika\Sortable\SortableTrait;
    10| 
    11|     public function user()
    12|     {
    13|         return $this->belongsTo('App\User');


   Whoops\Exception\ErrorException  : Trait 'Rutorika\Sortable\SortableTrait' not found

  at /home/ec2-user/environment/todo_app/app/Todo.php:9
     5| use Illuminate\Database\Eloquent\Model;
     6| 
     7| class Todo extends Model
     8| {
  >  9|     use \Rutorika\Sortable\SortableTrait;
    10| 
    11|     public function user()
    12|     {
    13|         return $this->belongsTo('App\User');

  Exception trace:

  1   Whoops\Run::handleError("Trait 'Rutorika\Sortable\SortableTrait' not found", "/home/ec2-user/environment/todo_app/app/Todo.php")
      /home/ec2-user/environment/todo_app/vendor/filp/whoops/src/Whoops/Run.php:486

  2   Whoops\Run::handleShutdown()
      [internal]:0