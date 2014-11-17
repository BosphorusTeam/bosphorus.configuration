using System;
using System.Linq;
using Bosphorus.Configuration.Core;
using Bosphorus.Dao.Core.Dao;

namespace Bosphorus.Configuration.Default.Database
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
