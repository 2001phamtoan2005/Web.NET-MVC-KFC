using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn.Models
{
    public class Cart
    {
        KFCDataContext db = new KFCDataContext();
        public string sMasp { get; set; }
        public string sTensp { get; set; }
        public string sAnh { get; set; }
        public int dGia { get; set; }
        public int iSoLuong { get; set; }
        public string sDescribe { get; set; }
        public int dThanhTien {
            get { return iSoLuong * dGia; }
        }
        public Cart(CART giohang)
        {
            sMasp = giohang.ID_PRODUCT;
            sTensp = giohang.NAME_PRODUCT;
            sAnh = giohang.IMAGE_PRODUCT;
            dGia = Convert.ToInt32(giohang.COST);
            sDescribe = giohang.DESCRIBE;
            iSoLuong = Convert.ToInt32(giohang.QUANTITY_PRODUCT);
        }

        public Cart(string masp)
        {
            sMasp = masp;
            PRODUCT sp = db.PRODUCTs.Single(t => t.ID_PRODUCT == masp);
            sTensp = sp.NAME_PRODUCT;
            sAnh = sp.IMAGE_PRODUCT;
            sDescribe = sp.DESCRIBE;
            dGia = Convert.ToInt32(sp.COST);
            iSoLuong = 1;
        }

        public Cart(string masp,int sl)
        {
            sMasp = masp;
            PRODUCT sp = db.PRODUCTs.Single(t => t.ID_PRODUCT == masp);
            sTensp = sp.NAME_PRODUCT;
            sAnh = sp.IMAGE_PRODUCT;
            sDescribe = sp.DESCRIBE;
            dGia = Convert.ToInt32(sp.COST);
            iSoLuong = sl;
        }


    }
}