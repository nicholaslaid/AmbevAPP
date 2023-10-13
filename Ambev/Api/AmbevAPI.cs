using Ambev.Global;
using Ambev.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
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

        public Result Add(string token, Produtos produtos)
        {
            ApiBase api = new ApiBase();

            Request request = new Request();

            Cripto cripto = new Cripto();

            string produto = JsonConvert.SerializeObject(produtos);

            request.data = cripto.EncryptTripleDES(produto);
            request.token = cripto.EncryptTripleDES(Config.token);

            string parameters = JsonConvert.SerializeObject(request);

            Result result = api.PostComand("Ambev/Add", parameters);


            return result;
        }


        public List<Produtos> GetAllProdutos(string token)
        {
            Cripto cripto = new Cripto();
            List<Produtos> result = new List<Produtos>();
            ApiBase api = new ApiBase();

            Result response = new Result();

            string tk = cripto.EncryptTripleDES(token);
            response = api.GetComand("Ambev/GetAll?token=" + tk);

            if (response.success == true)
            {
                string parameters = cripto.DecryptTrypleDES(response.data);
                result = JsonConvert.DeserializeObject<List<Produtos>>(parameters);
            }

            return result;
        }

        public List<Vendas> GetAllVendas(string token)
        {
            Cripto cripto = new Cripto();
            List<Vendas> result = new List<Vendas>();
            ApiBase api = new ApiBase();

            Result response = new Result();

            string tk = cripto.EncryptTripleDES(token);
            response = api.GetComand("Ambev/ListaVendas?token=" + tk);

            if (response.success == true)
            {
                string parameters = cripto.DecryptTrypleDES(response.data);
                result = JsonConvert.DeserializeObject<List<Vendas>>(parameters);
            }

            return result;
        }

        public List<info> VendasProdutos(string token)
        {
            Cripto cripto = new Cripto();
            List<info> result = new List<info>();
            ApiBase api = new ApiBase();

            Result response = new Result();

            string tk = cripto.EncryptTripleDES(token);
            response = api.GetComand("Ambev/ListaProdutos?token=" + tk);

            if (response.success == true)
            {
                string parameters = cripto.DecryptTrypleDES(response.data);
                result = JsonConvert.DeserializeObject<List<info>>(parameters);
            }

            return result;
        }
        public bool Delete(string token, int id)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(id);

            Result response = api.DeleteComand("Ambev/Delete?id=" + id + "&token=" + token);

            bool result = response.success;

            return result;
        }


    }
}
