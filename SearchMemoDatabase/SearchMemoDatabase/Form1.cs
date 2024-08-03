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
        /// êVãKìoò^É{É^Éìâüâ∫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form1_MainMenu form1 = new();
            Form2_è⁄ç◊âÊñ  form2 = new Form2_è⁄ç◊âÊñ ();

            //èåèÇ…âΩÇ‡èëÇ¢ÇƒÇ¢Ç»ÇØÇÍÇŒìoò^ÉÇÅ[ÉhÇ∆ÇµÇƒâÊñ ëJà⁄
            if ((form1.txtAndSearch?.Text ?? "") == "" && (form1.txtOrSearch?.Text ?? "") == "")
            {
                form2.ShowDialog();
                return;
            }


            //èåèÇ™Ç†ÇÍÇŒåüçıÉÇÅ[ÉhÇ∆ÇµÇƒèàóù
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
