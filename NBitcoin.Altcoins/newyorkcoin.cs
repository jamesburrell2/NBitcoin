using NBitcoin;
using NBitcoin.DataEncoders;
using NBitcoin.Protocol;
using NBitcoin.RPC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NBitcoin.Altcoins
{
	// Reference: https://github.com/NewYorkCoin-NYC/nycoin/blob/master/src/chainparams.cpp
public class Nycoin : NetworkSetBase

{
		public static Nycoin Instance { get; } = new Nycoin();

		public override string CryptoCode => "NYC";

		private Nycoin()
		{

		}
		public class NYCConsensusFactory : ConsensusFactory
		{
			private NycConsensusFactory()
			{
			}
			public static NycConsensusFactory Instance { get; } = new NycConsensusFactory();

			public override BlockHeader CreateBlockHeader()
			{
				return new NycoinBlockHeader();
			}
			public override Block CreateBlock()
			{
				return new NycoinBlock(new DogecoinBlockHeader());
			}
}
