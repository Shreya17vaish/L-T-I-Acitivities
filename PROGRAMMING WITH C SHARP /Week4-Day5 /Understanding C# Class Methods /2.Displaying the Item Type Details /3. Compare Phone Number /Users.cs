using System;

namespace UserAccount
{
    class User
    {
        private string _name;
        private string _username;
        private string _password;
        private long _phoneNumber;

        public User(string name, string username, string password, long phoneNumber)
        {
            _name = name;
            _username = username;
            _password = password;
            _phoneNumber = phoneNumber;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public bool ComparePhoneNumber(User user)
        {
            return _phoneNumber == user.PhoneNumber;
        }
    }
}

