﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_project_winform.Model
{
    public class ProductModel
    {
        public int id_produk { get; set; }
        public string nama_produk { get; set; }
        public int harga { get; set; }
        public string deskripsi { get; set; }
    }
}