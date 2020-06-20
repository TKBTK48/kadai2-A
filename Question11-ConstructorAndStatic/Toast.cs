/*
 * Toast.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using System.Runtime.InteropServices;

public class Toast
{

    // TODO Jam型のフィールドjamを作成してください
    public Jam jam;

    /*
  	 *  TODO 以下のコンストラクタを作成してください
  	 *  引数		：Jam型 jam
  	 *  処理		：引数のjamをjamフィールドに代入する
  	 */
    public Toast(Jam jam)
    {
        this.jam = jam;
    }


    /*
  	 *  TODO Tasteメソッドを作成してください
  	 *  引数		：なし
  	 *  戻り値	：なし
  	 *  処理		：xx 味のトーストです。 出力する
  	 *  ※ xxにはjamフィールドのmaterialの値が入る
  	 */
    public void Taste()
    {
        Console.WriteLine($"{Jam.material}味のトーストです。");
    }

}
