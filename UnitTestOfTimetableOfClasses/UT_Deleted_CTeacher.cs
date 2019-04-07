﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Deleted_CTeacher
	{
		[TestMethod]
		public void Task_248_1() //Удаление существующей строки 
		{
			//arrange 
			CTeacher.DataSet.Tables.Clear();
			MTeacher tcher = new MTeacher("Садовская Ольга Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act 
			CTeacher T = new CTeacher();
			T.Insert(tcher);
			bool actual = T.Delete(tcher);
			//assert 
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Task_248_2() //Удаление не существующей строки 
		{
			//arrange 
			CTeacher.DataSet.Tables.Clear();
			MTeacher tcher = new MTeacher("Садовская Ольга Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = false;
			CTeacher T = new CTeacher();
			//act 
			bool actual = T.Delete(tcher);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}
