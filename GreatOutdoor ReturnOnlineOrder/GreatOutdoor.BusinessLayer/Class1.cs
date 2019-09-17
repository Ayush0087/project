using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoor.DataAccessLayer;
using GreatOutdoor.Entity;
using GreatOutdoor.Exception;

namespace GreatOutdoor.BusinessLayer
{
   
    public class OnlineReturnBL
    {
        private static bool ValidateGuest(OnlineReturnBL onlineReturn)
        {
            StringBuilder sb = new StringBuilder();
            bool valiOnlineReturnBL = true;
            if (OnlineReturnBL.ReturnID <= 0)
            {
                validOnlineReturnBL = false;
                sb.Append(Environment.NewLine + "Invalid ReturnOnlineOrder ID");

            }
            if (OnlineReturnBL.OnlineReturnName == string.Empty)
            {
                validOnlineReturnBL = false;
                sb.Append(Environment.NewLine + "ReturnOnlineOrder Name Required");

            }
            if (OnlineReturnBL.OnlineReturnContactNumber.Length < 10)
            {
                validOnlineReturn = false;
                sb.Append(Environment.NewLine + "Required 10 Digit Contact Number");
            }
            if (validOnlineReturn == false)
                throw new GreatOutdoorException(sb.ToString());
            return validOnlineReturn;
        }

        public static bool AddOnlineReturnBL(OnlineReturnBL newOnlineReturn)
        {
            bool onlineReturnAdded = false;
            try
            {
                if (ValidateOnlineReturn(newOnlineReturn))
                {
                    OnlineReturnDAL onlineReturnDAL = new OnlineReturnDAL();
                    onlineReturnAdded = onlineReturnDAL.AddOnlineReturnDAL(newOnlineReturn);
                }
            }
            catch (GreatOutdoorException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return onlineReturnAdded;
        }

        public static List<OnlineReturnBL> GetAllGuestsBL()
        {
            List<OnlineReturnBL> onlineReturnList = null;
            try
            {
                OnlineReturnDAL onlineReturn = new OnlineReturnDAL();
                onlineReturnList = OnlineReturnDAL.GetAllReturnOnlineOrderDAL();
            }
            catch (GreatOutdoorException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return onlineReturnList;
        }

        public static OnlineReturnBL SearchOnlineReturnBL(int searchReturnID)
        {
            OnlineReturnBL searchOnlineReturn = null;
            try
            {
                OnlineReturnDAL onlineReturn = new OnlineReturnDAL();
                searchOnlineReturn = OnlineReturnDAL.SearchOnlineReturnDAL(searchReturnID);
            }
            catch (GreatOutdoorException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchOnlineReturn;

        }

        public static bool UpdateOnlineReturnBL(OnlineReturnBL updateonlineReturn)
        {
            bool onlineReturnUpdated = false;
            try
            {
                if (ValidateOnlineReturn(updateOnlineReturn))
                {
                    OnlineReturnDAL onlineReturn = new OnlineReturnDAL();
                    onlineReturnUpdated = OnlineReturnDAL.UpdateOnlineReturnDAL(updateonlineReturn);
                }
            }
            catch (GreatOutdoorException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return onlineReturnUpdated;
        }

        public static bool DeleteOnlineReturnBL(int deleteReturnID)
        {
            bool onlineReturnDeleted = false;
            try
            {
                if (deleteReturnID > 0)
                {
                    OnlineReturnDAL onlineReturn = new OnlineReturnDAL();
                    onlineReturnDeleted = OnlineReturnDAL.DeleteReturnOnlineOrderDAL(deleteReturnID);
                }
                else
                {
                    throw new GreatOutdoorException("Invalid ReturnOnlineOrder ID");
                }
            }
            catch (GreatOutdoorException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return onlineReturnDeleted;
        }
       
    }
}
