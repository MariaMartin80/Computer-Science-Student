using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
    class CompSciStudent : Student
    {
        //Constants
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_Hours = 60;

        //fields
        private string _academicTrack;

        //Constructor
        public CompSciStudent(string name, string id, string track)
            : base(name, id)
        {
            _academicTrack = track;
        }

        //academictrack property
        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }

        //requiredhours property
        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_Hours; }
        }
    }
}
