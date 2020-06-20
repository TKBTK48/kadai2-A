/*
 * User.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

﻿using System;

public class User
{
    internal string name;
    internal Wallet wallet;

    /**
  	 * 引数で渡された金額を、walletフィールドのmoneyから引く
  	 * @param money
  	 */
    internal void UseMoney(int money)
    {
        this.wallet.money -= money;
        Console.WriteLine(this.name + "は財布の中のお金を" + money + "円使用しました");
    }

    /**
  	 * 財布の中の金額を出力する
  	 */
    internal void ConfirmWallet()
    {
        Console.WriteLine(this.name + "の財布の中の残額は" + this.wallet.money + "円です");
    }
}
