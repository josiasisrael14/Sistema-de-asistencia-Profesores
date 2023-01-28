    using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTROASISTENCIA.Models
{
   
    public class db
    {
       
        private readonly string _conexion;
        // registroDBContext _dbcontext = null;

        //SqlConnection con = new SqlConnection("Data Source=JARIO;Initial Catalog=REGISTRO;Persist Security Info=True;User ID=sa;Password=genio1411");
        public db(IConfiguration aplication)
        {

            _conexion=aplication.GetConnectionString("conexion");


        }



        //public db(registroDBContext dbcontext)
        //{

        //    _dbcontext = dbcontext;


        //}

        public DataTable login(entidad datos)
        {


            using (SqlConnection sql = new SqlConnection(_conexion)) {

            using (SqlCommand com = new SqlCommand("sp_loguer", sql)) { 

           
          
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@logeo", datos.logeo);
            com.Parameters.AddWithValue("@password", datos.password);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

                   
                }

            }

        }


        public DataTable LISTAREMPLEADOS1()
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {

                using (SqlCommand com = new SqlCommand("sp_listarempleados1", sql))
                {

                    //SqlCommand com = new SqlCommand("LISTAREMPLEADOS", sql);
                    SqlDataAdapter da = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    return dt;
                }

            }

        }






        public DataTable LISTARHORARIOS()
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {

                using (SqlCommand com = new SqlCommand("SP_LISTARHORARIOS", sql))
                {

                    //SqlCommand com = new SqlCommand("LISTAREMPLEADOS", sql);
                    SqlDataAdapter da = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    return dt;
                }

            }

        }


        public string mantenimiento_horarios(entidad jairo)
        {
            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_HORARIOINSERTAR", sql))
                {
                    int ver;
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    cmd.Parameters.AddWithValue("@horaentrada", jairo.horaentrada);
                    cmd.Parameters.AddWithValue("@horasalida", jairo.horasalida);
                    sql.Open();
                    try
                    {
                        ver = cmd.ExecuteNonQuery();




                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show("Erro: " + ex.ToString());




                    }
                    return null;

                }



            }
        }


        public DataTable Listarhorariosid(entidad value)


        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {


                using (SqlCommand cmd = new SqlCommand("sp_ListarHorarioPorId", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idhorario", value.idhorario));


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    return dt;

                }





            }






        }



        public string EditarHorario(entidad jairo)
        {
            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UPDATEHORARIOS", sql))
                {
                    int ver;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idhorario", jairo.idhorario);
                    cmd.Parameters.AddWithValue("@horaentrada", jairo.horaentrada);
                    cmd.Parameters.AddWithValue("@horasalida ", jairo.horasalida);
                   

                    sql.Open();
                    try
                    {
                        ver = cmd.ExecuteNonQuery();




                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show("Erro: " + ex.ToString());




                    }
                    return null;

                }



            }

        }

        public bool Eliminarhorario(entidad jairo)
        {
            bool respuesta;
            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ELIMINARHORARIOS", sql))
                {
                    int ver;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idhorario", jairo.idhorario);


                    sql.Open();
                    try
                    {
                        ver = cmd.ExecuteNonQuery();
                        respuesta = true;



                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show("Erro: " + ex.ToString());

                        respuesta = false;


                    }
                    return respuesta;

                }



            }


        }















        public DataTable LISTAREMPLEADOS()
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand com = new SqlCommand("SP_LISTAREMPLEADO", sql))
                {
                    //using (SqlCommand com = new SqlCommand("LISTAREMPLEADOS", sql)) { 

                    //SqlCommand com = new SqlCommand("LISTAREMPLEADOS", sql);
                    SqlDataAdapter da = new SqlDataAdapter(com);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
                }

            }

        }


        public DataTable ListarAsistencias()
        {
            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarAsistenciaHora", sql))
                //lo use antes using (SqlCommand cmd =new SqlCommand("sp_ListarAsistencia", sql))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt =new DataTable();

                    da.Fill(dt);
                    return dt;



                }


            }




        }


        public DataTable D_ListarDepartamento()
        {

            using (SqlConnection sql =new SqlConnection(_conexion)) {


                // using (SqlCommand cmd = new SqlCommand("sp_departamento", sql)) { 

                using (SqlCommand cmd = new SqlCommand("SP_LISTARDEPARTAMENTO", sql))
                {

                    //SqlCommand cmd = new SqlCommand("sp_departamento", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
                }

            }

        }

        public DataTable D_ListarTipo()
        {

            using (SqlConnection sql = new SqlConnection(_conexion)) {
                using (SqlCommand cmd = new SqlCommand("sp_TipoEmpleado",sql)) { 
            //SqlCommand cmd = new SqlCommand("sp_TipoEmpleado", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
                }
            }

        }

        public string mantenimiento_Departamento(entidad jairo)
        {
            using(SqlConnection sql =new SqlConnection(_conexion)) {
                using (SqlCommand cmd = new SqlCommand("SP_INDEPARTAMENTO",sql))
                {
                    int ver;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreD", jairo.nombreD);
                    cmd.Parameters.AddWithValue("@descripcion", jairo.descripcion);
                    cmd.Parameters.AddWithValue("@fechacreadaD", jairo.fechacreadaD);
                    sql.Open();
                    try
                    {
                        ver = cmd.ExecuteNonQuery();
                       



                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show("Erro: " + ex.ToString());




                    }
                    return null;

                }



            }
        }
        public string Editar_Departamento(entidad jairo)
        {
            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_EDITARDEPARTAMENTO", sql))
                {
                    int ver;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreD", jairo.nombreD);
                    cmd.Parameters.AddWithValue("@descripcion", jairo.descripcion);
                    cmd.Parameters.AddWithValue("@fechacreadaD", jairo.fechacreadaD);
                    cmd.Parameters.AddWithValue("@iddepartamento", jairo.iddepartamentos);

                    sql.Open();
                    try
                    {
                        ver = cmd.ExecuteNonQuery();




                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show("Erro: " + ex.ToString());




                    }
                    return null;

                }



            }

        }



        public bool EliminarDepartamento(entidad jairo)
        {
            bool respuesta;
            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ELIMINARDEPARTAMENTO", sql))
                {
                    int ver;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iddepartamento", jairo.iddepartamentos);
                    

                    sql.Open();
                    try
                    {
                        ver = cmd.ExecuteNonQuery();
                        respuesta = true;



                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show("Erro: " + ex.ToString());

                        respuesta = false;


                    }
                    return respuesta;

                }



            }


        }





        public bool EliminarUsuario(entidad jairo)
        {
            bool respuesta;
            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", sql))
                {
                    int ver;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idempleados", jairo.idempleados);


                    sql.Open();
                    try
                    {
                        ver = cmd.ExecuteNonQuery();
                        respuesta = true;



                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show("Erro: " + ex.ToString());

                        respuesta = false;


                    }
                    return respuesta;

                }



            }


        }














        public string D_mantenimientousuarios(entidad jairo)
        {

            using (SqlConnection sql =new SqlConnection(_conexion)) {
                using (SqlCommand cmd = new SqlCommand("sp_mantenimientoempleados2", sql))
                {
                    //using (SqlCommand cmd = new SqlCommand("sp_mantenimientoempleados1", sql)) { 
                    int ver;
            String accion = "";
            //SqlCommand cmd = new SqlCommand("sp_mantenimiento_empleados", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idempleados", jairo.idempleados);
            cmd.Parameters.AddWithValue("@nombre", jairo.nombre);
            cmd.Parameters.AddWithValue("@apellidos", jairo.apellidos);
            cmd.Parameters.AddWithValue("@logeo", jairo.logeo);
            cmd.Parameters.AddWithValue("@iddepartamento", jairo.iddepartamento);
            cmd.Parameters.AddWithValue("@idtipoempleado", jairo.idtipoempleado);
            cmd.Parameters.AddWithValue("@email", jairo.email);
            cmd.Parameters.AddWithValue("@estado", jairo.estado);
            cmd.Parameters.AddWithValue("@fechacreado", jairo.fechacreado);
            cmd.Parameters.AddWithValue("@usuariocreado", jairo.usuariocreado);
            cmd.Parameters.AddWithValue("@codigoempleado", jairo.codigoempleado);   
            cmd.Parameters.AddWithValue("@password", jairo.password);
            cmd.Parameters.AddWithValue("@imagen", jairo.imagen);
            cmd.Parameters.AddWithValue("@idhorario", jairo.idhorario);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = jairo.accion;

            sql.Open();

            //if (con.State == ConnectionState.Open) con.Close();
            //con.Open();

            try
            {
             //cmd.ExecuteNonQueryAsync();
              
                 ver= cmd.ExecuteNonQuery();
                accion = cmd.Parameters["@accion"].Value.ToString();

            

            }
            catch (Exception ex)
            {

                //MessageBox.Show("Erro: " + ex.ToString());




            }

            //finally
            //{


            //    con.Close();

            //}

          //cmd.ExecuteNonQuery();
          //accion = cmd.Parameters["@accion"].Value.ToString();


          //if (cmd.ExecuteNonQuery() != 1)
          //{

          //    MessageBox.Show("Application name already exists!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);


          //}

          /*conn.Close()*/;
            return accion;


                }



            }










        }








        public DataTable ListarID(entidad value)


        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {


                using (SqlCommand cmd = new SqlCommand("SP_listaID", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idempleados", value.idempleados));


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    return dt;

                }





            }






        }



        public DataTable ListarDepa(entidad value)


        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {


                using (SqlCommand cmd = new SqlCommand("listarDepartamento", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@iddepartamento", value.iddepartamentos));


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    return dt;

                }





            }






        }













        public DataTable D_ListarDepartamentos()
        {

            //estuve utlizando el procedure sp_departamento1
            using (SqlConnection sql=new SqlConnection(_conexion))
            {
                using (SqlCommand cmd =new SqlCommand("SP_ListarAllDepartamento", sql))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt=new DataTable();
                    da.Fill(dt);
                    return dt;

                }

            }



        }


        public int ContarDepartamento( )
        {

            using (SqlConnection sql =new SqlConnection(_conexion))

            {
                using (SqlCommand cmd=new SqlCommand("SP_ContarDepartamento", sql))
                {

                    sql.Open();
                    int con = (int)cmd.ExecuteScalar();

                    return con;
                    
                }

            }



        }



        public int ContarEmpleados()
        {

            using (SqlConnection sql = new SqlConnection(_conexion))

            {
                using (SqlCommand cmd = new SqlCommand(" SP_ContarUsuarios", sql))
                {

                    sql.Open();
                    int con = (int)cmd.ExecuteScalar();

                    return con;

                }

            }



        }


        public int ContarTipoEmpleado()
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd =new SqlCommand("SP_CONTARTIPOEMPLEADOS", sql))
                {

                    sql.Open();
                    int con = (int)cmd.ExecuteScalar();

                    return con;

                }

            }


        }


        public int ContarTarde()
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("contartarde", sql))
                {

                    sql.Open();
                    int con = (int)cmd.ExecuteScalar();

                    return con;

                }

            }


        }



        public int ContarTemprano()
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("SP_contartemprano", sql))
                {

                    sql.Open();
                    int con = (int)cmd.ExecuteScalar();

                    return con;

                }

            }


        }




        public DataTable HorarioUsuarioRegistrada(entidad value)


        {
            string usuarionoexiste = "usuarioN";

            using (SqlConnection sql = new SqlConnection(_conexion))
            {


                using (SqlCommand cmd = new SqlCommand("SP_TARDANZA", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@codigoempleado", value.codigoempleado));


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    //if ((dt?.Rows?.Count ?? 0)>0)
                    //{


                    //    return usuarionoexiste;

                    //} 

                    return dt;

                }





            }






        }














        //SqlCommand cmd=new SqlCommand("sp_departamento")


        public string EntradaSalida(entidad asistencia)
        {
            string insertarsalida="salidaI";
            string insertarentrada = "entradaI";
            string usuarionoexiste = "usuarioN";
            using(SqlConnection sql=new SqlConnection(_conexion))
            { 

            if (asistencia.tipo == "salida")
            {

                int i;
                SqlCommand cmd = new SqlCommand("SP_reporte1", sql);
                    //lo use antes SqlCommand cmd = new SqlCommand("SP_reporte", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoempleado", asistencia.codigoempleado);
                cmd.Parameters.AddWithValue("@fechahora", asistencia.fechahora);
                cmd.Parameters.AddWithValue("@tipo", asistencia.tipo);
                cmd.Parameters.AddWithValue("@fecha", asistencia.fecha);
                cmd.Parameters.AddWithValue("@TardeTemprano", asistencia.TardeTemprano);
                    sql.Open();


                    try
                {

                    i = cmd.ExecuteNonQuery();



                    if (i > 0)
                    {
                            //"<script language='javascript'>window.alert('" registro "')</script>"



                            return insertarsalida;

                        }
                    else
                    {



                    }
                    if (i < 0)
                    {

                            return usuarionoexiste;


                    }

                }

                catch (Exception ex)
                {


                  

                }

              






            }

            else
            {

                int i;
                SqlCommand cmd = new SqlCommand("SP_reporte1", sql);
                    //lo use antes SqlCommand cmd = new SqlCommand("SP_reporte", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoempleado", asistencia.codigoempleado);
                cmd.Parameters.AddWithValue("@fechahora", asistencia.fechahora);
                cmd.Parameters.AddWithValue("@tipo", asistencia.tipo);
                cmd.Parameters.AddWithValue("@fecha", asistencia.fecha);
                cmd.Parameters.AddWithValue("@TardeTemprano", asistencia.TardeTemprano);
                    sql.Open();


                    try
                {

                    i = cmd.ExecuteNonQuery();



                    if (i > 0)
                    {
                            //Response.Write("<script>alert('usuario registrado');</script>");
                            return insertarentrada;

                        }
                    else
                    {



                    }
                    if (i < 0)
                    {

                            return usuarionoexiste;


                    }

                }

                catch (Exception ex)
                {


                  

                }

               





            }




            return null;


            }

        }


        public DataTable MostrarDatosAsistencia(entidad value)
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_MostrarDatosAsistencia", sql))
                {
                    cmd.CommandType= System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@codigoempleado",value.codigoempleado));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }

            }




        }


        public DataTable ultimoregistro(entidad value)
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                //using (SqlCommand cmd = new SqlCommand("SP_UltimoRegistro", sql))
                using (SqlCommand cmd = new SqlCommand("SP_ultimoregistroentrada", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@codigoempleado", value.codigoempleado));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }

            }




        }




        public DataTable ultimoregistroS(entidad value)
        {

            using (SqlConnection sql = new SqlConnection(_conexion))
            {
                //using (SqlCommand cmd = new SqlCommand("SP_UltimoRegistro", sql))
                using (SqlCommand cmd = new SqlCommand("SP_ultimoregistrosalida", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@codigoempleado", value.codigoempleado));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }

            }




        }













        public DataTable D_AsistenciaReporte(entidad objent)
        {

            using (SqlConnection sql =new SqlConnection(_conexion))
            {

                DataTable dt = new DataTable();
                int i;
                SqlCommand cmd = new SqlCommand("SP_AsistenciaReporte", sql);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idempleados", objent.idempleados);
                cmd.Parameters.AddWithValue("@fechainicio", objent.fechainicio1);
                cmd.Parameters.AddWithValue("@fechafin", objent.fechafin1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;


            }
            
            

        }




    }




}



