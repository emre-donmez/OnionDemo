namespace OnionDemo.MVC.src.Helpers
{
    public interface IApiRequestHelper
    {
        Task<T> GetAsync<T>(string endpoint);

        Task<T> PostAsync<T>(string endpoint, object data);
    }
}