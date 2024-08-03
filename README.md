メモDBテスト

・ツール起動時にツールと同階層にフォルダ生成、SQLiteのDBファイルを生成したフォルダ内に格納する  
・メモ登録時に半角カタカナに変換し検索専用列に格納する、ひらがな、カタカナ、大文字小文字のどれでもヒットするようにする  
・SQL発行時にユーザ指定キーワードをCOUNTし、頻出度で重みづけし関連度の高いレコードをより上位に表示する  

下記宮島作成ですので興味があればご覧ください
すべて[SerchMemoDatabaseフォルダ]直下に格納されています。  
・App.Config →　設定ファイル  
・ClsLibrary.cs　→　共通処理、初期処理等の格納場所、クラスごと宮島作成  
・Form1.cs　→　フォームの情報を取り処理する。処理の本体はForm_Logic.csあたりに記述予定  
・Form2_詳細画面.cs　→　フォームの情報を読み取り処理をする。上記同様  
・Form_Logic.sc →　クラスごと宮島作成、フォームごとの処理を記述する  
・Program.cs　→　自動生成、ClsLibraryに追加した初期処理を呼び出す処理を追加  
