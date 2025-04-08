using DataModel;
using System.Management.Automation;

namespace PowerShellCookbook
{
    [Cmdlet("Add", "Team")]
    public class AddTeam : Cmdlet
    {
        [Parameter(Mandatory = true)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _name;

        DBContextMain dbModel = new DBContextMain();
        protected override void BeginProcessing()
        {
        }
        protected override void ProcessRecord()
        {
            dbModel.Add(new Team() { Name = _name });
        }
        protected override void EndProcessing()
        {
            dbModel.SaveChanges();
            dbModel.Dispose();
        }
    }
}