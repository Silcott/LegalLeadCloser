using LLC.Application.Specifications.Base;
using LLC.Domain.Entities.Catalog;

namespace LLC.Application.Specifications
{
    public class ProductFilterSpecification : HeroSpecification<Product>
    {
        public ProductFilterSpecification(string searchString)
        {
            Includes.Add(a => a.Brand);
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Barcode != null && (p.Name.Contains(searchString) || p.Description.Contains(searchString) || p.Barcode.Contains(searchString) || p.Brand.FirstName.Contains(searchString));
            }
            else
            {
                Criteria = p => p.Barcode != null;
            }
        }
    }
}