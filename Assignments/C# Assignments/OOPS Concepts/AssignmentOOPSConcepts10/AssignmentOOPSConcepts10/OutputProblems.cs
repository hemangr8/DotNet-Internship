using System;

class Student
{

    internal int _age;

    int _rollNo;
}

class CollegeStudent
{

    public static void Main()
    {

        var stu = new CollegeStudent();

        stu._age = 10;
    }

}

//Answer to Problem 1: The program will not run successfully because the class CollegeSutdent does not inherit class Student and still
//its object uses a protected type member of class Student namely _age.
//protected members can only be used by the type itself and its derived types.
//So there will be a compiler error.



//Answer to Problem 2: Though the Student assembly is refered in the University assembly the instance of class UnivPeople
//will not be able to access the protected internal member _age since the class UnivPeople does not inherit any class
//from the Student assembly. Therefore the program will not run. It will show a compile time error.