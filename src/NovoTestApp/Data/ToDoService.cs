using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoTestApp.Data
{
    public class ToDoService
    {
        private List<ToDoItem> _listOfTodos;
        public ToDoService()
        {
            _listOfTodos = new List<ToDoItem> {
                new ToDoItem {Id=1, Task="Check email", Compleated=false},
                new ToDoItem {Id=2, Task="Go for coffee", Compleated=true},
                new ToDoItem {Id=3, Task="write review", Compleated=false},
                new ToDoItem {Id=4, Task="find bug", Compleated=false},
                new ToDoItem {Id=5, Task="report bug", Compleated=false},
                };
        }

        public Task<List<ToDoItem>> GetToDoItems()
        {
            return Task.FromResult(_listOfTodos);
        }
    }
}