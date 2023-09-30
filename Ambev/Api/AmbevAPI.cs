using Ambev.Global;
using Ambev.Models;
using Microsoft.VisualBasic.ApplicationServices;
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

            Cripto cripto = new Cripto();

            string usuario = string.Empty;

            string senha = string.Empty;
            try
            {
                usuario = cripto.EncryptTripleDES(user);
                senha = cripto.EncryptTripleDES(password);
            }catch(Exception ex)
            {
                Log.Add(LogType.error, "Erro ao descriptografar");
            }

                Config.token = string.Empty;

            ApiBase api = new ApiBase();

            Result response = api.GetComand("Ambev/GetToken?user=" + usuario + "&password=" + senha);

            if (response.success)
            {
                Config.token = cripto.DecryptTrypleDES(response.data);
            }

            return Config.token;
        }

        public bool Handshake()
        {
            bool result = false;
            ApiBase api = new ApiBase();


            Result response = api.GetComand("Ambev/Handshake");

            if (response.success)
            {
                result = true;
            }

            return result;
        }

        public bool AccessTest(string token)
        {
            Cripto cripto = new Cripto();
            string tk = string.Empty;
            try
            {
               tk = cripto.EncryptTripleDES(token);
            }
            catch(Exception e)
            {
                Log.Add(LogType.error, "Erro ao descriptografar");
            }
            ApiBase api = new ApiBase();

            Result result = api.GetComand("Ambev/AccessTest?token=" + tk);

            bool resultado = false;

            if (result.success)
            {
                resultado = true;
            }

            return resultado;
        }

    }
}
