using System.Security.Cryptography;

namespace lab_10_task_02
{
    public class CounterManager
    {
        private int count=0;
        public void Increment()
        {
            count++;
        }
        public void Decrement()
        {
            count--;
        }
        public int getCount()
        {
            return count;
        }
    }
}
