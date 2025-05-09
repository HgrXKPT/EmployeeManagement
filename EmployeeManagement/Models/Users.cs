namespace EmployeeManagement.Models
{
    public class Users
    {
        private string _name = string.Empty;
        private string _rg = string.Empty;
        private string _departament = string.Empty;

        public Users(string name, string rg, string departament) { 
            _name = name;
            _rg = rg;
            _departament = departament;
                }
        public Users()
        {
        }

        public Users(string rg)
        {
            _rg = rg;
        }

        public int Id {get;set;}

        public string Name
        {
            get => _name;
            set {
                _name = value.Trim();
            } 
        }

        public string Rg
        {
        
        get => _rg;
        set
            {
                if(string.IsNullOrWhiteSpace(value))
                   throw new ArgumentNullException("Null or white space in string will not be accepted.");
                _rg = value.Trim();
            }
        }

        public string Departament
        {
        
        get => _departament;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Null or white space in string will not be accepted.");
                _departament = value.Trim();
            }
        }



    }
}
