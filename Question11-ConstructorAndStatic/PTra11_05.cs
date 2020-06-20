/*
 * PTra11_05.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;

public class PTra11_05
{
    // ※ この問題はJam、Toastクラスを完成させてから実施してください
    public static void Main(string[] args)
    {
        // TODO Jam型のインスンタンスを引数 ブルーベリー で作成してください
        var jam = new Jam("ブルーベリー");

        // TODO Toast型のインスンタンスを作成してください。
        var toast = new Toast(jam);

        // TODO 作成したToast型インスタンスからTasteメソッドを呼び出してください
        toast.Taste();
        
    }
}
