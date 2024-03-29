﻿using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        IEnumerable<Product> GetLastestProducts(int n, bool trackChanges);
        IEnumerable<Product> GetAllProductsWithDetails(ProductRequestParameters p);
        Product? GetOneProduct(int id, bool trackChanges);
        IEnumerable<Product> GetShowcaseProducts(bool trackChanges);    
        void UpdateOneProduct(ProductDtoForUpdate productDto);
        void DeleteOneProduct(int id);
        void CreateProduct(ProductDtoForInsertion productDto);
        ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges);
    }
}
