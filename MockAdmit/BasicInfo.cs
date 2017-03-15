using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockAdmit
{
    public class Applier : IComparable
    {
        public String Name { get; set; }

        public String RegisterNumber { get; set; }

        public Double Score { get; set; }
        public String Subject { get; set; }
        public String[] PreferedMajor { get; set; }
        public String PreferedMajor1 { get; set; }
        public String PreferedMajor2 { get; set; }
        public String PreferedMajor3 { get; set; }
        public String PreferedMajor4 { get; set; }
        public String PreferedMajor5 { get; set; }
        public String PreferedMajor6 { get; set; }
        public bool AcceptChange { get; set; }
        public bool Admitted { get; set; }
        public String AdmittedMajor { get; set; }

        public Double ScoreForAdmitting { get; set; }
        public int CurrentMajorForAdmitting { get; set; }

        public String AdmittedMajorSource { get; set; }
        public Applier(String name, String registerNumber, String subject,Double score,String[] preferedMajor, bool acceptChange) {
            this.Name = name;
            this.RegisterNumber = registerNumber;
            this.Subject = subject;
            this.Score = score;
            this.ScoreForAdmitting = score;
            this.PreferedMajor = preferedMajor;
            if (preferedMajor.Length < 6) {
                preferedMajor.Concat(new String[] { "", "", "", "", "", "" });
            }
            this.PreferedMajor1 = preferedMajor[0];
            this.PreferedMajor2 = preferedMajor[1];
            this.PreferedMajor3 = preferedMajor[2];
            this.PreferedMajor4 = preferedMajor[3];
            this.PreferedMajor5 = preferedMajor[4];
            this.PreferedMajor6 = preferedMajor[5];
            this.AcceptChange = acceptChange;
            this.Admitted = false;
            this.AdmittedMajor = "";
            this.AdmittedMajorSource = "";
            this.CurrentMajorForAdmitting = 0;
            this.ScoreForAdmitting = score;
        }

        public void BeAdmittedByMajorOrder(int majorOrder) {
            this.Admitted = true;
            this.AdmittedMajor = PreferedMajor[majorOrder];
            this.AdmittedMajorSource = String.Format("{0}志愿", majorOrder + 1);
        }

        public void BeRejectedByMajorOrder(int majorOrder, int scoreGap) {
            if (majorOrder < 5)
            {
                CurrentMajorForAdmitting += 1;
                ScoreForAdmitting -= scoreGap;
            }
        }

        public int CompareTo(Object obj)
        {
            if (this.ScoreForAdmitting > ((Applier)obj).ScoreForAdmitting)
            {
                return -1;
            }
            else {
                if (this.ScoreForAdmitting == ((Applier)obj).ScoreForAdmitting)
                {
                    return 0;
                }
                else {
                    return 1;
                }
            }
        }
    }

    public class Major {
        public String Name { get; set; }
        public String Subject { get; set; }
        public int PlannedCapacity { get; set; }
        public int RemainedCapacity { get; set; }
        public Major(String name,String subject, int plannedCapacity) {
            this.Name = name;
            this.Subject = subject;
            this.PlannedCapacity = plannedCapacity;
            this.RemainedCapacity = plannedCapacity;
        }
    }
}
