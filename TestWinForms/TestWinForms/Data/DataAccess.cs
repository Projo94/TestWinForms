using Npgsql;
using System.Collections.Generic;
using TestWinForms.Helper;
using TestWinForms.Models;

namespace TestWinForms.Data
{
    static class DataAccess
    {
        private static readonly string cs = System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        public static bool CheckUser(User user)
        {
            var isFound = false;

            using (var conn = new NpgsqlConnection(cs))
            {
                var sql = $"SELECT username, password FROM users WHERE username='{user.Username}' and password='{user.Password}'";

                conn.Open();

                var cmd = new NpgsqlCommand(sql, conn);
                var dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    isFound = true;
                }

                dr.Close();

                return isFound;
            }
        }

        public static void SaveProject(Project project)
        {
            var sql = $"INSERT INTO projects(project_name, is_accepting_new_visits, supported_image_type)" +
                      $"VALUES ('{project.ProjectName}',{project.IsAcceptingNewVisits},'{project.SupportedImageType}')";

            using (var conn = new NpgsqlConnection(cs))
            {
                conn.Open();

                var cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static ICollection<Project> ReturnAllProjects()
        {
            var allProject = new List<Project>();

            using (var conn = new NpgsqlConnection(cs))
            {
                var sql = "SELECT projects_uid, project_name,is_accepting_new_visits, supported_image_type FROM projects";
                conn.Open();
                var cmd = new NpgsqlCommand(sql, conn);
                var dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var projectUid = dr.GetStringNullable("projects_uid");
                        var projectName = dr.GetStringNullable("project_name");
                        var isAcceptingNewVisits = dr.GetBoolNullable("is_accepting_new_visits");
                        var supportedImageType = dr.GetStringNullable("supported_image_type");

                        var project = new Project(projectUid, projectName, isAcceptingNewVisits, supportedImageType);
                        allProject.Add(project);
                    }
                }
            }

            return allProject;
        }
    }
}