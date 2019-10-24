using BanSach.Common;
using BanSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanSach.Service
{
    public interface IAccount_Service
    {
        ResponseData<Account> CheckLogin(Account model);
    }
    public class Account_Service : GenericService<Account>, IAccount_Service
    {
        public ResponseData<Account> CheckLogin(Account model)
        {
            throw new NotImplementedException();
        }
    }
}
