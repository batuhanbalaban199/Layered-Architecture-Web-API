using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction] //Bir endpoint olmadığını swaggera anlatmak için konuldu.
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                { StatusCode = response.StatusCode };
            return new ObjectResult(response)
            { StatusCode = response.StatusCode }; 
        }

    }
}
