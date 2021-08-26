using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationReflection
{
    public class handlingcustomException : Exception
    {
        public enum ExceptionType
        {
            WRONG_INPUT
        }
        private readonly ExceptionType type;
        public handlingcustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
