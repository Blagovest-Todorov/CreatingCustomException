using System;

namespace Person
{
    public class InvalidEmailException : Exception
    {        
        public InvalidEmailException(string mess) :
            base(mess)
        {
            
        }
    }
}
