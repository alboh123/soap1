using Microsoft.AspNetCore.Mvc;

namespace SoapDemo.Controllers
{
    [Route("api/soap-demo")]
    [ApiController]
    public class SoapDemoController : ControllerBase
    {
        private readonly SOAPDemoSoap _demoSoap;

        public SoapDemoController(SOAPDemoSoap demoSoap)
        {
            _demoSoap = demoSoap;
        }

        [HttpGet("add-integer")]
        public async Task<IActionResult> AddInteger(int arg1, int arg2)
        {
            try
            {
                return Ok(await _demoSoap.AddIntegerAsync(arg1, arg2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("divide-integer")]
        public async Task<IActionResult> DivideInteger(int dividendo, int divisor)
        {
            try
            {
                return Ok(await _demoSoap.DivideIntegerAsync(dividendo, divisor));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("FindPersonAsync")]
        public async Task<IActionResult> FindPersonAsync(string id)
        {
            try
            {
                return Ok(await _demoSoap.FindPersonAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetByNameAsync")]
        public async Task<IActionResult> GetByNameAsync(string name)
        {
            try
            {
                return Ok(await _demoSoap.GetByNameAsync(name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetListByNameAsync")]
        public async Task<IActionResult> GetListByNameAsync(string name)
        {
            try
            {
                return Ok(await _demoSoap.GetListByNameAsync(name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("LookupCityAsync")]
        public async Task<IActionResult> LookupCityAsync(string zip)
        {
            try
            {
                return Ok(await _demoSoap.LookupCityAsync(zip));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("MissionAsync")]
        public async Task<IActionResult> MissionAsync()
        {
            try
            {
                return Ok(await _demoSoap.MissionAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("QueryByNameAsync")]
        public async Task<IActionResult> QueryByNameAsync(string name)
        {
            try
            {
                return Ok(await _demoSoap.QueryByNameAsync(name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
