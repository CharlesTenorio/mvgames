using System;
namespace MvGames.Domain.Validation
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(String error) : base(error)
        {
            
        }

        public static void When(bool hasError, String error)
        {
            if(hasError){
                trhow new DomainExceptionValidation(error);
            }
        }
        
    }
}