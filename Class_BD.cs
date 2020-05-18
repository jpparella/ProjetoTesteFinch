using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptSharp;

namespace pFinchFila
{
    public class Class_BD
    {
        public Class_Email Envios;
        SQLiteConnection conn;
        private String CPFLogado="";
        public String Error = "";
        public bool Conectar()
        {
            try
            {
                conn = new System.Data.SQLite.SQLiteConnection("Data Source=Banco.db;");
                conn.Open();
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;
                return false;
            }
            return true;
            
        }

        public DataTable DadosServicosIniciados()
        {
            DataTable dt = new DataTable();
            String insSQL = "select SI_ID as 'CodServiço' , SI_USUARIO as Usuario, SI_Cliente as Cliente, SI_Datainicio as 'Data Inicio' from servicosIniciados where SI_USUARIO = @user and SI_FINALIZADO = 0";
            
            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, conn);

            da.SelectCommand.Parameters.AddWithValue("@user", CPFLogado);
            da.Fill(dt);
            return dt;
        }

        public bool InsertUsuario(String CPF, String Nome, String Email, String Senha)
        {
            var comm = new System.Data.SQLite.SQLiteCommand(conn);
            try
            {
                comm.CommandText = "INSERT INTO usuario VALUES (@cpf,@email,@nome,@senha)";
                comm.Parameters.AddWithValue("@cpf", CPF);
                comm.Parameters.AddWithValue("@Email", Email);
                comm.Parameters.AddWithValue("@nome", Nome);
                comm.Parameters.AddWithValue("@senha", Crypt(Senha));
                comm.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;
                return false;
            }
            return true;

        }

        public bool Login(String email,String Senha)
        {
            try
            {
                var comm = new System.Data.SQLite.SQLiteCommand(conn);
                comm.CommandText = "SELECT usu_senha FROM usuario where usu_email = @email";
                comm.Parameters.AddWithValue("@email", email);                
                //comm.Parameters.AddWithValue("@pass", Crypt(Senha));
                var UsuarioCont = comm.ExecuteScalar();
                if (UsuarioCont != null && UsuarioCont != DBNull.Value && (Crypter.CheckPassword(Senha, UsuarioCont.ToString())))
                {
                    CpfUsuario(email);
                    return true;
                }
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;
                return false;
            }
            return false;
        }

        void CpfUsuario(String email)
        {
            try
            {
                var comm = new System.Data.SQLite.SQLiteCommand(conn);
                comm.CommandText = "SELECT usu_cpf FROM usuario where usu_email = @email";
                comm.Parameters.AddWithValue("@email", email);
                //comm.Parameters.AddWithValue("@pass", Crypt(Senha));
                var UsuarioCont = comm.ExecuteScalar();
                if (UsuarioCont != null && UsuarioCont != DBNull.Value)
                {
                    CPFLogado = UsuarioCont.ToString();
                }
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;
            }
        }

        public bool TestaUser(String email, String CPF)
        {
            try
            {  
                var comm = new System.Data.SQLite.SQLiteCommand(conn);
                comm.CommandText = "SELECT count(*) as Contagem FROM usuario where usu_email = @email or usu_cpf = @cpf";
                comm.Parameters.AddWithValue("@email", email);
                comm.Parameters.AddWithValue("@cpf", CPF);
                var UsuarioCont = comm.ExecuteScalar();
                if (UsuarioCont != null && UsuarioCont != DBNull.Value && Convert.ToInt32(UsuarioCont.ToString())>=1 )
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;
                return false;
            }
            return false;
        }


        public bool TestaServico(String Servico)
        {
            try
            {
                var comm = new System.Data.SQLite.SQLiteCommand(conn);
                comm.CommandText = "SELECT count(*) as Contagem FROM servicosIniciados where si_id = @id";
                comm.Parameters.AddWithValue("@id", Servico);
                var UsuarioCont = comm.ExecuteScalar();
                if (UsuarioCont != null && UsuarioCont != DBNull.Value && Convert.ToInt32(UsuarioCont.ToString()) >= 1)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;
                return false;
            }
            return false;
        }
        public bool InsertServico(String Servico,String Cliente)
        {
            var comm = new System.Data.SQLite.SQLiteCommand(conn);
            try
            {
                if (TestaServico(Servico))
                {
                    Error = "Serviço ja inciado.";
                    return false;                    
                }
                else
                {
                    comm.CommandText = "INSERT INTO servicosIniciados VALUES (@id,@Final,@cpf,@cliente,@dataini)";
                    comm.Parameters.AddWithValue("@id", Servico);
                    comm.Parameters.AddWithValue("@Final", "0");
                    comm.Parameters.AddWithValue("@cpf", CPFLogado);
                    comm.Parameters.AddWithValue("@cliente", Cliente);
                    comm.Parameters.AddWithValue("@dataini", DateTime.Now.ToString("dd/MM/yyyy HH:mm tt"));
                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;
                return false;
            }
            return true;
        }

        public bool FinalizaServico(String Servico)
        {
            var comm = new System.Data.SQLite.SQLiteCommand(conn);
            try
            {
                comm.CommandText = "update servicosIniciados set si_finalizado = 1  where si_id=@id";
                comm.Parameters.AddWithValue("@id", Servico);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;
                return false;
            }
            return true;
        }

        String Crypt(String password)
        {
            return Crypter.MD5.Crypt(password);
        }

        public String getUsuariologado()
        {
            try
            {
                var comm = new System.Data.SQLite.SQLiteCommand(conn);
                comm.CommandText = "SELECT usu_email FROM usuario where usu_cpf = @cpf";
                comm.Parameters.AddWithValue("@cpf", CPFLogado);
                //comm.Parameters.AddWithValue("@pass", Crypt(Senha));
                var UsuarioCont = comm.ExecuteScalar();
                if (UsuarioCont != null && UsuarioCont != DBNull.Value)
                {
                    return UsuarioCont.ToString();
                }
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Error = e.Message;               
            }
            return "";
        }
        public void ConfiguraEmail(String Email)
        {
            Envios = new Class_Email(Email);
        }

    }

    
}
