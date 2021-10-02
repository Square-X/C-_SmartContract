
using System;
using System.Text;
using Nethereum.Hex.HexConvertors.Extensions;
using System.Threading.Tasks;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Nethereum.Contracts;
using Nethereum.ABI.FunctionEncoding.Attributes;
using System.Numerics;
using Nethereum.RPC.TransactionManagers;

public class Program
{
    static async Task Main(string[] args)
{

        var myaddress = "0x8AF41Cacb5FE289587292BA3c7eaa4a65b383c80";
        var privateKey = "91218c9ef59fe4ae8fda0cb0c8086756191f311850e673721822dcabce1c99c9";
        //var account = new Account(privateKey, 80001);
        var account = new Account(privateKey, 1);
        var web3 = new Web3(account, "https://mainnet.infura.io/v3/69c833c16d17444cabe16e9a50c15b6b");
        //var web3 = new Web3(account, "https://matic-mumbai.chainstacklabs.com");
        var contractAddress = "0x869ad3dfb0f9acb9094ba85228008981be6dbdde";         //Ethereum mainnet 
       
        var abi = @"[{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""chestComponents"",""outputs"":[{""internalType"":""uint256[5]"",""name"":"""",""type"":""uint256[5]""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""footComponents"",""outputs"":[{""internalType"":""uint256[5]"",""name"":"""",""type"":""uint256[5]""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""getChest"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""getFoot"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""getHand"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""getHead"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""getNeck"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""getRing"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""getWaist"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""getWeapon"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""handComponents"",""outputs"":[{""internalType"":""uint256[5]"",""name"":"""",""type"":""uint256[5]""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""headComponents"",""outputs"":[{""internalType"":""uint256[5]"",""name"":"""",""type"":""uint256[5]""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""neckComponents"",""outputs"":[{""internalType"":""uint256[5]"",""name"":"""",""type"":""uint256[5]""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""ringComponents"",""outputs"":[{""internalType"":""uint256[5]"",""name"":"""",""type"":""uint256[5]""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""tokenURI"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""waistComponents"",""outputs"":[{""internalType"":""uint256[5]"",""name"":"""",""type"":""uint256[5]""}],""stateMutability"":""view"",""type"":""function""},{""inputs"":[{""internalType"":""address"",""name"":""walletAddress"",""type"":""address""}],""name"":""weaponComponents"",""outputs"":[{""internalType"":""uint256[5]"",""name"":"""",""type"":""uint256[5]""}],""stateMutability"":""view"",""type"":""function""}]";
        var contract = web3.Eth.GetContract(abi , contractAddress);

        var getWeapon = contract.GetFunction("getWeapon");
        var weapon = await getWeapon.CallAsync<string>(myaddress);
        Console.WriteLine($"weapon: {weapon}");
        
        var getChest = contract.GetFunction("getChest");
        var chest = await getChest.CallAsync<string>(myaddress);
        Console.WriteLine($"chest: {chest}");

        var getHead = contract.GetFunction("getHead");
        var head = await getHead.CallAsync<string>(myaddress);
        Console.WriteLine($"head: {head}");

        var getWaist = contract.GetFunction("getWaist");
        var waist = await getWaist.CallAsync<string>(myaddress);
        Console.WriteLine($"waist: {waist}");

        var getFoot = contract.GetFunction("getFoot");
        var foot = await getFoot.CallAsync<string>(myaddress);
        Console.WriteLine($"foot: {foot}");

        var getHand = contract.GetFunction("getHand");
        var hand = await getHand.CallAsync<string>(myaddress);
        Console.WriteLine($"hand: {hand}");

        var getNeck = contract.GetFunction("getNeck");
        var neck = await getNeck.CallAsync<string>(myaddress);
        Console.WriteLine($"neck: {neck}");

        var getRing = contract.GetFunction("getRing");
        var ring = await getRing.CallAsync<string>(myaddress);
        Console.WriteLine($"ring: {ring}");

    }

}
