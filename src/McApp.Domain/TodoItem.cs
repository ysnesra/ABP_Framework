using System;
using Volo.Abp.Domain.Entities;

namespace McApp
{
    public class TodoItem:BasicAggregateRoot<Guid>
    {

        public string Text { get; set; }
        public bool Active { get; set; }

    }
}
