/*
 * Student.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class Student
{
    internal string name;            // 生徒の名前
    internal static string group;    // 教室の名前
    internal static string teacher;  // 先生の名前

    /**
  	 * 生徒のプロフィールを出力する
  	 */
    internal void StudentProfile()
    {
        Console.WriteLine(this.name + "は" + group + "教室の生徒です");
    }

    /**
  	 * 教室のプロフィールを出力する。
  	 */
    internal static void GroupProfile()
    {
        Console.WriteLine(group + "教室の担任は" + teacher + "先生です。");
    }
}
