﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormUsingC
{
    public class Question
    {
        public int  QuestionId { get; set; }
        public int AnswerId { get; set; }
        public string QuestionText { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectAnswer { get; set; }

    }
}