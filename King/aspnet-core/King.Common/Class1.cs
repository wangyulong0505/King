using System;
using System.Threading.Tasks;

namespace King.Common
{
    public class Class1
    {
        public Task<string> GetName()
        {
            //如果平台是Net40就执行if代码，否则就执行else
            #if Net40

            var task = new Task<string>(()=>"rabbit");
            task.Start();
            return task;

            #else

            return Task.FromResult("rabbit");

            #endif
        }
    }
}
