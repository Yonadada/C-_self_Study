namespace YokiKiosk
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //ProductCard 를 만들때 사용한 이벤트
        //private void productCard1_Clicked(object sender, YokiKiosk.Components.Products.IProductCard e)
        //{
        //    MessageBox.Show($"{e.Title}, {e.Price}");
        //}

        private void productList1_ItemClicked(object sender, YokiKiosk.Models.Product e)
        {

        }
    }
}
