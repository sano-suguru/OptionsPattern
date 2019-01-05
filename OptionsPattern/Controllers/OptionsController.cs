using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionsPattern.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class OptionsController: ControllerBase {
    private readonly MyOptions options;
    private readonly MySubOptions subOptions;

    public OptionsController(
      IOptionsMonitor<MyOptions> optionsMonitor,
      IOptionsMonitor<MySubOptions> subOptionsMonitor
    ) {
      options = optionsMonitor.CurrentValue;
      subOptions = subOptionsMonitor.CurrentValue;
    }

    [HttpGet]
    public IActionResult GetOptions() {
      return Ok(options);
    }

    [HttpGet("sub")]
    public IActionResult GetSubOptions() {
      return Ok(subOptions);
    }
  }
}
