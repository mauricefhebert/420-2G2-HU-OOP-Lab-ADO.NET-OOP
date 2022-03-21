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
        public List<Programme> GetAllProgrammes()
        {
            List<Programme> programmes = new List<Programme>(8);
            // Etablir la connection
            cn = new SqlConnection(ConnectionString);
            cn.Open();
            // Definir ma requete sql a executer
            string requete = "SELECT ProgrammeName FROM Programmes";
            // Executer la requete
            SqlCommand cmd = new SqlCommand(requete, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Récupérer les résultats de la requete
            while (reader.Read())
            {
                programmes.Add(new Programme()
                {
                    ProgrammeName = reader.GetString(0),
                });
            }
            // Fermer le reader
            reader.Close();
            //Fermer la connection
            cn.Close();
            //retourner la liste des programmes
            return programmes;
        }
        public void InsertProgramme(Programme programme)
        {
            cn = new SqlConnection(ConnectionString);
            cn.Open();

            //Definir la requete sql avec parametres
            string requete = "INSERT INTO Programmes (ProgrammeName) VALUES (@Prog)";

            //Creer mon object commmande
            SqlCommand cmd = new SqlCommand(requete, cn);

            //Donner des valeur au parametre
            cmd.Parameters.AddWithValue("Prog", programme.ProgrammeName);

            //Executer ma requete
            cmd.ExecuteNonQuery();
            //Fermer la connection
            cn.Close();
        }

        public void DeleteProgramme(int numProg)
        {
            cn = new SqlConnection(ConnectionString);
            cn.Open();

            //Definir la requete sql avec parametres
            string requete = "DELETE FROM Programmes WHERE ProgrammesId = @Prog";

            //Creer mon object commmande
            SqlCommand cmd = new SqlCommand(requete, cn);

            //Donner des valeur au parametre
            cmd.Parameters.AddWithValue("Prog", numProg);

            //Executer ma requete
            cmd.ExecuteNonQuery();
            //Fermer la connection
            cn.Close();
        }

        public void UpdateProgramme(Programme programme)
        {
            //Ouvrir la connection
            cn = new SqlConnection(ConnectionString);
            cn.Open();

            //Definir la requete sql avec parametres
            string requete =
                "UPDATE Programmes " +
                "SET ProgrammeName = @prog " +
                "WHERE ProgrammesId = @numProg";

            //Creer mon object commmande
            SqlCommand cmd = new SqlCommand(requete, cn);

            //Donner des valeur au parametre
            cmd.Parameters.AddWithValue("numProg", programme.ProgrammesId);
            cmd.Parameters.AddWithValue("prog", programme.ProgrammeName);

            //Executer ma requete
            cmd.ExecuteNonQuery();
            //Fermer la connection
            cn.Close();
        }
    }
}
