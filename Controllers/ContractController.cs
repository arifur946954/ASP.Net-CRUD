using ContractApi.Data;
using ContractApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContractApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractController : Controller
    {
        private readonly ContactsAPPIDbContext dbContext;

        public ContractController(ContactsAPPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        /* [HttpGet]
         public async Task<IActionResult> GetContracts()
         {
             return Ok(await dbContext.contracts.ToListAsync());

         }*/
        //chatgpt get 

        [HttpGet]
        public ActionResult<IEnumerable<Contracts>> GetContracts()
        {
            var contracts = dbContext.contracts.Include(a => a.Books).ToList();
            return Ok(contracts);
        }





        //get single id
        /* [HttpGet]
         [Route("{id:guid}")]
         public async Task<IActionResult> FindSingleContract([FromRoute] Guid id)
         {
             var contract = await dbContext.contracts.FindAsync(id);
             if (contract == null)
             {
                 return NotFound();
             }
             return Ok(contract);
         }*/
        /*    [HttpPost]
           // public async Task<IActionResult> AddContract(AddContracts addContracts)
                public async Task<IActionResult> AddContract(Contracts addContracts)
            {
                var contract = new Contracts()
                {
                    Id = Guid.NewGuid(),
                    FullName = addContracts.FullName,
                    Email = addContracts.Email,
                    Phone = addContracts.Phone,
                    Address = addContracts.Address

                };
                await dbContext.contracts.AddAsync(contract);
                await dbContext.SaveChangesAsync();
                return Ok(contract);



            }*/

        //post mapping from chatGpt
        [HttpPost]
        public ActionResult<Contracts> CreateAuthor(Contracts contracts)
        {
            dbContext.contracts.Add(contracts);
            dbContext.SaveChanges();

            return CreatedAtAction(nameof(GetContracts), new { id = contracts.Id }, contracts);
        }




      /*  [HttpPut]
        [Route("{id:guid}")]
        //FromRoute==id comes from route, Guid=Tpe of id, id=inside route declear id;
        public async Task<IActionResult> UpdateContract([FromRoute] Guid id, UpdateContractRequest updateContractRequest)
        {
            var contract = await dbContext.contracts.FindAsync(id);
            if (contract != null)
            {
                contract.FullName = updateContractRequest.FullName;
                contract.Email = updateContractRequest.Email;
                contract.Phone = updateContractRequest.Phone;
                contract.Address = updateContractRequest.Address;
                await dbContext.SaveChangesAsync();
                return Ok(contract);
            }
            return NotFound();
        }*/

       /* [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteContract([FromRoute] Guid id)
        {
            var contract = await dbContext.contracts.FindAsync(id);
            if (contract != null)
            {
                dbContext.Remove(contract);
                await dbContext.SaveChangesAsync();
                return Ok(contract);
            }
            return NotFound();

        }*/
    }
}
