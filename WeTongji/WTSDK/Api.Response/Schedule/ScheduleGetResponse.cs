using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Response
{
    public class ScheduleGetResponse : WTResponse
    {
        public ScheduleGetResponse() 
        {
            Exams = null;
            Activities = null;
        }

        public WeTongji.Api.Domain.Exam[] Exams { get; set; }
        public WeTongji.Api.Domain.Activity[] Activities { get; set; }
    }
}
