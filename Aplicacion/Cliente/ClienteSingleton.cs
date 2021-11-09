using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Cliente
{
    class ClienteSingleton
    {
        private HttpClient cliente;
        private static ClienteSingleton instancia;

        private ClienteSingleton()
        {
            cliente = new HttpClient();
        }

        public static ClienteSingleton ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new ClienteSingleton();
            return instancia;
        }

        public async Task<string> ConsultarAsync(string url)
        {
            var resultado = await cliente.GetAsync(url);
            var content = "";
            if (resultado.IsSuccessStatusCode)
                content = await resultado.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<string> InsertarAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> ConsultarUsuarioAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> BorrarAsync(string url)
        {
            var result = await cliente.DeleteAsync(url);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> ModificarAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await cliente.PutAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
    }
}
