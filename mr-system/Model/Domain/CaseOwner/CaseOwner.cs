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

            _caseOwnerList.Add(new CaseOwner("MR Staff"));
            _caseOwnerList.Add(new CaseOwner("Jan Frølich Wulff"));
            _caseOwnerList.Add(new CaseOwner("Thomas Levin"));
        }
        public List<CaseOwner> CaseOwners => _caseOwnerList;
    }
}