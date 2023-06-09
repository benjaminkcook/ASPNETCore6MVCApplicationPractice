﻿namespace ASPNETCore6._0Practice.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pies", Description="All-fruity pies"},
                new Category{CategoryId=2, CategoryName="Cheese Cakes", Description="Ooeygooey cheesy cake"},
                new Category{CategoryId=3, CategoryName="Seasonal Pies", Description="Get in the mood for a seasonal pie"}
            };
    }
}
