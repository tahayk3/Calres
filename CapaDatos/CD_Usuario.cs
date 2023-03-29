using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try 
                {
                    StringBuilder query = new StringBuilder(); 
                    query.AppendLine("select u.IdUsuario,u.Documento,u.Nombres,u.Apellidos,u.Domicilio,u.TelefonoDomiciliar,u.TelefonoPersonal,u.Correo,u.FechaIngreso,u.FechaNacimiento,u.EstadoCivil,u.Contacto,u.NoHijos,u.NombreMadre,u.NombrePadre,u.TipoSangre,u.Clave,u.Estado,r.IdRol,r.descripcion from usuario u");
                    query.AppendLine("inner join rol r on r.IdRol = u.IdRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento= dr["Documento"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Domicilio = dr["Domicilio"].ToString(),
                                TelefonoDomiciliar = dr["TelefonoDomiciliar"].ToString(),
                                TelefonoPersonal = dr["TelefonoPersonal"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                FechaIngreso = dr["FechaIngreso"].ToString(),
                                FechaNacimiento = dr["FechaNacimiento"].ToString(),
                                EstadoCivil = dr["EstadoCivil"].ToString(),
                                Contacto = dr["Contacto"].ToString(),
                                NoHijos = Convert.ToInt32(dr["NoHijos"]),
                                NombreMadre = dr["NombreMadre"].ToString(),
                                NombrePadre = dr["NombrePadre"].ToString(),
                                TipoSangre = dr["TipoSangre"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["Descripcion"].ToString() } 
                            });
                        }
                    }
                }
                catch(Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
    }
}
