using Microsoft.AspNetCore.Mvc;
using SuppliersAPI.Repositories;

namespace SuppliersAPI.Controllers
{
    [Route("api/suppliers")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierRepository _repository;

        public SuppliersController(ISupplierRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Obtém todos os fornecedores cadastrados.
        /// </summary>
        /// <returns>Lista de fornecedores.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuppliersAPI.Models.Supplier>>> GetSuppliers()
        {
            return Ok(await _repository.GetAllAsync());
        }

        /// <summary>
        /// Obtém um fornecedor pelo ID.
        /// </summary>
        /// <param name="id">ID do fornecedor</param>
        /// <returns>Fornecedor correspondente ao ID</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<SuppliersAPI.Models.Supplier>> GetSupplier(int id)
        {
            var supplier = await _repository.GetByIdAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return Ok(supplier);
        }

        /// <summary>
        /// Cadastra um novo fornecedor.
        /// </summary>
        /// <param name="supplier">Dados do fornecedor</param>
        /// <returns>Fornecedor criado</returns>
        [HttpPost]
        public async Task<ActionResult<SuppliersAPI.Models.Supplier>> PostSupplier(SuppliersAPI.Models.Supplier supplier)
        {
            await _repository.AddAsync(supplier);
            return CreatedAtAction(nameof(GetSupplier), new { id = supplier.Id }, supplier);
        }

        /// <summary>
        /// Atualiza um fornecedor existente.
        /// </summary>
        /// <param name="id">ID do fornecedor</param>
        /// <param name="supplier">Novos dados do fornecedor</param>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, SuppliersAPI.Models.Supplier supplier)
        {
            if (id != supplier.Id)
            {
                return BadRequest();
            }
            await _repository.UpdateAsync(supplier);
            return NoContent();
        }

        /// <summary>
        /// Exclui um fornecedor pelo ID.
        /// </summary>
        /// <param name="id">ID do fornecedor</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
