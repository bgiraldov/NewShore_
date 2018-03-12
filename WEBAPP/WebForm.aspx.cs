using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBAPP
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnDescargar.Enabled = false;
            }
        }

        protected void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            string letras = string.Empty;
            string nombre = string.Empty;
            bool esCliente = false;
            DataTable dtRegistrados = new DataTable();

            try
            {
                if (fileContenido.HasFile && fileRegistrado.HasFile)
                {
                    String fileExtensionContenido = System.IO.Path.GetExtension(fileContenido.FileName).ToLower();
                    String fileExtensionRegistrado = System.IO.Path.GetExtension(fileRegistrado.FileName).ToLower();
                    if (fileExtensionContenido.Equals(".txt") && fileExtensionRegistrado.Equals(".txt"))
                    {
                        StreamReader reader = new StreamReader(fileContenido.FileContent);
                        do
                        {
                            letras += reader.ReadLine();
                        }
                        while (reader.Peek() != -1);
                        reader.Close();

                        dtRegistrados.Columns.Add("Id");
                        dtRegistrados.Columns.Add("Nombre");
                        dtRegistrados.Columns.Add("Cliente");
                        reader = new StreamReader(fileRegistrado.FileContent);
                        int i = 1;
                        do
                        {
                            nombre = reader.ReadLine();
                            ServiceReferenceWCF.ServiceClient servicio = new ServiceReferenceWCF.ServiceClient();
                            esCliente = servicio.EsCliente(letras, nombre);
                            DataRow row = dtRegistrados.NewRow();
                            row["Id"] = i;
                            row["Nombre"] = nombre.ToUpper();
                            row["Cliente"] = (esCliente) ? "Si Existe" : "No Existe";
                            dtRegistrados.Rows.Add(row);
                            i++;
                        }
                        while (reader.Peek() != -1);
                        reader.Close();
                        Session["resultado"] = dtRegistrados;
                        grvResultado.DataSource = dtRegistrados;
                        grvResultado.DataBind();
                        btnDescargar.Enabled = true;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Las extensiones de los archivos deben ser .txt')", true);
                        btnDescargar.Enabled = false;
                    }

                }
                else
                {
                    btnDescargar.Enabled = false;
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione los archivos de Contenido y Registrados')", true);
                }
            }
            catch (Exception exc)
            {
                btnDescargar.Enabled = false;
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Excepcion:" + exc.Message + " ')", true);
            }
        }

        protected void btnDescargar_Click(object sender, EventArgs e)
        {
            string linea = string.Empty;
            DataTable dtDatosDescargar = new DataTable();
            dtDatosDescargar = Session["resultado"] as DataTable;

            if (!(dtDatosDescargar == null))
            {
                using (TextWriter tw = new StreamWriter(Response.OutputStream, Encoding.UTF8))
                {
                    foreach (DataRow row in dtDatosDescargar.Rows)
                    {
                        linea = row[1].ToString() + "-->" + row[2].ToString();
                        tw.WriteLine(linea);
                    }
                    Response.Clear();
                    Response.ClearHeaders();
                    Response.ContentType = "text/plain";
                    Response.AppendHeader("content-disposition", "attachment;filename=\"Registrados.txt\"");
                    Response.Write(tw.ToString().Substring(22));
                    Response.End();
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No existen datos para descargar')", true);
            }
        }
    }
}