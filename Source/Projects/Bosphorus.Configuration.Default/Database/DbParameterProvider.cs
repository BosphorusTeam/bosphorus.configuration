using System;
using System.Linq;
using Bosphorus.Configuration.Core;
using Bosphorus.Dao.Core.Dao;

namespace Bosphorus.Configuration.Default.Database
{
    public class DbParameterProvider<TModel>: AbstractParameterProvider, IDbParameterProvider<TModel>
        where TModel: IParameterModel
    {
        private readonly IDao<TModel> parameterDao;

        public DbParameterProvider(IDao<TModel> parameterDao)
        {
            this.parameterDao = parameterDao;
        }

        protected override bool ContainsInternal(string parameterName)
        {
            throw new NotImplementedException();
        }

        protected override TValue GetValueInternal<TValue>(string parameterName)
        {
            TModel parameterModel = parameterDao.Query().FirstOrDefault(x => x.Name == parameterName);
            string value = parameterModel.Value;
            return (TValue)Convert.ChangeType(value, typeof(TValue));
        }
    }
}
