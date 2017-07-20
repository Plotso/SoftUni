using System;

namespace LiveDemo.Utilities
{
    public static class Validator
    {
        public static double ValidateSizes(double size)
        {
            if (size < 2 || 20 < size)
            {
                throw new ArgumentException();
            }
            else
            {
                return size;
            }
        }

        public static object ValidateForNull(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return obj; 
            }
        }
    }
}
