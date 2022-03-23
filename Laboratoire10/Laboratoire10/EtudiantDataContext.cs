using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Maurice filiatreault hebert
 * 2195109
 */
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
            string requete = "SELECT ProgrammesId, ProgrammeName FROM Programmes";
            // Executer la requete
            SqlCommand cmd = new SqlCommand(requete, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Récupérer les résultats de la requete
            while (reader.Read())
            {
                programmes.Add(new Programme(reader.GetInt32(0), reader.GetString(1)));
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
            string requete = "INSERT INTO Programmes (ProgrammesId, ProgrammeName) VALUES (@progId, @ProgName)";

            //Creer mon object commmande
            SqlCommand cmd = new SqlCommand(requete, cn);

            //Donner des valeur au parametre
            cmd.Parameters.AddWithValue("progId", programme.ProgrammesId);
            cmd.Parameters.AddWithValue("ProgName", programme.ProgrammeName);

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

        //Etudiant
        public List<EtudiantGrid> GetEtudiant(int numEtudiant)
        {
            List<EtudiantGrid> etudiant = new List<EtudiantGrid>(8);
            // Etablir la connection
            cn = new SqlConnection(ConnectionString);
            cn.Open();
            // Definir ma requete sql a executer
            string requete = "SELECT EtudiantId,FirstName,LastName,Address,BirthDay,Gender,ProgrammeName " +
                "FROM Etudiants " +
                "JOIN Programmes ON Etudiants.ProgrammeId = Programmes.ProgrammesId " +
                "WHERE EtudiantId = @numEtudiant";
            // Executer la requete
            SqlCommand cmd = new SqlCommand(requete, cn);
            cmd.Parameters.AddWithValue("numEtudiant", numEtudiant);
            SqlDataReader reader = cmd.ExecuteReader();
            // Récupérer les résultats de la requete
            while (reader.Read())
            {
                etudiant.Add(new EtudiantGrid
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetDateTime(4),
                    Convert.ToChar(reader.GetValue(5)),
                    reader.GetString(6)));
            }
            // Fermer le reader
            reader.Close();
            //Fermer la connection
            cn.Close();
            //retourner la liste des programmes
            return etudiant;
        }
        public List<EtudiantGrid> GetAllEtudiant()
        {
            List<EtudiantGrid> etudiant = new List<EtudiantGrid>(8);
            // Etablir la connection
            cn = new SqlConnection(ConnectionString);
            cn.Open();
            // Definir ma requete sql a executer
            string requete = "SELECT EtudiantId,FirstName,LastName,Address,BirthDay,Gender,ProgrammeName " +
                "FROM Etudiants " +
                "JOIN Programmes ON Etudiants.ProgrammeId = Programmes.ProgrammesId";
            // Executer la requete
            SqlCommand cmd = new SqlCommand(requete, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Récupérer les résultats de la requete
            while (reader.Read())
            {
                etudiant.Add(new EtudiantGrid
                (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetDateTime(4),
                    Convert.ToChar(reader.GetValue(5)),
                    reader.GetString(6)));
            }
            // Fermer le reader
            reader.Close();
            //Fermer la connection
            cn.Close();
            //retourner la liste des programmes
            return etudiant;
        }
        public void InsertEtudiant(Etudiant etudiant)
        {
            cn = new SqlConnection(ConnectionString);
            cn.Open();

            //Definir la requete sql avec parametres
            string requete = "INSERT INTO Etudiants (EtudiantId,FirstName,LastName,Address,BirthDay,Gender,ProgrammeId) " +
                "VALUES (@numEtudiant,@first,@last,@address,@birthday,@gender,@progId)";

            //Creer mon object commmande
            SqlCommand cmd = new SqlCommand(requete, cn);

            //Donner des valeur au parametre
            cmd.Parameters.AddWithValue("numEtudiant", etudiant.EtudiantId);
            cmd.Parameters.AddWithValue("first", etudiant.FirstName);
            cmd.Parameters.AddWithValue("last", etudiant.LastName);
            cmd.Parameters.AddWithValue("address", etudiant.Address);
            cmd.Parameters.AddWithValue("birthday", etudiant.BirthDay);
            cmd.Parameters.AddWithValue("gender", etudiant.Gender);
            cmd.Parameters.AddWithValue("progId", etudiant.FK_ProgrammesId);

            //Executer ma requete
            cmd.ExecuteNonQuery();
            //Fermer la connection
            cn.Close();
        }

        public void DeleteEtudiant(int numEtudiant)
        {
            cn = new SqlConnection(ConnectionString);
            cn.Open();

            //Definir la requete sql avec parametres
            string requete = "DELETE FROM Etudiants WHERE EtudiantId = @id";

            //Creer mon object commmande
            SqlCommand cmd = new SqlCommand(requete, cn);

            //Donner des valeur au parametre
            cmd.Parameters.AddWithValue("id", numEtudiant);

            //Executer ma requete
            cmd.ExecuteNonQuery();
            //Fermer la connection
            cn.Close();
        }

        public void UpdateEtudiant(Etudiant etudiant)
        {
            //Ouvrir la connection
            cn = new SqlConnection(ConnectionString);
            cn.Open();

            //Definir la requete sql avec parametres
            string requete =
                "UPDATE Etudiants " +
                "SET FirstName = @first, LastName = @last, Address = @address, Gender = @gender, ProgrammeId = @progId " +
                "WHERE EtudiantId = @numEtudiant";

            //@first,@last,@address,@birthday,@gender,@progId
            //Creer mon object commmande
            SqlCommand cmd = new SqlCommand(requete, cn);

            //Donner des valeur au parametre
            cmd.Parameters.AddWithValue("numEtudiant", etudiant.EtudiantId);
            cmd.Parameters.AddWithValue("first", etudiant.FirstName);
            cmd.Parameters.AddWithValue("last", etudiant.LastName);
            cmd.Parameters.AddWithValue("address", etudiant.Address);
            cmd.Parameters.AddWithValue("gender", etudiant.Gender);
            cmd.Parameters.AddWithValue("progId", etudiant.FK_ProgrammesId);

            //Executer ma requete
            cmd.ExecuteNonQuery();
            //Fermer la connection
            cn.Close();
        }

        //A completer
        public List<EtudiantGrid> GetEtudiantsByProgramme(int numProg)
        {
            List<EtudiantGrid> etudiant = new List<EtudiantGrid>(8);
            // Etablir la connection
            cn = new SqlConnection(ConnectionString);
            cn.Open();
            // Definir ma requete sql a executer
            string requete = 
                "SELECT EtudiantId,FirstName,LastName,Address,BirthDay,Gender,ProgrammeName " +
                "FROM Etudiants " +
                "JOIN Programmes ON Etudiants.ProgrammeId = Programmes.ProgrammesId " +
                "WHERE ProgrammeId = @numProg";
            // Executer la requete
            SqlCommand cmd = new SqlCommand(requete, cn);
            cmd.Parameters.AddWithValue("numProg", numProg);
            SqlDataReader reader = cmd.ExecuteReader();
            // Récupérer les résultats de la requete
            while (reader.Read())
            {
                etudiant.Add(new EtudiantGrid
                    (
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetDateTime(4),
                    Convert.ToChar(reader.GetValue(5)),
                    reader.GetString(6)));
            }
            // Fermer le reader
            reader.Close();
            //Fermer la connection
            cn.Close();
            //retourner la liste des programmes
            return etudiant;
        }
    }
}
