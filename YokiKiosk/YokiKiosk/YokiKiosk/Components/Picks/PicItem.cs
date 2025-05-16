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
        public event EventHandler? CountChanged;


        // ID는 상품 클릭시 상품을 구별하기 위한 번호
        public int ID { get; set; }
        // 상품 이름
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value.Trim(); }
        // 상품 이미지
        public Image Image { get => picBox.Image; set => picBox.Image = value; }

        //지금 담긴 수량
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 1) return; //수량이 0이하면 막기
                _count = value;//수량을 설정
                lblCount.Text = _count.ToString(); // 수량을 화면에 보여줌
                SetSumPrice();// 수량증가시 가격도 변경되는 메서드 호출하고 총가격 계산해서 화면 표시
                CountChanged?.Invoke(this, EventArgs.Empty); // 수량이 변경되었음을 알림
            }
        }
        //1개당 가격
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
