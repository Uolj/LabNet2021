using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CategoriesLogic : ClassesLogic, IDbActions
    {
        public override String ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Categories category in GetAll<Categories>())
            {
                sb.AppendLine($"{category.CategoryID}-{category.CategoryName}-{category.Description}");
            }
            return sb.ToString();
        }
        public void Add<T>(T insertedObject)
        {

            object category = insertedObject;
            context.Categories.Add((Categories)category);
            context.SaveChanges();

        }

        public void DataCheck<T>(T checkedObject)
        {
            object category = checkedObject;
            if (((Categories)category).CategoryName.Length > 15)
            {
                throw new CharacterLimitExceededException();
            }
            else if (string.IsNullOrEmpty(((Categories)category).CategoryName))
            {
                throw new FormatException();
            }
        }

        public void Delete(int id)
        {

            if (id <= 8 && id >= 1)

            if (id <= 8 && id>=1)
            {
                throw new DeleteConstraintException();
            }
            else
            {
                var itemToRemove = context.Categories.Single(x => x.CategoryID == id);
                context.Categories.Remove(itemToRemove);
                context.SaveChanges();
            }
        }

        public void Update<T>(T updatedItem)
        {
            object updatedCategory = updatedItem;
            var itemToUpdate = context.Categories.Single(x => x.CategoryID == ((Categories)updatedCategory).CategoryID);
            itemToUpdate.CategoryID = ((Categories)updatedCategory).CategoryID;
            itemToUpdate.CategoryName = ((Categories)updatedCategory).CategoryName;
            itemToUpdate.Description = ((Categories)updatedCategory).Description;
            context.SaveChanges();
        }
    }
}
