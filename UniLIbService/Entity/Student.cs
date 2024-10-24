﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniLIbService
{
    public class Student: Person
    {
        public string Matricola { get; set; }
        public string Department { get; set; }
        public DateTime? AnnoDiIscrizione { get; set; }
      //  public List<Exam> Exams { get; set; } = new();

        public Student() : base() { }
        public Student(string name, string sureName, int age, string gender, string matricola, string department, DateTime annoDiIscrizione)
         : base(name, sureName, age, gender)
        {
            Department = department;
            Matricola = matricola;
            AnnoDiIscrizione = annoDiIscrizione;
        }
        public override string ToString()
        {
            return $"{base.ToString()}|Matricola: {Matricola}| Corso: {Department}| Anno di iscrizione: {AnnoDiIscrizione}|";
        }
    }

}

