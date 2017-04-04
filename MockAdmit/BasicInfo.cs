using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FudanAdmission.MockAdmit
{
    public class Applier : IComparable
    {
        public String Name { get; set; }

        public String RegisterNumber { get; set; }

        public Double Score { get; set; }
        public Double MinorScore { get; set; }
        public String Subject { get; set; }
        public String[] PreferedMajor { get; set; }
        public String PreferedMajor1 { get {
                return PreferedMajor.Length >= 1 ? PreferedMajor[0] : "";
        } }
        public String PreferedMajor2
        {
            get
            {
                return PreferedMajor.Length >= 2 ? PreferedMajor[1] : "";
            }
        }
        public String PreferedMajor3
        {
            get
            {
                return PreferedMajor.Length >= 3 ? PreferedMajor[2] : "";
            }
        }
        public String PreferedMajor4
        {
            get
            {
                return PreferedMajor.Length >= 4 ? PreferedMajor[3] : "";
            }
        }
        public String PreferedMajor5
        {
            get
            {
                return PreferedMajor.Length >= 5 ? PreferedMajor[4] : "";
            }
        }
        public String PreferedMajor6
        {
            get
            {
                return PreferedMajor.Length >= 6 ? PreferedMajor[5] : "";
            }
        }
        public bool AcceptChange { get; set; }
        public bool Admitted { get; set; }
        public String AdmittedMajor { get; set; }

        public Double ScoreForAdmitting { get; set; }
        public int CurrentMajorForAdmitting { get; set; }

        public String AdmittedMajorSource { get; set; }
        public Applier(String name, String registerNumber, String subject, Double score, String[] preferedMajor, bool acceptChange)
        {
            this.Name = name;
            this.RegisterNumber = registerNumber;
            this.Subject = subject;
            this.Score = score;
            this.MinorScore = 0;
            this.ScoreForAdmitting = score;
            this.PreferedMajor = preferedMajor;
            this.AcceptChange = acceptChange;
            this.Admitted = false;
            this.AdmittedMajor = "";
            this.AdmittedMajorSource = "";
            this.CurrentMajorForAdmitting = 0;
            this.ScoreForAdmitting = score;
        }

        public void BeAdmittedByMajorOrder(int majorOrder)
        {
            this.Admitted = true;
            this.AdmittedMajor = PreferedMajor[majorOrder];
            this.AdmittedMajorSource = String.Format("{0}志愿", majorOrder + 1);
        }

        public void BeRejectedByMajorOrder(int majorOrder, int scoreGap)
        {
            if (majorOrder < PreferedMajor.Length)
            {
                CurrentMajorForAdmitting += 1;
                ScoreForAdmitting -= scoreGap;
            }
        }

        public int CompareTo(Object obj)
        {
            if (this.ScoreForAdmitting - 0.0000000001 > ((Applier)obj).ScoreForAdmitting)
            {
                return -1;
            }
            else
            {
                if (this.ScoreForAdmitting + 0.0000000001 < ((Applier)obj).ScoreForAdmitting)
                {
                    return 1;
                }
                else
                {
                    if (this.MinorScore - 0.0000000001 > ((Applier)obj).MinorScore)
                    {
                        return 1;
                    }
                    else
                    {
                        if (this.MinorScore + 0.0000000001 < ((Applier)obj).MinorScore)
                        {
                            return -1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    ;
                }
            }
        }
    }

    public class Major
    {
        public String Name { get; set; }
        public String Subject { get; set; }
        public int PlannedCapacity { get; set; }
        public int RemainedCapacity { get; set; }
        public Major(String name, String subject, int plannedCapacity)
        {
            this.Name = name;
            this.Subject = subject;
            this.PlannedCapacity = plannedCapacity;
            this.RemainedCapacity = plannedCapacity;
        }
    }

    public class SubjectCategory
    {
        public String Name { get; set; }

        public int ApplierCount { get; set; }

        public int MajorPlanCount { get; set; }

        public int PlannedAdmissionCount { get; set; }

        public int ActualAdmissionCount { get; set; }
    }


}
