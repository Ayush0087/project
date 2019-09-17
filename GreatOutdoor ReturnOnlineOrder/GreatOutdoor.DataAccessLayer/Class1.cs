using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoor.BusinessLayer;
using GreatOutdoor.Entity;
using GreatOutdoor.Exception;

namespace GreatOutdoor.DataAccessLayer
{
    public class OnlineReturnDAL
    {
        public static List<OnlineReturnDAL> onlineReturnList = new List<OnlineReturnDAL>();

        public bool AddOnlineReturnDAL(OnlineReturnDAL newonlineReturn)
            //adding return order
        {
            bool onlineReturnAdded = false;
            try
            {
                onlineReturnList.Add(newonlineReturn);
                onlineReturnAdded = true;
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return onlineReturnAdded;

        }

        public List<OnlineReturnDAL> GetAllGuestsDAL()
        {
            return onlineReturnList;
        }

        public OnlineReturnDAL SearchOnlineReturnDAL(int searchReturnID)
            //returnonlineorderby returnID
        {
            OnlineReturnDAL searchOnlineReturnDAL = null;
            try
            {
                foreach (OnlineReturnDAL item in onlineReturnList)
                {
                    if (item.ReturnID == searchReturnID)
                    {
                        searchOnlineReturnDAL = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchOnlineReturnDAL;
        }

        public List<OnlineReturnDAL> GetOnlineReturnByNameDAL(string onlineReturnName)
        {
            List<OnlineReturnDAL> searchOnlineReturn = new List<OnlineReturnDAL>();
            try
            {
                foreach (OnlineReturnDAL item in onlineReturnList)
                {
                    if (item.ReturnID == onlineReturnName)
                    {
                       searchOnlineReturn.Add(item);
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchOnlineReturn;
        }

        public bool UpdateReturnOnlineOrderDAL(OnlineReturnDAL updateonlineReturn)
        {
            bool onlineReturnUpdated = false;
            try
            {
                for (int i = 0; i < onlineReturnList.Count; i++)
                {
                    if (onlineReturnList[i].ReturnID == updateonlineReturn.ReturnID)
                    {
                        updateonlineReturn.ReturnPurposeOfReturn = onlineReturnList[i].PurposeOfReturn;
                        updateonlineReturn.ReturnMobileNumber =onlineReturnList[i].ReturnMobileNumber;
                        onlineReturnUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return onlineReturnUpdated;

        }

        public bool DeleteOnlineReturnDAL(int deleteReturnID)
        {
            bool onlineReturnDeleted = false;
            try
            {
                OnlineReturnDAL deleteOnlineReturn = null;
                foreach (OnlineReturnDAL item in onlineReturnList)
                {
                    if (item.ReturnID == deleteReturnID)
                    {
                        deleteOnlineReturn = item;
                    }
                }

                if (deleteOnlineReturn != null)
                {
                    onlineReturnList.Remove(deleteOnlineReturn);
                    onlineReturnDeleted = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return onlineReturnDeleted;

        }

    }
}
