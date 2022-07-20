using System.Text.RegularExpressions;
using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }else if (rendimento <= 6000)
            {
                return rendimento * .05f;

            }else if (rendimento <= 10000)
            {
                return rendimento * .07f;

            }else
            {
                return rendimento * .09f;

            }
        }

        //XX.XXX.XXX/0001-XX ---- XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {

            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

            // if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {
                    string subStringCnpj = cnpj.Substring(11, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }


                }
                else if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.Substring(8, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public void Inserir(PessoaJuridica pj){
            
            Utils.VerificarPastaArquivo(caminho);

            string[] pjStrings = {$"{pj.Nome},{pj.RazaoSocial},{pj.Cnpj},{pj.Endereco.logradouro},{pj.Endereco.numero},{pj.Endereco.complemento},{pj.Endereco.endComercial},{pj.Rendimento}"};

            File.AppendAllLines(caminho, pjStrings);
        }

        public List<PessoaJuridica> LerArquivo(){

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.RazaoSocial = atributos[1];
                cadaPj.Cnpj = atributos[2];
                // cadaPj.endereco.logradouro[3];
                // cadaPj.endereco.numero = atributos[3];
                cadaPj.Endereco.complemento = atributos[4]; 
                // cadaPj.endereco.endComercial = atributos[5];
                // cadaPj.rendimento = atributos[6];          
                               
                

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }
    }
}