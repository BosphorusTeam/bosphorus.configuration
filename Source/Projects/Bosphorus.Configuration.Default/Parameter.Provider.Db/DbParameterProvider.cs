using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bosphorus.Configuration.Core.Parameter.Provider;
using Bosphorus.Dao.Core.Dao;

namespace Bosphorus.Configuration.Default.Parameter.Provider.Db
{
    public class DbParameterProvider<TModel>: IParameterProvider
        where TModel: IParameterModel
    {
        private readonly IDao<TModel> parameterDao;

        public DbParameterProvider(IDao<TModel> parameterDao)
        {
            this.parameterDao = parameterDao;
        }

        public string Name { get; private set; }

        public bool Contains(string key)
        {
            throw new NotImplementedException();
        }

        public TValue GetValue<TValue>(string key)
        {
            TModel parameterModel = parameterDao.Query().FirstOrDefault(x => x.Name == key);
            string value = parameterModel.Value;
            return (TValue) Convert.ChangeType(value, typeof(TValue));
        }
    }
}
