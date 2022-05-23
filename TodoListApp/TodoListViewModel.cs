using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
namespace TodoListApp
{
    public class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems
        {
            get;set;
        }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem(" todo1",true));
            TodoItems.Add(new TodoItem(" todo2", false));
            TodoItems.Add(new TodoItem(" todo3", false));

        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);

        public String NewTodoInputValue { get; set; }

        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));

        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);


        void RemoveTodoItem(object o)
        {
            TodoItem todoItem = o as TodoItem;
            TodoItems.Remove(todoItem);

        }
    }
}
