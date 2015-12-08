using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Helper
{
    public class EnderecoHelper
    {
        static EnderecoHelper()
        {

        }

        public static List<Estado> CarregarEstado()
        {
            return new List<Estado>()
            {
                new Estado() { Id =1 , Nome = "Rio de Janeiro" },
                new Estado() { Id =2 , Nome = "São Paulo" },
                new Estado() { Id =3 , Nome = "Bahia" },
                new Estado() { Id =4 , Nome = "Paraíba" },
                new Estado() { Id =5 , Nome = "Minas Gerais" }
            };
        }

        public static List<Cidade> CarregaCidades()
        {
            return new List<Cidade>()
            {
                new Cidade() { Id = 1, Nome = "Angra dos Reis",     IdEstado = 1 },
                new Cidade() { Id = 2, Nome = "Aperibe",            IdEstado = 1 },
                new Cidade() { Id = 3, Nome = "Araruama",           IdEstado = 1 },
                new Cidade() { Id = 4, Nome = "Areal",              IdEstado = 1 },
                new Cidade() { Id = 5, Nome = "Armacao de Buzios",  IdEstado = 1 },
                new Cidade() { Id = 6, Nome = "Arraial do Cabo",    IdEstado = 1 },
                new Cidade() { Id = 7, Nome = "Barra Mansa",        IdEstado = 1 },
                new Cidade() { Id = 8, Nome = "Barra do Pirai",     IdEstado = 1 },
                new Cidade() { Id = 10, Nome = "Adamantina"              , IdEstado = 2 },
                new Cidade() { Id = 11, Nome = "Adolfo"                  , IdEstado = 2 },
                new Cidade() { Id = 12, Nome = "Aguai"                   , IdEstado = 2 },
                new Cidade() { Id = 13, Nome = "Aguas da Prata"          , IdEstado = 2 },
                new Cidade() { Id = 14, Nome = "Aguas de Lindoia"        , IdEstado = 2 },
                new Cidade() { Id = 15, Nome = "Aguas de Santa Barbara"  , IdEstado = 2 },
                new Cidade() { Id = 16, Nome = "Aguas de Sao Pedro"      , IdEstado = 2 },
                new Cidade() { Id = 17, Nome = "Agudos"                  , IdEstado = 2 },
                new Cidade() { Id = 18, Nome = "Alambari"                , IdEstado = 2 },
                new Cidade() { Id = 19, Nome = "Alfredo Marcondes"       , IdEstado = 2 },
                new Cidade() { Id = 20, Nome = "Altair"                  , IdEstado = 2 },
                new Cidade() { Id = 21, Nome = "Altinopolis"             , IdEstado = 2 },
                new Cidade() { Id = 22, Nome = "São Paulo"             , IdEstado = 2 },
                new Cidade() { Id = 23, Nome = "Indaiatuba"             , IdEstado = 2 },
                new Cidade() { Id = 24, Nome = "Franciscopolis", IdEstado = 5 },
                new Cidade() { Id = 25, Nome = "Frei Gaspar", IdEstado = 5 },
                new Cidade() { Id = 26, Nome = "Frei Inocencio", IdEstado = 5 },
                new Cidade() { Id = 27, Nome = "Frei Lagonegro", IdEstado = 5 },
                new Cidade() { Id = 28, Nome = "Fronteira dos Vales", IdEstado = 5 },
                new Cidade() { Id = 29, Nome = "Fronteira", IdEstado = 5 },
                new Cidade() { Id = 30, Nome = "Fruta de Leite", IdEstado = 5 },
                new Cidade() { Id = 31, Nome = "Frutal", IdEstado = 5 },
                new Cidade() { Id = 32, Nome = "Funilandia", IdEstado = 5 },
                new Cidade() { Id = 33, Nome = "Galileia", IdEstado = 5 },
                new Cidade() { Id = 34, Nome = "Gameleiras", IdEstado = 5 },
                new Cidade() { Id = 35, Nome = "Glaucilandia", IdEstado = 5 },
                new Cidade() { Id = 36, Nome = "Goiabeira", IdEstado = 5 },
                new Cidade() { Id = 37, Nome = "Goiana", IdEstado = 5 },
                new Cidade() { Id = 38, Nome = "Goncalves", IdEstado = 5 },
                new Cidade() { Id = 39, Nome = "Gonzaga", IdEstado = 5 }
            };
        }

    }
}
