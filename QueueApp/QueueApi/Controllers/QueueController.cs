using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QueueLib.Contracts;

namespace QueueApi.Controllers
{
    [Route("api/queues")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        private IQueue<string> _queue;
        public QueueController(IQueue<string> queue)
        {
            _queue = queue;
        }

        [HttpGet("peek")]
        public IActionResult Peek() 
        {
            return Ok(_queue.Peek());
        }

        [HttpPost("enqueue")]
        public IActionResult EnQeueue(string item)
        {
            _queue.EnQueue(item);
            return NoContent(); // 204
        }

        [HttpDelete("dequeue")]
        public IActionResult DeQueue()
        {
            var item = _queue.DeQeue();
            return Ok(item); // 204
        }


    }
}
