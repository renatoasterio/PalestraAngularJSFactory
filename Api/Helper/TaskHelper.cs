
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Helper
{
    public class TaskHelper<T>
    {
        static TaskHelper()
        {

        }

        public static Task<T> CreateTask(T response)
        {
            var source = new TaskCompletionSource<T>();
            source.SetResult(response);
            return source.Task;
        }

    }
}

