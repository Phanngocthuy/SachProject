using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BanSach.Model
{
    [MetadataType(typeof(Topic.MetaData))]
    public partial class Topic
    {
        public int? page_num { get; set; }
        public int? page_size { get; set; }
        sealed class MetaData
        {
            public string IsActive { get; set; }
            public int TopicID { get; set; }
            public string Topic_Name { get; set; }
        }
    }
}
