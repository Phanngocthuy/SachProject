using BanSach.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanSach.Service
{
    public class GenericService<T> where T : class
    {
        protected readonly ITopic_Repository topic_Repository;
        public GenericService()
        {
            topic_Repository = new Topic_Repository();
        }
    }
}
