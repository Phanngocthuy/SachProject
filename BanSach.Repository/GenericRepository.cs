using BanSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanSach.Repository
{
    public class GenericRepository<T> where T:class
    {
        protected readonly QuanLyBanSachEntities db;
        public GenericRepository()
        {
            db = new QuanLyBanSachEntities();
        }
    }
}
