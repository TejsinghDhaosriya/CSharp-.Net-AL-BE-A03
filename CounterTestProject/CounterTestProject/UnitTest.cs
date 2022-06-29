using SingletonDesignPatternConsoleApp;
namespace CounterTestProject
{
    public class UnitTest
    {
        [Fact]
        public void ShouldReturnCounterValue()
        {
            Counter counter = Counter.GetInstance;
            ResetCounter(counter);
            int value = counter.Count();

            Assert.Equal(0,value);

        }

        [Fact]
        public void ShouldIncrementCounterValue()
        {
            Counter counter = Counter.GetInstance;
            ResetCounter(counter);
            counter.Increment();
            counter.Increment();
            counter.Increment();

            int value = counter.Count();

            Assert.Equal(3, value);

        }


        [Fact]
        public void ShouldDecrementCounterValue()
        {
            Counter counter = Counter.GetInstance;
            ResetCounter(counter);
            counter.Increment();
            counter.Increment();
            counter.Decrement();

            var value = counter.Count();

            Assert.Equal(1, value);

        }


        private static void ResetCounter(Counter counter)
        {
            var initialValue = counter.Count();
            foreach (var value in Enumerable.Range(0, initialValue).Reverse())
            {
              counter.Decrement();
            }
        }
    }
}