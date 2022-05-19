using DatabaseConneciton;
using PlantsDatabaseControler.SqlCommands.InsertSqlCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsDatabaseControler.SqlCommands
{
    public class SelectQuery
    {
        public List<T> Select<T>() where T : new()
        {
            string request = _getRequest<T>();
            if (request != "" && request.ToLower().Contains("select"))
            {
                return new SqlCommand().GetSqlRequest<T>(request);
            }
            return null;
        }
        public T Select<T>(int id) where T : new()
        {
            string request = _getRequest<T>(id);
            if (request != "" && request.ToLower().Contains("select"))
            {
                return new SqlCommand().GetSqlRequest<T>(request).First<T>();
            }
            return new T();
        }

        private string _getRequest<T>(int id)
        {
            if (typeof(T) == typeof(ActualTask))
            {
                return new SelectActualTaskQuery().GetSelectQuery(id);
            }
            if (typeof(T) == typeof(CareSchedule))
            {
                return new SelectCareScheduleQuery().GetSelectQuery(id);
            }
            if (typeof(T) == typeof(Company))
            {
                return new SelectCompanyQuery().GetSelectQuery(id);
            }
            if (typeof(T) == typeof(PaletPlantsType))
            {
                return new SelectPaletPlantsTypeQuery().GetSelectQuery(id);
            }
            if (typeof(T) == typeof(Palet))
            {
                return new SelectPaletQuery().GetSelectQuery(id);
            }
            if (typeof(T) == typeof(TypeOfCare))
            {
                return new SelectTypeOfCareQuery().GetSelectQuery(id);
            }
            if (typeof(T) == typeof(UserCategory))
            {
                return new SelectUserCategoryQuery().GetSelectQuery(id);
            }
            if (typeof(T) == typeof(Users))
            {
                return new SelectUsersQuery().GetSelectQuery(id);
            }
            return "";
        }
        private string _getRequest<T>()
        {
            if (typeof(T) == typeof(ActualTask))
            {
                return new SelectActualTaskQuery().GetSelectQuery();
            }
            if (typeof(T) == typeof(CareSchedule))
            {
                return new SelectCareScheduleQuery().GetSelectQuery();
            }
            if (typeof(T) == typeof(Company))
            {
                return new SelectCompanyQuery().GetSelectQuery();
            }
            if (typeof(T) == typeof(PaletPlantsType))
            {
                return new SelectPaletPlantsTypeQuery().GetSelectQuery();
            }
            if (typeof(T) == typeof(Palet))
            {
                return new SelectPaletQuery().GetSelectQuery();
            }
            if (typeof(T) == typeof(TypeOfCare))
            {
                return new SelectTypeOfCareQuery().GetSelectQuery();
            }
            if (typeof(T) == typeof(UserCategory))
            {
                return new SelectUserCategoryQuery().GetSelectQuery();
            }
            if (typeof(T) == typeof(Users))
            {
                return new SelectUsersQuery().GetSelectQuery();
            }
            return "";
        }
    }
}
