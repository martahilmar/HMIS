using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMIS.DomainModel
{
    public class Patient
    {
        private string _name;
        private int _ID;
        private string _address;
        private string _doctorName;
        private int _doctorID;
        private bool _delete;

        private string _diagnosis;
        private bool _temperature;
        private string _temperatureValue;
        private bool _pulse;
        private string _pulseValue;
        private bool _bloodPreasure;
        private string _bloodPreasureValue;
        private bool _saturation;
        private string _saturationValue;
        private bool _morningTherapy;
        private bool _dayTherapy;
        private bool _eveningTherapy;
        private string _doctorDiagnosis;

        Doctor doctor = new Doctor();

        public Patient()
        {
        }

        public Patient(int ID, string name, string address, string doctorName, int doctorID)
        {
            _name = name;
            _ID = ID;
            _address = address;
            _doctorName = doctorName;
            _doctorID = doctorID;
        }

        public Doctor MainDoctor
        {
            get { return doctor; }
            set { doctor = value; }
        }

        public int ID
        {
            get { return _ID; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string DoctorName
        {
            get { return _doctorName; }
        }

        public int DoctorID
        {
            get { return _doctorID; }
        }

        public bool Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        /**************************************
         * Diagnosis values
         **************************************/

        public string Diagnosis
        {
            get { return _diagnosis; }
            set { _diagnosis = value; }
        }

        public bool Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public string TemperatureValue
        {
            get { return _temperatureValue; }
            set { _temperatureValue = value; }
        }

        public bool Pulse
        {
            get { return _pulse; }
            set { _pulse = value; }
        }

        public string PulseValue
        {
            get { return _pulseValue; }
            set { _pulseValue = value; }
        }

        public bool BloodPreasure
        {
            get { return _bloodPreasure; }
            set { _bloodPreasure = value; }
        }

        public string BloodPreasureValue
        {
            get { return _bloodPreasureValue; }
            set { _bloodPreasureValue = value; }
        }

        public bool Saturation
        {
            get { return _saturation; }
            set { _saturation = value; }
        }

        public string SaturationValue
        {
            get { return _saturationValue; }
            set { _saturationValue = value; }
        }

        public bool MorningTherapy
        {
            get { return _morningTherapy; }
            set { _morningTherapy = value; }
        }

        public bool DayTherapy
        {
            get { return _dayTherapy; }
            set { _dayTherapy = value; }
        }

        public bool EveningTherapy
        {
            get { return _eveningTherapy; }
            set { _eveningTherapy = value; }
        }

        public string DoctorDiagnosis
        {
            get { return _doctorDiagnosis; }
            set { _doctorDiagnosis = value; }
        }
    }
}
