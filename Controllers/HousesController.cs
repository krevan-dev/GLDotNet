using GLDotNet.Models;
using GLDotNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace GLDotNet.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService _hs;
    public HousesController(HousesService hs)
    {
      _hs = hs;
    }

    [HttpGet]
    public ActionResult<List<House>> GetAll()
    {
      try
      {
        return Ok(_hs.GetAll());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}