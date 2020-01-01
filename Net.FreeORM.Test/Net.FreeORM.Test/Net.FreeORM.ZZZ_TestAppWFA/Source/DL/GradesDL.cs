using System;
using Net.FreeORM.Extensions;
using Net.FreeORM.Framework.BaseDal;
using System.Collections.Generic;
using Net.FreeORM.ZZZ_TestAppWFA.Source.BO;
using Net.FreeORM.Framework.Base;
using Net.FreeORM.Framework.QueryBuilding;
using System.Data;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.DL
{
    public class GradesDL : BaseDL
    {
        public GradesDL()
            : base()
        {
        }

        public List<Grades> GetTableAsList()
        {
            return base.GetTableAsList<Grades>();
            /*
            QueryBuilder queryBuilder = CreateQueryBuilder(QueryTypes.Select, new Grades());
            DataTable dt = GetResultSetOfQuery(queryBuilder.QueryString, queryBuilder.Properties).Tables[0];
            return dt.ToList<Grades>(true);
             * */
        }

    }
}
