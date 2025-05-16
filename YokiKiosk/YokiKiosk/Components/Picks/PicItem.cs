using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YokiKiosk.Components.Picks
{
    public partial class PicItem : UserControl
    {
        private int _count;
        private decimal _defaultPrice;


        void SetSumPrice()
        {
            // 수량 * 가격 = 총 가격
            lblSumPrice.Text = $"{_count * _defaultPrice:#,0} 원";
        }

        public PicItem()
        {
            InitializeComponent();
        }

        //이벤트
        public event EventHandler? DeleteClicked;


        // ID는 상품 클릭시 상품을 구별하기 위한 구분값
        public int ID { get; set; }
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value.Trim(); }
        public Image Image { get => picBox.Image; set => picBox.Image = value; }

        //수량
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 1) return;
                lblCount.Text = _count.ToString();
                SetSumPrice();// 수량증가시 가격도 변경되는 메서드 호출
            }
        }

        public decimal DefaultPrice
        {
            get { return _defaultPrice; }
            set
            {
                _defaultPrice = value;
                SetSumPrice();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Count--;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Count++;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
