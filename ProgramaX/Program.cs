using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
namespace ProgramaX
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<string> listaProcesso = new List<string>();

            List<string[]> listaProcesso_Array = new List<string[]>();

            List<ClassProcesso> listaProcesso_Classe = new List<ClassProcesso>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=CORPORATE02;Initial Catalog=ANDAMENTOS;Persist Security Info=True;User ID=textractor;Password=okmnji90";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbprocesso_teste where idcliente = 23915 and flag = 5", con);
            SqlDataReader reader = cmd.ExecuteReader();        
            while (reader.Read())

            {
                listaProcesso.Add(reader.GetString(21));

                string[] arrayProcesso = new string[2];
                arrayProcesso[0] = reader.GetString(21);
                arrayProcesso[1] = reader.GetInt32(1).ToString();

                listaProcesso_Array.Add(arrayProcesso);
                ClassProcesso distribuicao = new ClassProcesso();
                distribuicao.id_Processo = reader.GetInt32(1);
                distribuicao.tx_Distribuicao = reader.GetString(21);


                listaProcesso_Classe.Add(distribuicao);
            }

            con.Close();                    
                                      // Conexao com o banco => select => leitura => gravar a leitura em uma lista

            List<ClassProcesso> listaProcessoConcertados = new List<ClassProcesso>();




            foreach (var elemento in listaProcesso_Classe)
            {
                var resultado = TratarErroJson(elemento.tx_Distribuicao);
                ClassProcesso distribuicao = new ClassProcesso();
                distribuicao.id_Processo = elemento.id_Processo;
                distribuicao.tx_Distribuicao = resultado;


                listaProcessoConcertados.Add(distribuicao);
           
            }
            
                 // ler todos os elementos da lista => fazer o tratamento do json com o metodo abaixo => gravar o tratamento em uma nova lista

            foreach(var elemento in listaProcessoConcertados)
            {
                UpdateJson(elemento);
            }


        }

          public static string TratarErroJson(string jsonErrado) 
          {

            var arquivo = jsonErrado;
            int posicao = arquivo.IndexOf("itensProcesso");     
            int posicao1 = arquivo.IndexOf("mensagemErro");
            if (posicao > -1)
            {                                                 // metodo para tratar o json
                string str = arquivo.Substring(0, posicao);
                string obj = str + "itensProcesso\":[]}";
                Console.WriteLine(obj);
                return obj;
            }else if (posicao1 > -1)
            {
                return jsonErrado;
            }
            else
            {
                return"";
            }

          }
          
           public static void UpdateJson (ClassProcesso MyUpdate)      // UPDATE
           {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=CORPORATE02;Initial Catalog=ANDAMENTOS;Persist Security Info=True;User ID=textractor;Password=okmnji90";
            con.Open();
            string query = "update tbprocesso_teste set txdistribuicao = '" + MyUpdate.tx_Distribuicao + "' where idprocesso =" + MyUpdate.id_Processo;
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
           }
        
    }

}








