using System;
using System.Collections.Generic;
using rKeeper_c.airn;
using rKeeper_c.common;

namespace rKeeper_c.member
{
    public class Member
    {
        private String _PMKeys;
        private String _LastName;
        private String _FirstName;
        private List<BFA> _BFAResults;
        private List<Weapon> _Weapons;
        private List<Dental> _Dentals;
        private MedicalClass _MedicalStatus;


        public Member(string pmkeys, string lastName, string firstName)
        {
            this._PMKeys = pmkeys;
            this._LastName = lastName;
            this._FirstName = firstName;
        }

        public string PMKeys
        {
            get => _PMKeys;
        }

        public void setPMKeys(string pmkeys)
        {
            if (AssertPMKeysFormat(pmkeys))
            {
                this._PMKeys = pmkeys;
            }
            else
            {
                throw new Exception("Invalid PMKeys Number");
            }
        }

        public MedicalClass MedicalStatus
        {
            get { return _MedicalStatus; }
            set { this._MedicalStatus = value; }
        }

        public List<BFA> BFAResults
        {
            get => this._BFAResults;
            set => this._BFAResults = value;
        }

        public void AddBFAResult(DateTime BFADate, int pushups, int situps, string run)
        {
            if (this._BFAResults == null)
                this._BFAResults = new List<BFA>();

            this._BFAResults.Add(new BFA(BFADate, pushups, situps, run));

        }

        public string FirstName
        {
            get => _FirstName;
            set => _LastName = value;
        }

        public string LastName
        {
            get => _LastName;
            set => _LastName = value;
        }

        private bool AssertPMKeysFormat(string pmkeys)
        {
            return pmkeys.Length.Equals(7);
        }


    }
}
