namespace SearchMemoDatabase
{
    partial class Form1_MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_MainMenu));
            label1 = new Label();
            btnSearch = new Button();
            txtAndSearch = new TextBox();
            txtOrSearch = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            resultDataGritView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)resultDataGritView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.UseWaitCursor = true;
            // 
            // btnSearch
            // 
            resources.ApplyResources(btnSearch, "btnSearch");
            btnSearch.Name = "btnSearch";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.UseWaitCursor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAndSearch
            // 
            resources.ApplyResources(txtAndSearch, "txtAndSearch");
            txtAndSearch.Name = "txtAndSearch";
            txtAndSearch.UseWaitCursor = true;
            // 
            // txtOrSearch
            // 
            resources.ApplyResources(txtOrSearch, "txtOrSearch");
            txtOrSearch.Name = "txtOrSearch";
            txtOrSearch.UseWaitCursor = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.UseWaitCursor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.UseWaitCursor = true;
            // 
            // resultDataGritView
            // 
            resultDataGritView.AllowUserToAddRows = false;
            resultDataGritView.AllowUserToDeleteRows = false;
            resultDataGritView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(resultDataGritView, "resultDataGritView");
            resultDataGritView.Name = "resultDataGritView";
            resultDataGritView.ReadOnly = true;
            resultDataGritView.UseWaitCursor = true;
            // 
            // Form1_MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultDataGritView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(txtOrSearch);
            Controls.Add(txtAndSearch);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Name = "Form1_MainMenu";
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)resultDataGritView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private TextBox txtAndSearch;
        private TextBox txtOrSearch;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private DataGridView resultDataGritView;
    }
}
