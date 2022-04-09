using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WSTowers_webAPI.Contexts;
using WSTowers_webAPI.Domains;

namespace WSTowers_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {

        private string stringConexao = @"Data Source=localhost; initial catalog=WSTowers; Integrated Security=True";

        [HttpGet("Manual")]
        public IActionResult ListAll()
        {
            List<Venda> listaVendas = new();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = $@"SELECT regiao.regiao, SUM(valor) AS 'R$', SUM(quantidade) AS 'Vendas' FROM vendas 
                                                JOIN produto ON vendas.produto = produto.id
                                                JOIN participante ON participante = participante.id 
                                                JOIN cidade ON participante.cidade = cidade.id 
                                                JOIN estado ON cidade.estado = estado.id
                                                JOIN regiao ON estado.regiao = regiao.id
                                                GROUP BY regiao.regiao";
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Venda vendas = new()
                        {
                            ParticipanteNavigation = new()
                            {
                                CidadeNavigation = new()
                                {
                                    EstadoNavigation = new()
                                    {
                                        RegiaoNavigation = new()
                                        {
                                            Regiao1 = rdr[0].ToString(),
                                        }
                                    }
                                }
                            },
                            ProdutoNavigation = new Produto()
                            {
                                Valor = Convert.ToInt32(rdr[1]),
                            },
                            Quantidade = Convert.ToInt32(rdr[2])
                        };
                        listaVendas.Add(vendas);
                    }
                }
                return Ok(listaVendas);
            }
        }

        [HttpGet("Participante")]
        public IActionResult ListByUser()
        {
            List <Venda> listaVendas= new();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = $@"SELECT nome, cidade.cidade, SUM(valor) AS 'Valor total comprado' FROM vendas
                                        INNER JOIN produto ON vendas.produto = produto.id
                                        INNER JOIN participante ON vendas.participante = participante.id
                                        INNER JOIN cidade ON participante.cidade = cidade.id
                                        GROUP BY CUBE (participante.nome, cidade.cidade)
                                        ORDER BY(SUM(valor))DESC";
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Venda vendas = new()
                        {
                            ParticipanteNavigation = new()
                            {
                                Nome = rdr[0].ToString(),
                                CidadeNavigation = new()
                                {
                                    Cidade1 = rdr[1].ToString(),
                                }
                            },
                            ProdutoNavigation = new Produto()
                            {
                                Valor = Convert.ToInt32(rdr[2]),
                            }
                        };
                        listaVendas.Add(vendas);
                    }
                }
                return Ok(listaVendas);
            }
        }
    }
}
