using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire10
{
    internal class EtudiantDataContext
    {
        // Proprieter pour la connection sql
        public string ConnectionString { get; set; }
        private SqlConnection cn;

        // Constructeur pour la connection sql
        public EtudiantDataContext(string strConnection)
        {
            this.ConnectionString = strConnection;
        }

        //Method pour manipuler les données
        /** Lire
         * List<listName> listName = new List<listName>();
            // Etablir la connection
                cn = new SqlConnection(ConnectionString);
                cn.Open();
            // Definir ma requete sql a executer
            string requete = "SELECT CustomerID, ContactName, CompanyName, Country, Phone FROM Customers";
            // Executer la requete
            SqlCommand cmd = new SqlCommand(requete, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Récupérer les résultats de la requete
            while(reader.Read()) 
            {
                listName.Add(new listName() { Numero = reader.GetString(0), 
                                            Nom =reader.GetString(1),
                                            Ville=reader.GetString(2),
                                            Telephone=reader.GetString(3) 
                                           });
            }
            // Fermer le reader
            reader.Close ();
            //Fermer la connection
            cn.Close();
            //retourner la liste des clients 
            return clients;
         */

        /** Ecrire, Update et Supprimer
         * //Ouvrir la connection
            cn = new SqlConnection(ConnectionString);
            cn.Open();

            //Definir la requete sql avec parametres
            string requete = "INSERT INTO Customers (CustomerID, ContactName, CompanyName, Country, Phone) VALUES (@num, @nom, @comp, @pays, @tel)";

            //Creer mon object commmande
            SqlCommand cmd = new SqlCommand (requete, cn);

            //Donner des valeur au parametre
            cmd.Parameters.AddWithValue("num", client.Numero);
            cmd.Parameters.AddWithValue("nom", client.Nom);
            cmd.Parameters.AddWithValue("comp", client.Compagnie);
            cmd.Parameters.AddWithValue("pays", client.Ville);
            cmd.Parameters.AddWithValue("tel", client.Telephone);

            //Executer ma requete
            cmd.ExecuteNonQuery();
            //Fermer la connection
            cn.Close();
         */
    }
}
