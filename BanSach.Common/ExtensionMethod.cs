﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BanSach.Common
{
    public static class ExtensionMethod
    {
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool check, Expression<Func<TSource, bool>> predicate)
        {

            if (check)
            {
                return source.Where(predicate);
            }
            return source;
        }
        public static T SetInfoPaging<T>(this T entityToInsert, int page_num, int? page_size = null)
        {
            Type t = entityToInsert.GetType();
            PropertyInfo md_page_num = t.GetProperty("page_num");
            if (md_page_num != null)
            {
                md_page_num.SetValue(entityToInsert, page_num, null);
            }
            if (page_size != null)
            {
                PropertyInfo md_page_size = t.GetProperty("page_size");
                if (md_page_size != null)
                {
                    md_page_size.SetValue(entityToInsert, page_num, null);
                }
            }
            return entityToInsert;
        }
    }
}
