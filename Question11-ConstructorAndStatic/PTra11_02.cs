/*
 * PTra11_02.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra11_02
{
    public static void Main(string[] args)
    {
        // TODO Wallet型変数 wallet をWallet型のインスタンスで初期化してください。
        var wallet = new Wallet();

        // TODO walletのmoneyフィールドに10000を代入してください。
        wallet.money = 10000;

        // TODO Atm型変数 atm をAtm型のインスタンスで初期化してください
        var atm = new Atm();

        /*
    	 * TODO 以下の引数を渡してatmのWithdrawメソッドを呼びだしてください
    	 * 第一引数 wallet、第二引数 100000
    	 */
        atm.Withdraw(wallet, 100000);

        // TODO walletのmoneyフィールドを出力してください
        // ※ 値が110000になっていれば正解
        Console.WriteLine(wallet.money);

        /*
    	 * TODO 以下の引数を渡してatmのWithdrawメソッドを呼びだしてください
    	 * 第一引数 wallet、第二引数 100000
    	 * ※ 預金残高不足です。現金の引き出しに失敗しましたと出れば正解
    	 */
        atm.Withdraw(wallet, 100000);

        // TODO walletのmoneyフィールドを出力してください
        // ※ 値が110000のまま変わっていなければ正解
        Console.WriteLine(wallet.money);
    }
}
