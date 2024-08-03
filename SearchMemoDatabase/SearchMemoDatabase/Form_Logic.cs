using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMemoDatabase
{
    internal class Form1_Logic
    {
        ///<summary>
        ///登録ボタン押下の処理
        ///</summary>
        public void RegisterMethod()
        {
            string strSQL = "";

            strSQL = "INSERT INTO ";
            strSQL += "(";
            strSQL += "  title";
            strSQL += ", content ";
            strSQL += ", search_text";
            strSQL += ", created_at";
            strSQL += ", updatede_at";
            strSQL += ", is_deleted";
            strSQL += ") VALUES";
            strSQL += "(";
            strSQL += " 'testタイトル'";
            strSQL += ", '本文テスト'";
            strSQL += ", 'サーチ用'";
            strSQL += ", '作成日'";
            strSQL += "";

        }
    }
}
