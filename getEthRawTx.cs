using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.TransactionManagers;
using Nethereum.Signer;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace mint
{
    class getEthRawTx
    {
        public string from;
        public HexBigInteger nonce;
        public HexBigInteger gasLimit;
        public HexBigInteger gasPrice;
        public string to;
        public HexBigInteger value;
        public string data;
        public int chainId;

        public getEthRawTx(string fromAddress, string contractAddress, string toAddress, Contract contractObj, int _tokenAmount, int nonceNum, string privKey)
        {
            from = fromAddress;
            nonce = new HexBigInteger(nonceNum);
            gasLimit = new HexBigInteger(60000000);
            gasPrice = new HexBigInteger((BigInteger)10e9);
            to = contractAddress;
            value = new HexBigInteger(0);
            data = contractObj.GetFunction("transferFrom").SendTransactionAsync(fromAddress, toAddress, _tokenAmount).ToString();
            chainId = 80001;

        }
    }
}
