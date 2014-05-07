using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    class ExerciseSession
    {
        private DateTime startDateTime;
        public bool speedData = false;
        public bool cadenceData = false;
        public bool altitudeData = false;
        public bool powerData = false;
        public bool powerLeftRightData = false;
        public bool powerPedallingData = false;
        public bool heartRateOnlyData = false;
        public bool imperialData = false;
        public List<int> heartRateValues = new System.Collections.Generic.List<int>();
        public List<int> speedValues = new System.Collections.Generic.List<int>();
        public List<int> cadenceValues = new System.Collections.Generic.List<int>();
        public List<int> altitudeValues = new System.Collections.Generic.List<int>();
        public List<int> powerValues = new System.Collections.Generic.List<int>();
        public List<int> powerLeftRightValues = new System.Collections.Generic.List<int>();
        public List<int> powerPedallingValue = new System.Collections.Generic.List<int>();
        public List<System.DateTime> timeIndexes = new System.Collections.Generic.List<System.DateTime>();
        public double totalDistance = 0.0;
        public double averageSpeed = 0.0;
        public int maximumSpeed = 0;
        public double averageHeartRate = 0.0;
        public int maximumHeartRate = 0;
        public int minimumHeartRate = 0;
        public int averagePower = 0;
        public int maximumPower = 0;
        public double averageAltitude = 0.0;
        public int maximumAltitude = 0;
        public int rowsOfDataRecorded = 0;

        public DateTime getStartDateTime()
        {
            return this.startDateTime;
        }
    }
}
