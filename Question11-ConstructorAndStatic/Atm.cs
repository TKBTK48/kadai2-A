/*
 * Atm.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class Atm
{
    // 預金残高
    int credit = 100000;

    /**
  	 * 預金を引き出す処理を行う。
  	 * 指定した金額を預金残高から減らして、財布の中にお金を追加する
  	 * @param wallet	財布
  	 * @param money		引き出す金額
  	 */
    internal void Withdraw(Wallet wallet, int money)
    {
        // 引き出す金額が預金残高より大きい場合
        if (credit < money)
        {
            Console.WriteLine("預金残高不足です。現金の引き出しに失敗しました。");
        }
        // 引き出す金額が預金残高より小さい場合
        else
        {
            // 預金残高から指定金額を引く
            credit -= money;
            // 財布の中のお金に指定金額を追加
            wallet.money += money;
            Console.WriteLine("ATMの残り残高は" + this.credit + "です");
        }
    }
}
