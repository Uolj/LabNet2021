using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ShippersLogic : ClassesLogic, IDbActions
    {

        public override String ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Shippers shippers in GetAll<Shippers>())
            {
                sb.AppendLine($"{shippers.ShipperID}-{shippers.CompanyName}-{shippers.Phone}");
            }
            return sb.ToString();
        }
        public void Add<T>(T insertedObject)
        {

            object shipper = insertedObject;
            context.Shippers.Add((Shippers)shipper);
            context.SaveChanges();

        }

        public void DataCheck<T>(T checkedObject)
        {
            object shipper = checkedObject;
            if (((Shippers)shipper).CompanyName.Length > 40 || ((Shippers)shipper).Phone.Length > 24)
            {
                throw new CharacterLimitExceededException();
            }else if (string.IsNullOrEmpty(((Shippers)shipper).CompanyName))
            {
                throw new FormatException();
            }
        }

        public void Delete(int id)
        {
            var itemToRemove = context.Shippers.Single(x => x.ShipperID == id);
            context.Shippers.Remove(itemToRemove);
            context.SaveChanges();
        }

        public void Update<T>(T updatedItem)
        {
            object updatedShipper = updatedItem;
            var itemToUpdate = context.Shippers.Single(x => x.ShipperID == ((Shippers)updatedShipper).ShipperID);
            itemToUpdate.ShipperID = ((Shippers)updatedShipper).ShipperID;
            itemToUpdate.CompanyName = ((Shippers)updatedShipper).CompanyName;
            itemToUpdate.Phone = ((Shippers)updatedShipper).Phone;
            context.SaveChanges();
        }
    }
}
