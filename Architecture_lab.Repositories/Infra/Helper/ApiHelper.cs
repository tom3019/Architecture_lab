using System;

namespace Architecture_lab.Repositories.Infra.Helper
{
    public class ApiHelper<T> : IApiHelper<T> where T : class
    {
        public T GetAsync(string url)
        {
            throw new NotImplementedException();
        }

        public T PostAsync(string url, object content)
        {
            throw new NotImplementedException();
        }
    }
}