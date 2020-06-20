/*
 * PTra11_03.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

// ※ この問題はCatクラスにコンストラクタを作成してから実施してください。
public class PTra11_03
{
    public static void Main(string[] args)
    {
        // TODO Cat型変数 cat1 を 引数なしでインスタンス化してください。
        var cat1 = new Cat();

        // TODO cat1のnameフィールドを出力してください
        // ※ タマと出力されれば正解
        Console.WriteLine(cat1.name);

        // TODO Cat型変数 cat2 を 引数にミケを渡してインスタンス化してください。
        var cat2 = new Cat("ミケ");

        // TODO cat2のnameフィールドを出力してください
        // ※ ミケと出力されれば正解
        Console.WriteLine(cat2.name);

    }
}
