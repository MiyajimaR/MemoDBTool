using System;
using System.Windows.Forms;

namespace SearchMemoDatabase
{
    public partial class Form1_MainMenu : Form
    {
        public Form1_MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 新規登録ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form1_MainMenu form1 = new();
            Form2_詳細画面 form2 = new Form2_詳細画面();

            //条件に何も書いていなければ登録モードとして画面遷移
            if ((form1.txtAndSearch?.Text ?? "") == "" && (form1.txtOrSearch?.Text ?? "") == "")
            {
                form2.ShowDialog();
                return;
            }


            //条件があれば検索モードとして処理
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                Action act = () => { Form1_Logic frm = new Form1_Logic(); frm.RegisterMethod(); };
                act();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
