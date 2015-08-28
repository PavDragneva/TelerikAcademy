namespace StudentClass
{
    using System;
    using StudentClass.Enums;
    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private ulong sSN;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private Speciality speciality;
        private University university;
        private Faculty faculty;

        public Student()
        {

        }
        public Student(string firstName, string middleName, string lastName, ulong sSN, string permaneneAddress, string mobilePhone, string email,
            int course, Speciality speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.PermanentAddress = permaneneAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Speciality Speciality { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public override bool Equals(object param)
        {
            Student st1 = param as Student;
            if (st1.FirstName != this.FirstName)
            {
                return false;
            }
            else if (st1.MiddleName != this.MiddleName)
            {
                return false;
            }
            else if (st1.LastName != this.LastName)
            {
                return false;
            }
            else if (st1.SSN != this.SSN)
            {
                return false;
            }
            else if (st1.PermanentAddress != this.PermanentAddress)
            {
                return false;
            }
            else if (st1.MobilePhone != this.MobilePhone)
            {
                return false;
            }
            else if (st1.Email != this.Email)
            {
                return false;
            }
            else if (st1.Course != this.Course)
            {
                return false;
            }
            else if (st1.Speciality != this.Speciality)
            {
                return false;
            }
            else if (st1.University != this.University)
            {
                return false;
            }
            else if (st1.Faculty != this.Faculty)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2}\nSSN: {10}\nAddress: {3}\nMobile phone: {4}\nEmail: {5}\nCourse: {6}\nUniversity: {7}\nFaculty: {8}\nSpecialty: {9}",
                this.FirstName, this.MiddleName, this.LastName, this.PermanentAddress, this.MobilePhone, this.Email, this.Course, this.University, this.Faculty, this.Speciality, this.SSN);
        }
        public override int GetHashCode()
        {
            return SSN.GetHashCode() ^ Course.GetHashCode();
        }
        public static bool operator ==(Student st1, Student st2)
        {
            if (st1.Equals(st2))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Student st1, Student st2)
        {
            if (st1.Equals(st2))
            {
                return false;
            }
            return true;
        }

        public object Clone()
        {
            Student cloneStudent = new Student();
            cloneStudent.FirstName = this.FirstName;
            cloneStudent.MiddleName = this.MiddleName;
            cloneStudent.LastName = this.LastName;
            cloneStudent.SSN = this.SSN;
            cloneStudent.PermanentAddress = this.PermanentAddress;
            cloneStudent.MobilePhone = this.MobilePhone;
            cloneStudent.Email = this.Email;
            cloneStudent.Course = this.Course;
            cloneStudent.Speciality = this.Speciality;
            cloneStudent.University = this.University;
            cloneStudent.Faculty = this.Faculty;
            return cloneStudent;
        }

        public int CompareTo(Student other)
        {
            int num = this.FirstName.CompareTo(other.FirstName);
            if(num == 0)
            {
                num = this.MiddleName.CompareTo(other.MiddleName);
                if(num == 0)
                {
                    num = this.LastName.CompareTo(other.LastName);
                    if(num == 0)
                    {
                        return this.SSN.CompareTo(other.SSN);
                    }
                }
            }
            return num;
        }
    }
}