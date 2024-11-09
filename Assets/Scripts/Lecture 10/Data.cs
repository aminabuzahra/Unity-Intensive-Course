using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Reporting.Builders.Rendering;
using UnityEngine;

namespace Lecture10
{
    public struct Data
    {
        public string student;
        public int mark;

        public Data(string stduentName, int mark)
        {
            this.student = stduentName;
            this.mark = mark;
        }
    }
}