using System;
namespace TodoListApp
{
    public class TodoItem
    {
        public String TodoText
        {
            get;set;
        }
        public bool Complete
        {
            get; set;
        }
        public TodoItem(String TodoText,bool Complete)
        {
            this.TodoText = TodoText;
            this.Complete = Complete;
        }
    }
}
