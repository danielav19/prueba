using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ArrayList list = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"] != null)
        {
            Literal1.Text = "Hola " + Convert.ToString(Session["usuario"]);
        }
        else
        {
            Literal1.Text = "No se ha registrado ningun usuario";
        }
        if (Cache["Usuarios"] != null)
        {
            //recuperamos la lista de usuarios almacenados en cache
            ArrayList lista = (ArrayList) Cache["Usuarios"];
            for (int i = 0; i < lista.Count; i++)
            {
                //agregamos los usarios a la lista en pantalla
                listaUsuarios.Items.Add(lista[i].ToString());
            }
        }
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (txtUsuario.Text != null)
        {
            //Almacenamos al usuario en una variable de sesion
            Session["usuario"] = txtUsuario.Text;
            //verificamos si la cache no esta vacia
            if (Cache["Usuarios"] != null)
            {
                //recuperamos los datos de los usuarios almacenados en cache
                list = (ArrayList)Cache["Usuarios"];
            }
            //agregamos usuarios a la lista
            list.Add(txtUsuario.Text);
            //los almacenamos en la cache
            Cache["Usuarios"] = list;
            //refres de la pagina
            Response.Redirect("Default.aspx");
        }
    }
}