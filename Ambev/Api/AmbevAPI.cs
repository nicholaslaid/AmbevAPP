using Ambev.Global;
using Ambev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.Api
{
    public class AmbevAPI
    {

        public string GetToken(string user, string password)
        {
           
            ApiBase api = new ApiBase();

            Result response = api.GetComand("Ambev/GetToken?user=" + user + "&password=" + password);

            if (response.success)
            {
                Config.token = response.data;
            }

            return Config.token;
        }

        public bool Handshake()
        {
            bool result = false;
            ApiBase api = new ApiBase();


            Result response = api.GetComand("Ambev/Handshake");
             
            if(response.success)
            {
                result = true;
            }

            return result;
        }

        public bool AccessTest(string token)
        {
            ApiBase api = new ApiBase();

            Result result = api.GetComand("Ambev/AccessTest?token=" + token);

            bool resultado = false;

            if(result.success)
            {
                resultado = true;
            }

            return resultado;
        }

    }
}
