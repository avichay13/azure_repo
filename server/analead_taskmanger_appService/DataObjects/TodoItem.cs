using Microsoft.Azure.Mobile.Server;

namespace analead_taskmanger_appService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}