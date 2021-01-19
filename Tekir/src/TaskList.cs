using System.Collections.Generic;

namespace Tekir
{
    public class TaskList : IMarkdown
    {
        public IEnumerable<TaskListItem> TaskItems;
        public TaskList()
        {

        }

        public TaskList(IEnumerable<TaskListItem> items)
        {
            TaskItems = items;
        }

        public override string ToString()
        {
            var item = string.Empty;

            foreach (var taskItem in TaskItems)
            {
                var itemState = taskItem.State == TaskItemState.Done ? "x" : " ";
                item += string.Concat("- [", itemState, "] ", taskItem.Text, " ", taskItem.Markdown?.ToString() ?? "", "\n");
            }

            return item;
        }
    }

    public class TaskListItem
    {
        public string Text;
        public TaskItemState State;
        public IMarkdown Markdown;

        public TaskListItem()
        {

        }
        public TaskListItem(string text, TaskItemState state)
        {
            Text = text;
            State = state;
        }
        public TaskListItem(string text, TaskItemState state, IMarkdown markdown)
        {
            Text = text;
            State = state;
            Markdown = markdown;
        }
    }

    public enum TaskItemState
    {
        Open = 0,
        Done = 1
    }
}