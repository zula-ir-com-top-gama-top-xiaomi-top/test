using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public static class UsersApplication
    {
        public enum OperationTypes
        {
            PhoneNumber,
            Email,
            Username,
        }

        #region Login Methods
        public static bool Login(string Username, string Password)
        {
            DAL.UserModel user = new DAL.UserModel();
            user.Username = Username;
            user.Password = Password;

            return Login(user);
        }

        static bool Login(DAL.UserModel model)
        {
            if (model.Username == "admin" && model.Password == "123")
                return true;

            return false;
        }

        //public static bool Login(DAL.User model)
        //{

        //    if (model.Email == "admin@google.com" && model.Password == "123")
        //        return true;

        //    return false;
        //}

        //public static bool Login(DAL.User model)
        //{
        //    if (model.Username == "admin" && model.Password == "123")
        //        return true;

        //    return true;
        //}

        //public static bool Login(DAL.User model)
        //{
        //    if (model.NationalCode == "1234567890" && model.Password == "123")
        //        return true;

        //    return true;
        //}

        #endregion

        #region User Carts

        public static DAL.CartModel GetCart(string Username)
        {
            DAL.CartModel cart = new DAL.CartModel();

            return cart;
        }

        #endregion
    }
}
