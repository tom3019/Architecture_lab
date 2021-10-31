namespace Architecture_lab.Repositories.Infra.Helper
{
    public interface IApiHelper<T> where T : class
    {
        T GetAsync(string url);

        T PostAsync(string url, object content);
    }
}