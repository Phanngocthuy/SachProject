using BanSach.Common;
using BanSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanSach.Repository
{
    public interface IAccount_Repository
    {
        ResponseData<Account> CheckLogin(Account model);
    }
    public class Account_Repository : GenericRepository<Account>, IAccount_Repository
    {
        public ResponseData<Account> CheckLogin(Account model)
        {
            throw new NotImplementedException();
        }
    }
}
