using RecipeBook.Communication.Requests;
using RecipeBook.Communication.Responses;

namespace RecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRequestUserJson Execute(RequestRegisterUserJson request)
        {
            ValidateRequest(request);


            return new ResponseRequestUserJson
            {
                Name = request.Name,
            };
        }

        private void ValidateRequest(RequestRegisterUserJson request)
        {
            var validator = new RegisterUserValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage);

                throw new Exception();
            }
        }
    }
}
