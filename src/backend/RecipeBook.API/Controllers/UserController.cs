using Microsoft.AspNetCore.Mvc;
using RecipeBook.Application.UseCases.User.Register;
using RecipeBook.Communication.Requests;
using RecipeBook.Communication.Responses;

namespace RecipeBook.API.Controllers

{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRequestUserJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            var useCase = new RegisterUserUseCase();
            
            var result = useCase.Execute(request);

            return Created(string.Empty, result);
        }
    }
}
