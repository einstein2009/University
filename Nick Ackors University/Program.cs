// ***********************************************************************
// Assembly         : University structor
// Author           : Nick Ackors
// Created          : 11-20-2016
//
// Last Modified By : Nick Ackors
// Last Modified On : 11-20-2016
// ***********************************************************************
// <copyright file="Program.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary>This program displays the OOP structor of a University.</summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick_Ackors_University
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Staff teacher = new Staff();
            teacher.Name = "John Snow";

            Console.ReadKey();

            
            var u = new University();
            Console.WriteLine(u.Department[2].Staff[3].Name);
            u.Department[1].Staff[0] = new Researcher("Andy");
            
        }
       
    }
}

/*
1. Create a program with the following OO structure - you do not have to implement any of the methods other than constructors to fill in some default data. You should implement the rest of the methods with a Console.WriteLine to indicate that it has been called.

Within a UNIVERSITY there are 4 DEPARTMENTS

MATH, ENGLISH, GEOGRAPHY, COMPUTERSCIENCE

Each DEPARTMENT has up to 10 STAFF

There is a DEAN, PROFESSORs, ADMINISTRATORs and RESEARCHERs

All Staff should have a name and salary

Professors should have a Class

Researchers should have a ResearchSpeciality which is a fixed set of research areas represented by an enumeration

Deans, Professors and Researchers should implement an  ITeachable interface which contains the Teach() method

Deans and Administrators should implement an  IAdmin interface which contains the Administrate() method

Pay special attention to the IS-A relationships and the HAS-A relationships and implement things correctly.

You should determine reasonable types for all properties not otherwise specified and initialise things with sensible defaults. Your constructors should have reasonable parameters to set up the type where you cannot simply use constants.

var u = new University();
Console.WriteLine(u.Department[2].Staff[3].Name);

u.Department[1].Staff[0] = new Researcher("Andy");

You should create additional test code to make sure that all of the properties and methods are available
*/
