using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithTipesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductWithTipesAndBrandsSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public ProductWithTipesAndBrandsSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}