/*
 * PTra11_04.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra11_04
{

    // この問題はStudentクラスを利用して解いてください。
    public static void Main(string[] args)
    {
        // TODO 生徒の名前に 太郎 を設定してください。
        var student= new Student();
        student.name = "太郎";

        // TODO 教室の名前に A を設定してください。
        Student.group = "A";

        // TODO 先生の名前に 山田 を設定してください。
        Student.teacher = "山田";


        // TODO StudentProfileメソッドを実行してください。
        // ※ 太郎はA教室の生徒です と表示されれば正解
        student.StudentProfile();

        // TODO GroupProfileメソッドを実行してください
        // ※ A教室の担任は山田先生です。 と表示されれば正解
        Student.GroupProfile();
    }
}
