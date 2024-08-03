using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Data;
using System.Data.SQLite;



namespace SearchMemoDatabase
{
    internal class ClsLibrary
    {
        /// <summary>
        /// databaseファイルの完全パス
        /// </summary>
        public string DbPath { get; set; } = "";

        internal ClsLibrary()
        {
            //configからデータベースファイルを作成するフォルダを取得
            string dbPath = "";
            dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SearchMemoDatabase");
            dbPath += ConfigurationManager.AppSettings["dbpath"];

            DbPath = dbPath;
        }

        public void InitApp()
        {
            InitializeFolder();
            InitializeDatabase();
        }

        ///<summary>
        ///データベースファイルが既に作成されているかどうかを確認する
        ///</summary>
        private void InitializeFolder()
        {
            string dbFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SearchMemoDatabase");

            try
            {
                if (!Directory.Exists(dbFolder))
                {
                    Directory.CreateDirectory(dbFolder);
                    Console.WriteLine("DBフォルダを新規作成");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("フォルダー作成エラー：" + ex.Message);
            }
        }

        /// <summary>
        /// SQLiteのテーブル作成およびオープン
        /// </summary>
        private void InitializeDatabase()
        {
            using (SQLiteConnection db = new SQLiteConnection("Data Source=" + DbPath))
            {
                //DBファイルが存在しなかった場合は勝手に作成するのでOK
                db.Open();

                using (SQLiteCommand sCommand = new SQLiteCommand())
                {
                    try
                    {
                        //接続する
                        sCommand.Connection = db;

                        string strSQL = "";

                        //SQL構築
                        strSQL = "CREATE TABLE IF NOT EXISTS MAINTABLE ";
                        strSQL += "( ";
                        strSQL += " id INTEGER PRIMARY KEY AUTOINCREMENT";
                        strSQL += ", title TEXT";
                        strSQL += ", content TEXT";
                        strSQL += ", search_text TEXT ";
                        strSQL += ", created_at DATETIME DEFAULT (datetime('now','localtime'))";
                        strSQL += ", updated_at DATETIME";
                        strSQL += ", deleted_at DATETIME ";
                        strSQL += ")";

                        sCommand.CommandText = strSQL;

                        //SQL実行
                        sCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("テーブル作成エラー：" + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// SQLを渡すとデータセットを返します
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public DataSet GetDataSetSQL(string strSQL)
        {
            using (SQLiteConnection db = new SQLiteConnection("Data Source=" + DbPath))
            {
                db.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(strSQL, db);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }
    }
}
