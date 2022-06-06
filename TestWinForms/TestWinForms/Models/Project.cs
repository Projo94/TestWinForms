namespace TestWinForms.Models
{
    public class Project
    {
        public string ProjectUID { get; set; }
        public string ProjectName { get; set; }
        public bool IsAcceptingNewVisits { get; set; }
        public string SupportedImageType { get; set; }

        public Project(string projectUID, string projectName, bool isAcceptingNewVisits, string supportedImageType)
        {
            ProjectUID = projectUID;
            ProjectName = projectName;
            IsAcceptingNewVisits = isAcceptingNewVisits;
            SupportedImageType = supportedImageType;
        }

        public Project(string projectName, bool isAcceptingNewVisits, string supportedImageType)
        {
            ProjectName = projectName;
            IsAcceptingNewVisits = isAcceptingNewVisits;
            SupportedImageType = supportedImageType;
        }

        public Project()
        {

        }
    }
}
