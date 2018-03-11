using System;
using System.Web;
using System.Web.UI;

namespace Application
{
	public class Utilidades:Page
	{
		public MsgBox(string pMensaje)
		{
			string msj="<script languaje='Javascript'> alert('"+pMensaje+"');</script>";
			Page.ClientScript.RegisterStartupScript(Page.GetType(), "mensaje", msj);
		}
	}
}

