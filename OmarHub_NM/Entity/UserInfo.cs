using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OmarHub_NM.DAL.forUserEditTableAdapters;

namespace OmarHub_NM.Entity
{
    public enum ActivateType
    {
        unactivated = 0,
        activated = 1,
        expired=2
    }

    public enum UserType{
        Admin = 1,
        OmarFellow = 2
    }

 public   class UserInfo
{
     public void update()
     {
         new user_nmTableAdapter().UpdateUserInfo(
                user_first_name, user_last_name, user_password, user_gender, user_language, user_mobile_number_country_code, user_mobile_number, user_street, user_city, user_state, user_country, user_postal_code, user_organization_name, user_role_in_organization, user_date_organization_formed.ToString(), user_organization_web_url, user_number_of_employees, user_organization_type, user_organization_annual_budget, user_organization_phone_number_country_code, user_organization_phone_number, user_id

             );
     }
        

        private int user_id;
        private string user_first_name;
        private string user_last_name;
        private string user_password;
        private string user_image;
        private UserType user_role;
        private int user_gender;
        private string user_email;
        private int user_language;
        private string user_mobile_number_country_code;
        private string user_mobile_number;
        private string user_street;
        private string user_city;
        private string user_state;
        private string user_country;
        private string user_postal_code;
        private string user_organization_name;
        private string user_organization_acronym;
        private string user_role_in_organization;
        private DateTime user_date_organization_formed;
        private string user_organization_web_url;
        private int user_number_of_employees;
        private int user_organization_type;
        private int user_organization_annual_budget;
        private string user_organization_phone_number_country_code;
        private string user_organization_phone_number;
        private ActivateType user_activite;
        private DateTime user_last_active;


        
        public int User_id
        { 
            get{ return user_id;}
            set{ user_id = value;}
        }

        public string User_first_name
        { 
            get{ return user_first_name;}
            set{ user_first_name = value;}
        }

        public string User_last_name
        { 
            get{ return user_last_name;}
            set{ user_last_name = value;}
        }

        public string User_password
        { 
            get{ return user_password;}
            set{ user_password = value;}
        }

        public string User_image
        { 
            get{ return user_image;}
            set{ user_image = value;}
        }

        public UserType User_role
        { 
            get{ return user_role;}
            set{ user_role = value;}
        }

        public int User_gender
        { 
            get{ return user_gender;}
            set{ user_gender = value;}
        }

        public string User_email
        { 
            get{ return user_email;}
            set{ user_email = value;}
        }

        public int User_language
        { 
            get{ return user_language;}
            set{ user_language = value;}
        }

        public string User_mobile_number_country_code
        { 
            get{ return user_mobile_number_country_code;}
            set{ user_mobile_number_country_code = value;}
        }

        public string User_mobile_number
        { 
            get{ return user_mobile_number;}
            set{ user_mobile_number = value;}
        }

        public string User_street
        { 
            get{ return user_street;}
            set{ user_street = value;}
        }

        public string User_city
        { 
            get{ return user_city;}
            set{ user_city = value;}
        }

        public string User_state
        { 
            get{ return user_state;}
            set{ user_state = value;}
        }

        public string User_country
        { 
            get{ return user_country;}
            set{ user_country = value;}
        }

        public string User_postal_code
        { 
            get{ return user_postal_code;}
            set{ user_postal_code = value;}
        }

        public string User_organization_name
        { 
            get{ return user_organization_name;}
            set{ user_organization_name = value;}
        }

        public string User_organization_acronym
        { 
            get{ return user_organization_acronym;}
            set{ user_organization_acronym = value;}
        }

        public string User_role_in_organization
        { 
            get{ return user_role_in_organization;}
            set{ user_role_in_organization = value;}
        }

        public DateTime User_date_organization_formed
        { 
            get{ return user_date_organization_formed;}
            set{ user_date_organization_formed = value;}
        }

        public string User_organization_web_url
        { 
            get{ return user_organization_web_url;}
            set{ user_organization_web_url = value;}
        }

        public int User_number_of_employees
        { 
            get{ return user_number_of_employees;}
            set{ user_number_of_employees = value;}
        }

        public int User_organization_type
        { 
            get{ return user_organization_type;}
            set{ user_organization_type = value;}
        }

        public int User_organization_annual_budget
        { 
            get{ return user_organization_annual_budget;}
            set{ user_organization_annual_budget = value;}
        }

        public string User_organization_phone_number_country_code
        { 
            get{ return user_organization_phone_number_country_code;}
            set{ user_organization_phone_number_country_code = value;}
        }

        public string User_organization_phone_number
        { 
            get{ return user_organization_phone_number;}
            set{ user_organization_phone_number = value;}
        }

        public ActivateType User_activite
        { 
            get{ return user_activite;}
            set{ user_activite = value;}
        }

        public DateTime User_last_active
        { 
            get{ return user_last_active;}
            set{ user_last_active = value;}
        }

     }
}



