﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) :base(name, isWeighted)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new
                    InvalidOperationException
                    ("Ranked-grading requires a minimum of " +
                    "5 students to work");
            }
            else if (averageGrade >= 80)
            {
                return 'A';
            }
            else if (averageGrade >= 60 && averageGrade < 80)
            {
                return 'B';
            }
            else if (averageGrade >= 40 && averageGrade < 60)
            {
                return 'C';
            }
            else if (averageGrade >= 20 && averageGrade < 40)
            {
                return 'D';
            }
            return 'F';

        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students " +
                    "with grades in order to properly calculate a student's overall grade.");
                return;

            }
            base.CalculateStudentStatistics(name);
        }
        /// <summary>
        /// 
        /// </summary>
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students " +
                    "with grades in order to properly calculate a student's overall grade.");
                return;

            }

            base.CalculateStatistics();
        }
    }
}
