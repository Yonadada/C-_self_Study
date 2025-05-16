namespace YokiKiosk
{
    partial class FrmMain
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
            Models.Product product6 = new Models.Product();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            Models.Product product7 = new Models.Product();
            Models.Product product8 = new Models.Product();
            Models.Product product9 = new Models.Product();
            Models.Product product10 = new Models.Product();
            headerControl1 = new YokiKiosk.Components.HeaderControl();
            productList1 = new YokiKiosk.Components.Products.ProductList();
            SuspendLayout();
            // 
            // headerControl1
            // 
            headerControl1.Description = "저희 음식점은 국내산만 사용합니다.\r\n누구나 즐길 수 있는 합리적인 가격으로 모시겠습니다.";
            headerControl1.Dock = DockStyle.Top;
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(1189, 150);
            headerControl1.TabIndex = 0;
            headerControl1.Title = "요키네 음식점에 오신 것을 환영합니다";
            // 
            // productList1
            // 
            product6.ID = 1;
            product6.Image = (Image)resources.GetObject("product6.Image");
            product6.Price = new decimal(new int[] { 2000, 0, 0, 0 });
            product6.Title = "사과";
            product7.ID = 2;
            product7.Image = (Image)resources.GetObject("product7.Image");
            product7.Price = new decimal(new int[] { 23000, 0, 0, 0 });
            product7.Title = "치킨";
            product8.ID = 3;
            product8.Image = (Image)resources.GetObject("product8.Image");
            product8.Price = new decimal(new int[] { 2500, 0, 0, 0 });
            product8.Title = "초코칩";
            product9.ID = 4;
            product9.Image = (Image)resources.GetObject("product9.Image");
            product9.Price = new decimal(new int[] { 6400, 0, 0, 0 });
            product9.Title = "햄버거";
            product10.ID = 5;
            product10.Image = (Image)resources.GetObject("product10.Image");
            product10.Price = new decimal(new int[] { 5400, 0, 0, 0 });
            product10.Title = "아이스크림";
            productList1.Items.Add(product6);
            productList1.Items.Add(product7);
            productList1.Items.Add(product8);
            productList1.Items.Add(product9);
            productList1.Items.Add(product10);
            productList1.Location = new Point(12, 156);
            productList1.Name = "productList1";
            productList1.Size = new Size(540, 444);
            productList1.TabIndex = 2;
            productList1.ItemClicked += productList1_ItemClicked;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 657);
            Controls.Add(headerControl1);
            Controls.Add(productList1);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Components.HeaderControl headerControl1;
        private Components.Products.ProductList productList1;
    }
}
