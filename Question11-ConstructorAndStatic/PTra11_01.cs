/*
 * PTra11_01.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra11_01
{
    public static void Main(string[] args)
    {
        // TODO Wallet型変数 wallet をWallet型のインスタンスで初期化してください。
        var wallet = new Wallet();

        // TODO walletのmoneyフィールドに10000を代入してください。
        wallet.money = 10000;

        // TODO User型変数 user をUser型のインスタンスで初期化してください
        var user = new User();

        // TODO userのnameフィールドに太郎を代入してください。
        user.name = "太郎";

        // TODO userのwalletフィールドに作成したwalletを代入してください。
        user.wallet = wallet;

        // TODO userのConfirmWalletメソッドを実行してください。
        // ※ 太郎の財布の中の残額は10000円です と表示されます。
        user.ConfirmWallet();

        // TODO userのUseMoneyメソッドを 引数1000 で実行してください。
        user.UseMoney(1000);

        // TODO userのConfirmWalletメソッドを再度実行してください。
        // ※ 太郎の財布の中の残額は9000円です と表示されます。
        user.ConfirmWallet();
    }
}
