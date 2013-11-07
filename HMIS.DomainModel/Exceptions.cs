using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMIS.DomainModel
{
    [Serializable]
    public class AddNewDoctorException : Exception
    {
    }

    [Serializable]
    public class DoctorIDAlreadyExsistsException : Exception
    {
    }

    [Serializable]
    public class DoctorDoesntExsistException : Exception
    {
    }

    [Serializable]
    public class RemoveDoctorException : Exception
    {
    }

    [Serializable]
    public class DoctorIDDoesntExsistsException : Exception
    {
    }

    [Serializable]
    public class DoctorNameDoesntExsistsException : Exception
    {
    }

    [Serializable]
    public class InvalidNameException : Exception
    {
    }

    [Serializable]
    public class InvalidAddressException : Exception
    {
    }

    [Serializable]
    public class InvalidIDException : Exception
    {
    }

    [Serializable]
    public class InvalidUsernameException : Exception
    {
    }

    [Serializable]
    public class InvalidPasswordException : Exception
    {
    }

    [Serializable]
    public class NurseIDAlreadyExsistsException : Exception
    {
    }

    [Serializable]
    public class PatientDAlreadyExsistsException : Exception
    {
    }
}
