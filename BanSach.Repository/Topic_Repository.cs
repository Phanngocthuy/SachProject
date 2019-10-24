using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanSach.Common;
using BanSach.Model;
using PagedList;

namespace BanSach.Repository
{
    public interface ITopic_Repository
    {
        IPagedList<Topic> PagedListNonAjax(Topic model);
    }
    public class Topic_Repository : GenericRepository<Topic>, ITopic_Repository
    {
        public IPagedList<Topic> PagedListNonAjax(Topic model)
        {
            return db.Topics.
                WhereIf(!string.IsNullOrEmpty(model.Topic_Name), n => n.Topic_Name.Contains(model.Topic_Name))
                .OrderBy(n => n.Topic_Name)
                .ToPagedList(model.page_num.Value, model.page_size.Value);
        }
    }
}
