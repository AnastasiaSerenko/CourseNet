using System;

namespace ThreeDimensionalShapes
{
    public class IncorrectValuesException : Exception
    {
        public IncorrectValuesException()
        { 
        }

        public IncorrectValuesException(string message)
            : base(message)
        { 
        }

        public IncorrectValuesException(string message, Exception inner)
           : base(message, inner)
        {
        }
    }
}
