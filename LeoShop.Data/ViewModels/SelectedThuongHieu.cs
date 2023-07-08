using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeoShop.Data.Models;

namespace LeoShop.Data.ViewModels
{
    public class SelectedThuongHieu
    {
        public ThuongHieu ThuongHieu { get; set; }
        public bool IsSelected { get; set; }
    }
}