using BanSach.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanSach.Service
{
    public interface ITopic_Service
    {
        IPagedList<Topic> PagedListNonAjax(Topic search);
    }
    public class Topic_Service : GenericService<Topic>, ITopic_Service
    {
        public IPagedList<Topic> PagedListNonAjax(Topic search)
        {
            if (search==null)
            {
                search = new Topic();
            }
            search.page_num = search.page_num ?? 1;
            search.page_size = search.page_size ?? 10;
            return topic_Repository.PagedListNonAjax(search);
        }
    }
}
