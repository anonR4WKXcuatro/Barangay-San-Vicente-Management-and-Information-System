namespace BMIS
{
    public class Person
    {
       
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }




        // For Resident Informations
        private string _residentID, _fullName, _fatherName, _motherName, _suffix, _age, _sex, _birthDate, _civilStatus, _nationality, _contactNo, _religion, _occupation,
            _category, _voterstatus, _purok, _address;
        private byte _isDead;
        private byte[] _image;
        public string ResidentID { get => _residentID; set => _residentID = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string FatherName { get => _fatherName; set => _fatherName = value; }
        public string MotherName { get => _motherName; set => _motherName = value; }
        public string Suffix { get => _suffix; set => _suffix = value; }
        public string Age { get => _age; set => _age = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public string BirthDate { get => _birthDate; set => _birthDate = value; }
        public string CivilStatus { get => _civilStatus; set => _civilStatus = value; }
        public string Nationality { get => _nationality; set => _nationality = value; }
        public string ContactNo { get => _contactNo; set => _contactNo = value; }
        public string Religion { get => _religion; set => _religion = value; }
        public string Occupation { get => _occupation; set => _occupation = value; }
        public string Category { get => _category; set => _category = value; }
        public string Voterstatus { get => _voterstatus; set => _voterstatus = value; }
        public string Purok { get => _purok; set => _purok = value; }
        public string Address { get => _address; set => _address = value; }
        public byte[] Image { get => _image; set => _image = value; }
        public byte IsDead { get => _isDead; set => _isDead = value; }
    }

}
