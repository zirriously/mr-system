using System;
using System.Collections.Generic;

namespace mr_system.Model
{
    public class CaseOwner
    {
        private string _caseOwner;
        private List<CaseOwner> _caseOwnerList;

        public CaseOwner(string name)
        {
            _caseOwner = name;

            _caseOwnerList.Add(new CaseOwner("hej"));
            _caseOwnerList.Add(new CaseOwner("heee"));
            _caseOwnerList.Add(new CaseOwner("heeeeeeeeeeeeee"));
        }

        public List<CaseOwner> CaseOwners => _caseOwnerList;


    }
}