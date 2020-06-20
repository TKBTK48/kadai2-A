/*
 * Cat.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using System.Security.Cryptography.X509Certificates;

public class Cat
{
    internal string name;

    /*
  	 *  TODO 以下のコンストラクタを作成してください。
  	 *  引数 なし
  	 *  nameフィールドに タマ を代入する
  	 */
    public Cat()
    {
        name = "タマ";
    }


    /*
  	 *  TODO 以下のコンストラクタを作成してください。
  	 *  引数 string name
  	 *  nameフィールドに 引数に渡された name を代入する
  	 */
    public Cat(string inputname)
    {
        name = inputname;
    }
    
}
