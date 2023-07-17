using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeoShop.Data.Models;

namespace LeoShop.Data.ViewModels
{
    public class InfoFilter
    {
        private LeoShopContext db = new LeoShopContext();

        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public List<SelectedThuongHieu> SelectedThuongHieus { get; set; }
        public bool isDongHoGiamGia { get; set; }
        public bool isDongHoThoiTrang { get; set; }
        public bool isNam { get; set; }
        public bool isNu { get; set; }
        public bool isTreEm { get; set; }
        public bool isDongHoThongMinh { get; set; }
        public InfoFilter()
        {
            MinPrice = MaxPrice = 0;
            SelectedThuongHieus = new List<SelectedThuongHieu>();
        }
    }
}