using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentWebApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetStudentDetail" in both code and config file together.
    [ServiceContract]
    public interface IGetStudentDetail
    {
        [OperationContract]
        string ShowRollNo(StudentClass student);
        string ShowName(StudentClass student);
        string ShowGrade(StudentClass student);
    }
}
