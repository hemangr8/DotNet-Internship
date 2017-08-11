using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentWebApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetStudentDetail" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetStudentDetail.svc or GetStudentDetail.svc.cs at the Solution Explorer and start debugging.
    public class GetStudentDetail : IGetStudentDetail
    {
        public string ShowRollNo(StudentClass student)
        {
            return "Roll No. is:" + student.RollNo;
        }

        public string ShowName(StudentClass student)
        {
            return "Name is:" + student.Name;
        }

        public string ShowGrade(StudentClass student)
        {
            return "Grade is:" + student.Grade;
        }
    }
}
