using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoAppClient
{
    public class TodoService
    {
        private readonly IMobileServiceClient msc;
        private readonly IMobileServiceTable<TodoItem> mst;

        public TodoService()
        {
            msc = new MobileServiceClient("http://192.168.1.2:45455");
            mst = msc.GetTable<TodoItem>();
        }

        public async Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
        {
            return await mst.ReadAsync();
        }

        public async Task AddTodoItemAsync(TodoItem ti)
        {
            await mst.InsertAsync(ti);
        }

        public async Task UpdateTodoItemAsync(TodoItem ti)
        {
            await mst.UpdateAsync(ti);
        }
    }
}
