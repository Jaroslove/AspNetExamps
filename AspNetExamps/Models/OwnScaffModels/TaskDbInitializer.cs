using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetExamps.Models.OwnScaffModels
{
    public class TaskDbInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            for (int i = 1; i < 1001; i++)
            {
                context.Tasks.Add(new Task { ID = i, Name = $"name is {i}", IsDone = false });
            }            

            base.Seed(context);
        }
    }
}