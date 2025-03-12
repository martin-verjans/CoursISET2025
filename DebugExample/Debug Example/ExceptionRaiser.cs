using System;

namespace Debug_Example
{
    internal class ExceptionRaiser
    {
        public ExceptionRaiser(int value)
        {
            DoStuff(value);
        }

        private void DoStuff(int someValue)
        {
            try
            {
                DoSomeMore(DoAnotherStuff(someValue));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while initializing raiser with value {someValue}", ex);
            }
        }

        private void DoSomeMore(string value)
        {
            throw new Exception($"Error with value : {value}");
        }

        private string DoAnotherStuff(int someValue)
        {
            switch (someValue)
            {
                case 0:
                    throw new Exception("Value is zero !!!");
                case 100:
                    throw new Exception("Value is too high");
                default:
                    try
                    {
                        return InitValue(someValue);
                    }
                    catch
                    {
                        throw new Exception("Error while init the value");
                    }
            }
        }

        private string InitValue(int someValue)
        {
            if (someValue > 30)
                throw new Exception($"Value {someValue} is too high");
            return someValue.ToString();
        }
    }
}
